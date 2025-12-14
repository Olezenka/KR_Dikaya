using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR
{
    public partial class MenedgersMenu : Form
    {
        public MenedgersMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenedgersMenu_Load(object sender, EventArgs e)
        {
            label2.Text = FormAutorizacia.sotrName;
            label3.Text = FormAutorizacia.sotrRole;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAutorizacia formAutorizacia = new FormAutorizacia();
            formAutorizacia.Visible = true;
            this.Close();
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            TC tc = new TC();
            tc.Visible = true;
            this.Close();
        }
    }
}
