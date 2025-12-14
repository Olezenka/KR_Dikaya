using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KR.FolderModel;

namespace KR
{
    public partial class FormAutorizacia : Form
    {
        public FormAutorizacia()
        {
            InitializeComponent();
        }
        public static Model1 DB = new Model1();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEntr_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            Workers sotrs = model.Workers.ToList().SingleOrDefault(x =>
            x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (sotrs != null)
            {
                Capcha capcha = new Capcha();
                capcha.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Логин или пароль указаны неверно");
                Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
