namespace PicturesVideoPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxFrameView = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayOrPause = new System.Windows.Forms.PictureBox();
            this.timerForShowingBtnPause = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrameView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayOrPause)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBoxFrameView.BackColor = System.Drawing.Color.Black;
            this.pictureBoxFrameView.ContextMenuStrip = this.contextMenuStrip;
            this.pictureBoxFrameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFrameView.ErrorImage = null;
            this.pictureBoxFrameView.InitialImage = null;
            this.pictureBoxFrameView.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxFrameView.Name = "pictureBox1";
            this.pictureBoxFrameView.Size = new System.Drawing.Size(1364, 883);
            this.pictureBoxFrameView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrameView.TabIndex = 0;
            this.pictureBoxFrameView.TabStop = false;
            this.pictureBoxFrameView.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPlayOrPause
            // 
            this.btnPlayOrPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayOrPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayOrPause.Location = new System.Drawing.Point(1105, 592);
            this.btnPlayOrPause.Name = "btnPlayOrPause";
            this.btnPlayOrPause.Size = new System.Drawing.Size(150, 150);
            this.btnPlayOrPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPlayOrPause.TabIndex = 1;
            this.btnPlayOrPause.TabStop = false;
            this.btnPlayOrPause.Click += new System.EventHandler(this.btnPlayOrPause_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(245, 84);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 883);
            this.Controls.Add(this.btnPlayOrPause);
            this.Controls.Add(this.pictureBoxFrameView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "PicturesVideoPlayer (Show JPEG file as MPEG)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrameView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlayOrPause)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFrameView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnPlayOrPause;
        private System.Windows.Forms.Timer timerForShowingBtnPause;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

