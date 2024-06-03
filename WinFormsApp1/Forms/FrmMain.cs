using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    public partial class Frmmain : Form
    {
        public Frmmain()
        {
            InitializeComponent();
        }

        private void Frmmain_Load(object sender, EventArgs e)
        {

        }
        void OpenForm(Form f)
        {
            panel3.Controls.Clear();
            f.TopLevel = false;
            panel3.Controls.Add(f);
            f.Show();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmStudent());
        }

        private void btnLesson_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmLesson());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmRegister());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
