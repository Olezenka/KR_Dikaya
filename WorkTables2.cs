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
    }
}
