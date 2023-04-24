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
            saveButton = new Button();
            saveAndRestartButton = new Button();
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
            memorySlider.ValueChanged += memorySlider_ValueChanged;
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
            processorsSlider.ValueChanged += processorsSlider_ValueChanged;
            // 
            // processorsValue
            // 
            processorsValue.Location = new Point(271, 56);
            processorsValue.Name = "processorsValue";
            processorsValue.Size = new Size(70, 22);
            processorsValue.TabIndex = 5;
            processorsValue.Text = "2";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(9, 102);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(332, 30);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // saveAndRestartButton
            // 
            saveAndRestartButton.Location = new Point(9, 138);
            saveAndRestartButton.Name = "saveAndRestartButton";
            saveAndRestartButton.Size = new Size(332, 30);
            saveAndRestartButton.TabIndex = 17;
            saveAndRestartButton.Text = "Save and Restart WSL";
            saveAndRestartButton.UseVisualStyleBackColor = true;
            saveAndRestartButton.Click += saveAndRestartButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 180);
            Controls.Add(saveAndRestartButton);
            Controls.Add(saveButton);
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
        private Button saveButton;
        private Button saveAndRestartButton;
    }

}
