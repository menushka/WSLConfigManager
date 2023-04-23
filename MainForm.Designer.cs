namespace WSLConfigManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            notifyIcon1 = new NotifyIcon(components);
            memoryLabel = new Label();
            memorySlider = new TrackBar();
            memoryValue = new Label();
            processorsLabel = new Label();
            processorsSlider = new TrackBar();
            processorsValue = new Label();
            kernelLabel = new Label();
            kernelTextbox = new TextBox();
            kernelCommandLineLabel = new Label();
            kernelCommandLineTextbox = new TextBox();
            swapLabel = new Label();
            swapTextbox = new TextBox();
            pageReportingCheckbox = new CheckBox();
            localhostForwardingCheckbox = new CheckBox();
            nestedVirtualizationCheckbox = new CheckBox();
            debugConsoleCheckbox = new CheckBox();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)memorySlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)processorsSlider).BeginInit();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "WSLConfigManager";
            notifyIcon1.Visible = true;
            // 
            // memoryLabel
            // 
            memoryLabel.Location = new Point(9, 19);
            memoryLabel.Name = "memoryLabel";
            memoryLabel.Size = new Size(70, 22);
            memoryLabel.TabIndex = 0;
            memoryLabel.Text = "Memory:";
            // 
            // memorySlider
            // 
            memorySlider.Location = new Point(88, 19);
            memorySlider.Maximum = 64;
            memorySlider.Minimum = 1;
            memorySlider.Name = "memorySlider";
            memorySlider.Size = new Size(175, 45);
            memorySlider.TabIndex = 1;
            memorySlider.Value = 4;
            memorySlider.ValueChanged += new System.EventHandler(memorySlider_ValueChanged);

            // 
            // memoryValue
            // 
            memoryValue.Location = new Point(271, 19);
            memoryValue.Name = "memoryValue";
            memoryValue.Size = new Size(70, 22);
            memoryValue.TabIndex = 2;
            memoryValue.Text = "4 GB";
            // 
            // processorsLabel
            // 
            processorsLabel.Location = new Point(9, 56);
            processorsLabel.Name = "processorsLabel";
            processorsLabel.Size = new Size(70, 22);
            processorsLabel.TabIndex = 3;
            processorsLabel.Text = "Processors:";
            // 
            // processorsSlider
            // 
            processorsSlider.Location = new Point(88, 56);
            processorsSlider.Maximum = 16;
            processorsSlider.Minimum = 1;
            processorsSlider.Name = "processorsSlider";
            processorsSlider.Size = new Size(175, 45);
            processorsSlider.TabIndex = 4;
            processorsSlider.Value = 2;
            processorsSlider.ValueChanged += new System.EventHandler(processorsSlider_ValueChanged);
            // 
            // processorsValue
            // 
            processorsValue.Location = new Point(271, 56);
            processorsValue.Name = "processorsValue";
            processorsValue.Size = new Size(70, 22);
            processorsValue.TabIndex = 5;
            processorsValue.Text = "2";
            // 
            // kernelLabel
            // 
            kernelLabel.Location = new Point(9, 94);
            kernelLabel.Name = "kernelLabel";
            kernelLabel.Size = new Size(70, 22);
            kernelLabel.TabIndex = 6;
            kernelLabel.Text = "Kernel:";
            // 
            // kernelTextbox
            // 
            kernelTextbox.Location = new Point(88, 94);
            kernelTextbox.Name = "kernelTextbox";
            kernelTextbox.Size = new Size(176, 23);
            kernelTextbox.TabIndex = 7;
            // 
            // kernelCommandLineLabel
            // 
            kernelCommandLineLabel.Location = new Point(9, 131);
            kernelCommandLineLabel.Name = "kernelCommandLineLabel";
            kernelCommandLineLabel.Size = new Size(131, 22);
            kernelCommandLineLabel.TabIndex = 8;
            kernelCommandLineLabel.Text = "Kernel Command Line:";
            // 
            // kernelCommandLineTextbox
            // 
            kernelCommandLineTextbox.Location = new Point(149, 131);
            kernelCommandLineTextbox.Name = "kernelCommandLineTextbox";
            kernelCommandLineTextbox.Size = new Size(176, 23);
            kernelCommandLineTextbox.TabIndex = 9;
            // 
            // swapLabel
            // 
            swapLabel.Location = new Point(9, 169);
            swapLabel.Name = "swapLabel";
            swapLabel.Size = new Size(70, 22);
            swapLabel.TabIndex = 10;
            swapLabel.Text = "Swap:";
            // 
            // swapTextbox
            // 
            swapTextbox.Location = new Point(88, 169);
            swapTextbox.Name = "swapTextbox";
            swapTextbox.Size = new Size(176, 23);
            swapTextbox.TabIndex = 11;
            // 
            // pageReportingCheckbox
            // 
            pageReportingCheckbox.Location = new Point(9, 206);
            pageReportingCheckbox.Name = "pageReportingCheckbox";
            pageReportingCheckbox.Size = new Size(131, 22);
            pageReportingCheckbox.TabIndex = 12;
            pageReportingCheckbox.Text = "Page Reporting";
            // 
            // localhostForwardingCheckbox
            // 
            localhostForwardingCheckbox.Location = new Point(9, 244);
            localhostForwardingCheckbox.Name = "localhostForwardingCheckbox";
            localhostForwardingCheckbox.Size = new Size(149, 22);
            localhostForwardingCheckbox.TabIndex = 13;
            localhostForwardingCheckbox.Text = "Localhost Forwarding";
            // 
            // nestedVirtualizationCheckbox
            // 
            nestedVirtualizationCheckbox.Location = new Point(9, 281);
            nestedVirtualizationCheckbox.Name = "nestedVirtualizationCheckbox";
            nestedVirtualizationCheckbox.Size = new Size(149, 22);
            nestedVirtualizationCheckbox.TabIndex = 14;
            nestedVirtualizationCheckbox.Text = "Nested Virtualization";
            // 
            // debugConsoleCheckbox
            // 
            debugConsoleCheckbox.Location = new Point(9, 319);
            debugConsoleCheckbox.Name = "debugConsoleCheckbox";
            debugConsoleCheckbox.Size = new Size(131, 22);
            debugConsoleCheckbox.TabIndex = 15;
            debugConsoleCheckbox.Text = "Debug Console";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(241, 333);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 30);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 375);
            Controls.Add(saveButton);
            Controls.Add(debugConsoleCheckbox);
            Controls.Add(nestedVirtualizationCheckbox);
            Controls.Add(localhostForwardingCheckbox);
            Controls.Add(pageReportingCheckbox);
            Controls.Add(swapTextbox);
            Controls.Add(swapLabel);
            Controls.Add(kernelCommandLineTextbox);
            Controls.Add(kernelCommandLineLabel);
            Controls.Add(kernelTextbox);
            Controls.Add(kernelLabel);
            Controls.Add(processorsValue);
            Controls.Add(processorsSlider);
            Controls.Add(processorsLabel);
            Controls.Add(memoryValue);
            Controls.Add(memorySlider);
            Controls.Add(memoryLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WSL Config Editor";
            ((System.ComponentModel.ISupportInitialize)memorySlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)processorsSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private NotifyIcon notifyIcon1;
        private Label memoryLabel;
        private TrackBar memorySlider;
        private Label memoryValue;
        private Label processorsLabel;
        private TrackBar processorsSlider;
        private Label processorsValue;
        private Label kernelLabel;
        private TextBox kernelTextbox;
        private Label kernelCommandLineLabel;
        private TextBox kernelCommandLineTextbox;
        private Label swapLabel;
        private TextBox swapTextbox;
        private CheckBox pageReportingCheckbox;
        private CheckBox localhostForwardingCheckbox;
        private CheckBox nestedVirtualizationCheckbox;
        private CheckBox debugConsoleCheckbox;
        private Button saveButton;
    }
}
