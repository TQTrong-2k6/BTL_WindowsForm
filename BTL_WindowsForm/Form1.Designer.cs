namespace BTL_WindowsForm
{
    partial class Login
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
            this.pnlCha = new Sunny.UI.UIPanel();
            this.pnlLogin = new Sunny.UI.UIPanel();
            this.pnlLogo = new Sunny.UI.UIPanel();
            this.pnlCha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCha
            // 
            this.pnlCha.BackColor = System.Drawing.Color.White;
            this.pnlCha.Controls.Add(this.pnlLogin);
            this.pnlCha.Controls.Add(this.pnlLogo);
            this.pnlCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCha.Location = new System.Drawing.Point(90, 68);
            this.pnlCha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCha.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCha.Name = "pnlCha";
            this.pnlCha.Size = new System.Drawing.Size(1080, 520);
            this.pnlCha.TabIndex = 0;
            this.pnlCha.Text = null;
            this.pnlCha.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlCha.Click += new System.EventHandler(this.pnlCha_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlLogin.Location = new System.Drawing.Point(540, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Radius = 1;
            this.pnlLogin.Size = new System.Drawing.Size(540, 520);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.Text = "Login";
            this.pnlLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlLogin.Click += new System.EventHandler(this.pnlLogin_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogo.BackgroundImage = global::BTL_WindowsForm.Properties.Resources.f628eaf7_c142_4f8b_af62_95510564012f1;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogo.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(540, 520);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Text = null;
            this.pnlLogo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlLogo.Click += new System.EventHandler(this.pnlLogo_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_WindowsForm.Properties.Resources._1c98ed2d_448b_4997_8f7e_571bfbb62bde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnlCha);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlCha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlCha;
        private Sunny.UI.UIPanel pnlLogo;
        private Sunny.UI.UIPanel pnlLogin;
    }
}

