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
        private void UpdateLocation()
        {
            this.SuspendLayout();
            pnlLogo.Size = new Size(pnlCha.Width / 2, pnlCha.Height);
            pnlLogo.Location = new Point(0, 0);
            pnlLogin.Size = new Size(pnlCha.Width / 2, pnlCha.Height);
            pnlLogin.Location = new Point(pnlCha.Width / 2, 0);
            pnlCha.Location = new Point((this.ClientSize.Width - pnlCha.Width) / 2, (this.ClientSize.Height - pnlCha.Height) / 2);
            this.ResumeLayout();
        }
        private void pnlLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            UpdateLocation();
        }
    }
}
