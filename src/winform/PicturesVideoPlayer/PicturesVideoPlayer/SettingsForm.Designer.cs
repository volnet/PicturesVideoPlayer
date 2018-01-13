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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFPS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSourceFramePath = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.comboBoxSizeMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textBoxSourceFileSystemWatcherFilter = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "FPS(frames per second):";
            // 
            // tbFPS
            // 
            this.tbFPS.Location = new System.Drawing.Point(319, 56);
            this.tbFPS.Name = "tbFPS";
            this.tbFPS.Size = new System.Drawing.Size(134, 35);
            this.tbFPS.TabIndex = 3;
            this.tbFPS.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "( < 60 )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Source Frame Path:";
            // 
            // textBoxSourceFramePath
            // 
            this.textBoxSourceFramePath.Location = new System.Drawing.Point(321, 55);
            this.textBoxSourceFramePath.Name = "textBoxSourceFramePath";
            this.textBoxSourceFramePath.Size = new System.Drawing.Size(726, 35);
            this.textBoxSourceFramePath.TabIndex = 6;
            this.textBoxSourceFramePath.Text = "Video\\frame.jpg";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.label2);
            this.groupBoxOutput.Controls.Add(this.comboBoxSizeMode);
            this.groupBoxOutput.Controls.Add(this.tbFPS);
            this.groupBoxOutput.Controls.Add(this.label6);
            this.groupBoxOutput.Controls.Add(this.label1);
            this.groupBoxOutput.Location = new System.Drawing.Point(24, 290);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(1084, 194);
            this.groupBoxOutput.TabIndex = 8;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Size Mode:";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.labelFilter);
            this.groupBoxInput.Controls.Add(this.textBoxSourceFileSystemWatcherFilter);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.textBoxSourceFramePath);
            this.groupBoxInput.Location = new System.Drawing.Point(24, 70);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(1084, 194);
            this.groupBoxInput.TabIndex = 9;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(29, 125);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(94, 24);
            this.labelFilter.TabIndex = 7;
            this.labelFilter.Text = "Filter:";
            // 
            // textBoxSourceFileSystemWatcherFilter
            // 
            this.textBoxSourceFileSystemWatcherFilter.Location = new System.Drawing.Point(321, 122);
            this.textBoxSourceFileSystemWatcherFilter.Name = "textBoxSourceFileSystemWatcherFilter";
            this.textBoxSourceFileSystemWatcherFilter.Size = new System.Drawing.Size(228, 35);
            this.textBoxSourceFileSystemWatcherFilter.TabIndex = 8;
            this.textBoxSourceFileSystemWatcherFilter.Text = "*.jpg";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "Replace",
            "AddNew(alpha)",
            "HTTPGet"});
            this.comboBoxMode.Location = new System.Drawing.Point(123, 14);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(302, 32);
            this.comboBoxMode.TabIndex = 9;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mode:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 649);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSourceFramePath;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxSizeMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textBoxSourceFileSystemWatcherFilter;
    }
}