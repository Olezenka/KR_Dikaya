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
    public partial class TenantsTable : Form
    {
        public TenantsTable()
        {
            InitializeComponent();
        }

        public static Model1 DB = new Model1();
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Visible = true;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddArendator addArendator = new AddArendator();
            addArendator.ShowDialog();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadTable ()
        {
            tenantsBindingSource.DataSource = DB.Tenants.ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TenantsTable_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Tenants tenants = DB.Tenants.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            DB.Tenants.Remove(tenants);
            DB.SaveChanges();
            LoadTable();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {
            try
            {
                Validate();
                DB.SaveChanges();
                LoadTable ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
