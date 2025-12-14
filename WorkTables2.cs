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
using KR.FolderModel;

namespace KR
{
    public partial class WorkTables2 : Form
    {
        public WorkTables2()
        {
            InitializeComponent();
        }

        public static Model1 DB = new Model1();

        private void WorkTables2_Load(object sender, EventArgs e)
        {
            workersBindingSource.DataSource = DB.Workers.ToList();
        }
        private void UpdateTable()
        {
            workersBindingSource.DataSource = DB.Workers.ToList();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Visible = true;
            this.Close();
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
                UpdateTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (iDTextBox.Text == "" || loginTextBox.Text == "" || passwordTextBox.Text == "" || first_NameTextBox.Text == "" || second_NameTextBox.Text == "")
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
            else
            {
                
                Workers workers = new Workers();
                workers.ID = Convert.ToInt32(iDTextBox.Text);
                workers.Login = loginTextBox.Text;
                workers.Password = passwordTextBox.Text;
                workers.First_Name = first_NameTextBox.Text;
                workers.Second_Name = second_NameTextBox.Text;
                workers.Middle_Name = middle_NameTextBox.Text;
                workers.Role = roleTextBox.Text;
                workers.Phone = phoneTextBox.Text;
                workers.Gender = genderTextBox.Text;

                WorkTables2.DB.Workers.Add(workers);
                WorkTables2.DB.SaveChanges();
                UpdateTable();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Workers workers = DB.Workers.Find((int)dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить пользователя {workers.Second_Name}?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {

                    DB.Workers.Remove(workers);
                    WorkTables2.DB.SaveChanges();
                    UpdateTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
