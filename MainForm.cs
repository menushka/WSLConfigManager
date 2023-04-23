using System;
using System.IO;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string configPath = userHomeDirectory + configFile;
            if (!File.Exists(configPath))
            {
                using (StreamWriter sw = File.CreateText(configPath))
                {
                    sw.WriteLine("[wsl2]");
                    sw.WriteLine("# Default options");
                    sw.WriteLine("# memory=4GB");
                    sw.WriteLine("# processors=2");
                }
            }
        }
    }
}
