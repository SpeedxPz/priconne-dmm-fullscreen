namespace Hwnd
{
    partial class PrinconneFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrinconneFrm));
            this.fullscreenBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.linkBtn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // fullscreenBtn
            // 
            this.fullscreenBtn.Location = new System.Drawing.Point(10, 12);
            this.fullscreenBtn.Name = "fullscreenBtn";
            this.fullscreenBtn.Size = new System.Drawing.Size(163, 35);
            this.fullscreenBtn.TabIndex = 0;
            this.fullscreenBtn.Text = "Go FullScreen";
            this.fullscreenBtn.UseVisualStyleBackColor = true;
            this.fullscreenBtn.Click += new System.EventHandler(this.fullscreenBtn_Click);
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(179, 12);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(163, 35);
            this.restoreBtn.TabIndex = 1;
            this.restoreBtn.Text = "Restore Window";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // linkBtn
            // 
            this.linkBtn.AutoSize = true;
            this.linkBtn.Location = new System.Drawing.Point(10, 61);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(341, 13);
            this.linkBtn.TabIndex = 2;
            this.linkBtn.TabStop = true;
            this.linkBtn.Text = "Princess Connect Re:Dive (DMM) Full Screen tool by Takumi Producer";
            this.linkBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBtn_LinkClicked);
            // 
            // PrinconneFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 83);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.fullscreenBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrinconneFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Priconne (DMM) Fullscreen v1.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fullscreenBtn;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.LinkLabel linkBtn;
    }
}

