using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_WindowsForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void pnlLogo_Click(object sender, EventArgs e)
        {

        }
        private void pnlCha_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLocation()// làm mới size và location của panel, textbox, button, label
        {
            this.SuspendLayout();

            pnlLogo.Size = new Size(pnlCha.Width / 2, pnlCha.Height);//sửa size của panel logo
            pnlLogo.Location = new Point(0, 0);//sửa location của panel logo

            pnlLogin.Size = new Size(pnlCha.Width / 2, pnlCha.Height);//sửa size của panel login
            pnlLogin.Location = new Point(pnlCha.Width / 2, 0);//sửa location của panel login

            // đặt vị trí của panel cha ở giữa giao diện
            pnlCha.Location = new Point((this.ClientSize.Width - pnlCha.Width) / 2, (this.ClientSize.Height - pnlCha.Height) / 2);

            int widthPnlLogin = pnlLogin.Width;// lấy chiều rộng của panel login
            int heightPnlLogin = pnlLogin.Height;// lấy chiều cao của panel login

            int widthTXT = txtLogin.Width + 100;// tính chiều rộng của textbox login và password

            txtLogin.Size = new Size(widthTXT, txtLogin.Height);
            txtLogin.Location = new Point((pnlLogin.Width - txtLogin.Width) / 2, pnlLogin.Height / 4);

            txtPassWord.Size = new Size(widthTXT, txtPassWord.Height);
            txtPassWord.Location = new Point((pnlLogin.Width - txtPassWord.Width) / 2, txtLogin.Location.Y + txtLogin.Height + 20);
            this.ResumeLayout();
        }
        private void pnlLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            UpdateLocation();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
