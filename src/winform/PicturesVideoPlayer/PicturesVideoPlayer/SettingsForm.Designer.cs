namespace PicturesVideoPlayer
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.cbShowInNextTime = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFPS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSourceFolderPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxInputSourceType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxSizeMode = new System.Windows.Forms.ComboBox();
            this.textBoxISTUpdateOneFrameName = new System.Windows.Forms.TextBox();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbShowInNextTime
            // 
            this.cbShowInNextTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbShowInNextTime.AutoSize = true;
            this.cbShowInNextTime.Location = new System.Drawing.Point(57, 569);
            this.cbShowInNextTime.Name = "cbShowInNextTime";
            this.cbShowInNextTime.Size = new System.Drawing.Size(246, 28);
            this.cbShowInNextTime.TabIndex = 0;
            this.cbShowInNextTime.Text = "Show in next time";
            this.cbShowInNextTime.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(928, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "FPS(frames per second):";
            // 
            // tbFPS
            // 
            this.tbFPS.Location = new System.Drawing.Point(345, 72);
            this.tbFPS.Name = "tbFPS";
            this.tbFPS.Size = new System.Drawing.Size(134, 35);
            this.tbFPS.TabIndex = 3;
            this.tbFPS.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "( < 60 )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Source Folder Path:";
            // 
            // textBoxSourceFolderPath
            // 
            this.textBoxSourceFolderPath.Location = new System.Drawing.Point(321, 134);
            this.textBoxSourceFolderPath.Name = "textBoxSourceFolderPath";
            this.textBoxSourceFolderPath.Size = new System.Drawing.Size(726, 35);
            this.textBoxSourceFolderPath.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Frame Name:";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.comboBoxSizeMode);
            this.groupBoxOutput.Controls.Add(this.label6);
            this.groupBoxOutput.Location = new System.Drawing.Point(24, 22);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(1084, 194);
            this.groupBoxOutput.TabIndex = 8;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxISTUpdateOneFrameName);
            this.groupBoxInput.Controls.Add(this.comboBoxInputSourceType);
            this.groupBoxInput.Controls.Add(this.label5);
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.textBoxSourceFolderPath);
            this.groupBoxInput.Location = new System.Drawing.Point(24, 240);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(1084, 278);
            this.groupBoxInput.TabIndex = 9;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Input Source Type:";
            // 
            // comboBoxInputSourceType
            // 
            this.comboBoxInputSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInputSourceType.FormattingEnabled = true;
            this.comboBoxInputSourceType.Items.AddRange(new object[] {
            "Replace",
            "AddNew"});
            this.comboBoxInputSourceType.Location = new System.Drawing.Point(321, 64);
            this.comboBoxInputSourceType.Name = "comboBoxInputSourceType";
            this.comboBoxInputSourceType.Size = new System.Drawing.Size(260, 32);
            this.comboBoxInputSourceType.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Size Mode:";
            // 
            // comboBoxSizeMode
            // 
            this.comboBoxSizeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSizeMode.FormattingEnabled = true;
            this.comboBoxSizeMode.Items.AddRange(new object[] {
            "Zoom",
            "Stretch"});
            this.comboBoxSizeMode.Location = new System.Drawing.Point(321, 119);
            this.comboBoxSizeMode.Name = "comboBoxSizeMode";
            this.comboBoxSizeMode.Size = new System.Drawing.Size(260, 32);
            this.comboBoxSizeMode.TabIndex = 10;
            // 
            // textBoxISTUpdateOneFrameName
            // 
            this.textBoxISTUpdateOneFrameName.Location = new System.Drawing.Point(321, 202);
            this.textBoxISTUpdateOneFrameName.Name = "textBoxISTUpdateOneFrameName";
            this.textBoxISTUpdateOneFrameName.Size = new System.Drawing.Size(260, 35);
            this.textBoxISTUpdateOneFrameName.TabIndex = 10;
            this.textBoxISTUpdateOneFrameName.Text = "frame.jpg";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbShowInNextTime);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbShowInNextTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSourceFolderPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxSizeMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxISTUpdateOneFrameName;
        private System.Windows.Forms.ComboBox comboBoxInputSourceType;
        private System.Windows.Forms.Label label5;
    }
}