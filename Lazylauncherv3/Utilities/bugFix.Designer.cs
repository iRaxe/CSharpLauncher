
namespace svchost
{
    partial class bugFix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bugFix));
            this.panel2 = new System.Windows.Forms.Panel();
            this.minimizeWindow = new System.Windows.Forms.PictureBox();
            this.closeWindow = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.liveChat = new System.Windows.Forms.PictureBox();
            this.keyButton = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.minimizeWindow);
            this.panel2.Controls.Add(this.closeWindow);
            this.panel2.Location = new System.Drawing.Point(728, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 32);
            this.panel2.TabIndex = 1;
            // 
            // minimizeWindow
            // 
            this.minimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.minimizeWindow.Image = global::svchost.Properties.Resources.bx_minus_svg;
            this.minimizeWindow.Location = new System.Drawing.Point(4, 8);
            this.minimizeWindow.Name = "minimizeWindow";
            this.minimizeWindow.Size = new System.Drawing.Size(25, 24);
            this.minimizeWindow.TabIndex = 2;
            this.minimizeWindow.TabStop = false;
            this.minimizeWindow.Click += new System.EventHandler(this.minimizeWindow_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.Color.Transparent;
            this.closeWindow.Image = global::svchost.Properties.Resources.bx_x_svg;
            this.closeWindow.Location = new System.Drawing.Point(34, 5);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(25, 24);
            this.closeWindow.TabIndex = 1;
            this.closeWindow.TabStop = false;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.liveChat);
            this.panel3.Controls.Add(this.keyButton);
            this.panel3.Location = new System.Drawing.Point(38, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 246);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::svchost.Properties.Resources.Group_4212;
            this.pictureBox3.Location = new System.Drawing.Point(24, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(318, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // liveChat
            // 
            this.liveChat.BackColor = System.Drawing.Color.Transparent;
            this.liveChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.liveChat.Image = global::svchost.Properties.Resources.Group_155;
            this.liveChat.Location = new System.Drawing.Point(186, 109);
            this.liveChat.Name = "liveChat";
            this.liveChat.Size = new System.Drawing.Size(156, 120);
            this.liveChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.liveChat.TabIndex = 5;
            this.liveChat.TabStop = false;
            this.liveChat.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // keyButton
            // 
            this.keyButton.BackColor = System.Drawing.Color.Transparent;
            this.keyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.keyButton.Image = global::svchost.Properties.Resources.Group_15;
            this.keyButton.Location = new System.Drawing.Point(24, 109);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(156, 120);
            this.keyButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.keyButton.TabIndex = 4;
            this.keyButton.TabStop = false;
            this.keyButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bugFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::svchost.Properties.Resources.Group_101;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bugFix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminRights";
            this.Load += new System.EventHandler(this.bugFix_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bugFix_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bugFix_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bugFix_MouseUp);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox minimizeWindow;
        private System.Windows.Forms.PictureBox closeWindow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox keyButton;
        private System.Windows.Forms.PictureBox liveChat;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}