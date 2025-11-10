namespace BTL_WindowsForm
{
    partial class Form1
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
            this.lblLogin = new Sunny.UI.UILabel();
            this.lblPassword = new Sunny.UI.UILabel();
            this.pnlCha.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCha
            // 
            this.pnlCha.BackColor = System.Drawing.Color.White;
            this.pnlCha.Controls.Add(this.pnlLogo);
            this.pnlCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlCha.Location = new System.Drawing.Point(87, 57);
            this.pnlCha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCha.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlCha.Name = "pnlCha";
            this.pnlCha.Size = new System.Drawing.Size(1084, 549);
            this.pnlCha.TabIndex = 0;
            this.pnlCha.Text = null;
            this.pnlCha.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlCha.Click += new System.EventHandler(this.pnlCha_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlLogin.Location = new System.Drawing.Point(609, 57);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(539, 539);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlLogin.Click += new System.EventHandler(this.pnlLogin_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::BTL_WindowsForm.Properties.Resources.f628eaf7_c142_4f8b_af62_95510564012f1;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlLogo.Location = new System.Drawing.Point(4, 5);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogo.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(229, 373);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Text = null;
            this.pnlLogo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlLogo.Click += new System.EventHandler(this.pnlLogo_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLogin.Location = new System.Drawing.Point(12, 46);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(120, 49);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Tài khoản: ";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblPassword.Location = new System.Drawing.Point(12, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(120, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Mật khẩu: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_WindowsForm.Properties.Resources._1c98ed2d_448b_4997_8f7e_571bfbb62bde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlCha);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCha.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlCha;
        private Sunny.UI.UIPanel pnlLogo;
        private Sunny.UI.UIPanel pnlLogin;
        private Sunny.UI.UILabel lblPassword;
        private Sunny.UI.UILabel lblLogin;
    }
}

