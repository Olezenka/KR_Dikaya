using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR.FolderModel
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            label2.Text = "Доброе пожаловать!\n" + FormAutorizacia.sotrName;
            label3.Text = FormAutorizacia.sotrRole;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAutorizacia form = new FormAutorizacia();
            form.Visible = true;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
