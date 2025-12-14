using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public static string sotrName;
        private void buttonEntr_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            Workers sotrs = model.Workers.ToList().SingleOrDefault(x =>
            x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            sotrName = sotrs.Second_Name;
            if (sotrs != null)
            {
                if (sotrs.Role == "Заблокирован")
                {
                    MessageBox.Show("Пользователь заблокирован. Обратитесь к администратору для разблокировки");
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else if (sotrs.Role == "Удален")
                {
                    MessageBox.Show("Пользователь был удален.");
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else if (sotrs.Role == "Администратор")
                {
                    MenuAdmin menu = new MenuAdmin();
                    menu.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    Capcha capcha = new Capcha();
                    capcha.ShowDialog();
                    if (capcha.BlockSotr)
                    {
                        sotrs.Role = "Заблокирован";
                        model.SaveChanges();
                        Close();
                    }
                    else
                    {
                        else if (sotrs.Role.Contains("Менеджер")) 
                        {
                            MessageBox.Show("Здесь будет меню менеджера");
                        }
                        else
                        {
                            MessageBox.Show("Для этой роли не предусмотрен рабочий стол");
                        }
                    }
                }    
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
