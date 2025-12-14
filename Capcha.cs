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
    public partial class Capcha : Form
    {
        public Capcha()
        {
            InitializeComponent();
        }
        public bool BlockSotr = false;
        public bool Great = false;
        string CapchaText;
        int remaining = 3;
        private void CreateCapcha()
        {
            string combination = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ1234567890" + "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Random random = new Random();
            CapchaText = "";
            for (int i = 0; i < 5; i++)
            {
                CapchaText += combination[random.Next(combination.Length)];
            }
            labelCapcha.Text = CapchaText;
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Capcha_Load(object sender, EventArgs e)
        {
            CreateCapcha();
        }

        private void buttonCapcha_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == CapchaText)
            {

                Great = true;
                Close();
            }
            else
            {
                remaining--;
                if (remaining > 0)
                {
                    MessageBox.Show($"Попыток осталось: {remaining}");
                    CreateCapcha();
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Попытки кончились. Пользователь заблокирован");
                    BlockSotr = true;
                    Close();
                }
            }
        }
    }
}
