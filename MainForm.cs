using System.Management;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace WSLConfigManager
{
    public partial class MainForm : Form
    {
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;

        private string userHomeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private string configFile = "/.wslconfig";

        public MainForm()
        {
            InitializeComponent();

            this.contextMenuStrip = new ContextMenuStrip();
            this.exitToolStripMenuItem = new ToolStripMenuItem();
            this.editToolStripMenuItem = new ToolStripMenuItem();

            // Initialize the context menu
            this.contextMenuStrip.Items.AddRange(new ToolStripItem[] { this.editToolStripMenuItem, this.exitToolStripMenuItem });

            // Initialize the exit menu item
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);

            // Initialize the edit menu item
            this.editToolStripMenuItem.Text = "Edit Config";
            this.editToolStripMenuItem.Click += new EventHandler(EditToolStripMenuItem_Click);

            // Initialize the notify icon
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip;

            LoadMaxValuesForSliders();
            LoadWSLConfig();

            this.Load += new EventHandler(MainForm_Load);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Prevent the form from actually closing and hide it instead.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Focus();
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private void memorySlider_ValueChanged(object sender, EventArgs e)
        {
            memoryValue.Text = memorySlider.Value.ToString();
        }

        private void processorsSlider_ValueChanged(object sender, EventArgs e)
        {
            processorsValue.Text = processorsSlider.Value.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.SaveWSLConfig();
            this.Hide();
        }

        private void saveAndRestartButton_Click(object sender, EventArgs e)
        {
            this.SaveWSLConfig();
            this.RestartWSL();
            this.Hide();
        }

        private void LoadWSLConfig()
        {
            // Get the path to the .wslconfig file in the user's home directory
            string wslConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".wslconfig");

            // Check if the .wslconfig file exists
            if (File.Exists(wslConfigPath))
            {
                // Read the content of the .wslconfig file
                string content = File.ReadAllText(wslConfigPath);

                // Use regex to parse the values for memory and processors
                var memoryRegex = new Regex(@"memory=(\d+)GB");
                var processorsRegex = new Regex(@"processors=(\d+)");

                var memoryMatch = memoryRegex.Match(content);
                var processorsMatch = processorsRegex.Match(content);

                if (memoryMatch.Success)
                {
                    int memoryValue = int.Parse(memoryMatch.Groups[1].Value);
                    memorySlider.Value = memoryValue;
                }

                if (processorsMatch.Success)
                {
                    int processorsValue = int.Parse(processorsMatch.Groups[1].Value);
                    processorsSlider.Value = processorsValue;
                }

                // Update the labels to show the loaded values
                memoryValue.Text = memorySlider.Value.ToString();
                processorsValue.Text = processorsSlider.Value.ToString();

                // Parse and set other options here based on your input components
            }
        }

        private void SaveWSLConfig()
        {
            // Generate the content based on the input components
            string content = $"# Settings apply across all Linux distros running on WSL 2\n" +
                             $"[wsl2]\n" +
                             $"\n" +
                             $"# Limits VM memory to use no more than {memorySlider.Value} GB\n" +
                             $"memory={memorySlider.Value}GB\n" +
                             $"\n" +
                             $"# Sets the VM to use {processorsSlider.Value} virtual processors\n" +
                             $"processors={processorsSlider.Value}\n";

            // Add other options here based on your input components

            // Get the path to the .wslconfig file in the user's home directory
            string wslConfigPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".wslconfig");

            // Save the content to the .wslconfig file, overriding any existing content
            File.WriteAllText(wslConfigPath, content);
        }

        private void LoadMaxValuesForSliders()
        {
            ulong maxMemoryKB = GetTotalMemory();
            int maxVirtualProcessors = GetProcessorCores();

            // Convert the memory from KB to GB
            int maxMemoryGB = (int)Math.Ceiling((double)maxMemoryKB / 1024 / 1024);

            // Set the maximum value of the sliders
            memorySlider.Maximum = maxMemoryGB;
            processorsSlider.Maximum = maxVirtualProcessors;

            // Set the initial value of the sliders
            memorySlider.Value = 4; // Example default value
            processorsSlider.Value = 2; // Example default value

            // Update the labels to show the initial values
            memoryValue.Text = memorySlider.Value.ToString();
            processorsValue.Text = processorsSlider.Value.ToString();
        }

        private ulong GetTotalMemory()
        {
            ObjectQuery query = new ObjectQuery("SELECT TotalVisibleMemorySize FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            foreach (ManagementObject mo in searcher.Get())
            {
                ulong totalMemory = (ulong)mo["TotalVisibleMemorySize"];
                return totalMemory;
            }

            return 0;
        }

        private int GetProcessorCores()
        {
            ObjectQuery query = new ObjectQuery("SELECT NumberOfCores FROM Win32_Processor");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            int totalCores = 0;

            foreach (ManagementObject mo in searcher.Get())
            {
                totalCores += (int)(uint)mo["NumberOfCores"];
            }

            return totalCores;
        }

        private void RestartWSL()
        {
            KillAllWSLInstances();
            StartWSLInstance();
        }

        private void KillAllWSLInstances()
        {
            Process[] wslProcesses = Process.GetProcessesByName("wsl");
            foreach (Process process in wslProcesses)
            {
                try
                {
                    process.Kill();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during the process killing
                    Console.WriteLine("Error killing process: " + ex.Message);
                }
            }
        }

        private void StartWSLInstance()
        {
            Process.Start("wsl.exe");
        }
    }
}
