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
            this.txtPassWord = new Sunny.UI.UITextBox();
            this.txtLogin = new Sunny.UI.UITextBox();
            this.btnLogin = new Sunny.UI.UIButton();
            this.btnOut = new Sunny.UI.UIButton();
            this.pnlLogo = new Sunny.UI.UIPanel();
            this.lblLogin = new Sunny.UI.UILabel();
            this.pnlCha.SuspendLayout();
            this.pnlLogin.SuspendLayout();
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
            this.pnlCha.Size = new System.Drawing.Size(1280, 620);
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
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.txtPassWord);
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.btnOut);
            this.pnlLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlLogin.Location = new System.Drawing.Point(540, 0);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Radius = 1;
            this.pnlLogin.Size = new System.Drawing.Size(740, 620);
            this.pnlLogin.TabIndex = 1;
            this.pnlLogin.Text = null;
            this.pnlLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlLogin.Click += new System.EventHandler(this.pnlLogin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Icon = global::BTL_WindowsForm.Properties.Resources.password_icon_symbol_design_illustration_vector;
            this.txtPassWord.Location = new System.Drawing.Point(181, 289);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassWord.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Padding = new System.Windows.Forms.Padding(5);
            this.txtPassWord.Radius = 15;
            this.txtPassWord.ShowText = false;
            this.txtPassWord.Size = new System.Drawing.Size(245, 41);
            this.txtPassWord.TabIndex = 5;
            this.txtPassWord.Text = "Nhập mật khẩu";
            this.txtPassWord.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPassWord.Watermark = "";
            this.txtPassWord.TextChanged += new System.EventHandler(this.txtPassWord_TextChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Icon = global::BTL_WindowsForm.Properties.Resources.images;
            this.txtLogin.Location = new System.Drawing.Point(181, 181);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogin.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Padding = new System.Windows.Forms.Padding(5);
            this.txtLogin.Radius = 15;
            this.txtLogin.ShowText = false;
            this.txtLogin.Size = new System.Drawing.Size(245, 39);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "Tên đăng nhập";
            this.txtLogin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLogin.Watermark = "";
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(206, 418);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 15;
            this.btnLogin.Size = new System.Drawing.Size(136, 52);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnOut
            // 
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Location = new System.Drawing.Point(309, 350);
            this.btnOut.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOut.Name = "btnOut";
            this.btnOut.Radius = 15;
            this.btnOut.Size = new System.Drawing.Size(117, 52);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "Thoát";
            this.btnOut.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
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
            this.pnlLogo.Size = new System.Drawing.Size(740, 620);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Text = null;
            this.pnlLogo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlLogo.Click += new System.EventHandler(this.pnlLogo_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLogin.Location = new System.Drawing.Point(175, 61);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(257, 61);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Đăng nhập";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL_WindowsForm.Properties.Resources._1c98ed2d_448b_4997_8f7e_571bfbb62bde;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pnlCha);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlCha.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel pnlCha;
        private Sunny.UI.UIPanel pnlLogo;
        private Sunny.UI.UIPanel pnlLogin;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UIButton btnOut;
        private Sunny.UI.UITextBox txtPassWord;
        private Sunny.UI.UITextBox txtLogin;
        private Sunny.UI.UILabel lblLogin;
    }
}

