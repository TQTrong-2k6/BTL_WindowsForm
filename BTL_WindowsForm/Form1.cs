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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           UpdateLocation();
        }

        private void pnlLogo_Click(object sender, EventArgs e)
        {

        }

        private void pnlCha_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLocation()
        {
            pnlLogo.Size = new Size(pnlCha.Width / 2, pnlCha.Height);
            pnlLogo.Location = new Point(0, 0);
            pnlLogin.Size = new Size(pnlCha.Width / 2, pnlCha.Height);
            pnlLogin.Location = new Point(pnlCha.Width / 2, 0);
        }

        private void pnlLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
