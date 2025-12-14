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
    public partial class AddArendator : Form
    {
        public AddArendator()
        {
            InitializeComponent();
        }

        public static Model1 DB = new Model1();
        private void AddArendator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //iDTextBox.Text == ""
            if (adressTextBox.Text == "" || phoneTextBox.Text == "" || nameTextBox.Text == "")
            {
                MessageBox.Show("Для добавления арендатора необходимо заполнить все данные");
            }
            else
            {
                try
                {
                    Tenants tenants = new Tenants();
                    tenants.Adress = adressTextBox.Text;
                    tenants.Phone = phoneTextBox.Text;
                    tenants.Name = nameTextBox.Text;
                    //tenants.ID = Convert.ToInt32(iDTextBox.Text);

                    AddArendator.DB.Tenants.Add(tenants);
                    AddArendator.DB.SaveChanges();
                    TenantsTable tenantsTable = new TenantsTable();
                    tenantsTable.Visible = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
