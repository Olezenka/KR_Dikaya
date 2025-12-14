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
        public static string sotrRole;
        private void buttonEntr_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            Workers sotrs = model.Workers.ToList().SingleOrDefault(x =>
            x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (sotrs != null)
            {
                sotrName = sotrs.First_Name + " " + sotrs.Second_Name + " " + sotrs.Middle_Name;
                sotrRole = sotrs.Role;
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
                    else if (capcha.Great)
                    {
                        if (sotrs.Role.Contains("Менеджер"))
                        {
                            MenedgersMenu menedgersMenu = new MenedgersMenu();
                            menedgersMenu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Для этой роли не предусмотрен рабочий стол");
                        }
                    }
                    else
                    {

                    }
                }    
            }
            else
            {
                MessageBox.Show("Логин или пароль указаны неверно");
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
