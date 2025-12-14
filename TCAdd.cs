using KR.FolderModel;
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
    public partial class TCAdd : Form
    {
        public TCAdd()
        {
            InitializeComponent();
        }
        public static Model1 DB = new Model1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (amount_PTextBox.Text == "" || nameTextBox.Text == "")
            {
                MessageBox.Show("Все данные должны быть заполнены");
            }
            else
            {
                try
                {
                    Mall mall = new Mall();
                    mall.ID = DB.Mall.ToList().Count + 1;
                    mall.Name = nameTextBox.Text;
                    mall.Amount_P = Convert.ToInt32(amount_PTextBox.Text);
                    mall.Cost = Convert.ToInt32(costTextBox.Text);
                    mall.Status = statusTextBox.Text;
                    mall.Coeff_cost = Convert.ToSingle(coeff_costTextBox.Text);
                    mall.Town = townTextBox.Text;
                    mall.Floor = Convert.ToInt32(floorTextBox.Text);

                    DB.Mall.Add(mall);
                    DB.SaveChanges();
                    TC tC = new TC();
                    tC.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void TCAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
