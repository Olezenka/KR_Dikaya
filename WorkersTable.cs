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

namespace KR.FolderModel
{
    public partial class WorkersTable : Form
    {

        public static Model1 DB = new Model1();
        public WorkersTable()
        {
            InitializeComponent();
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkersTable_Load(object sender, EventArgs e)
        {
            workersBindingSource.DataSource = DB.Workers.ToList();
        }
    }
}
