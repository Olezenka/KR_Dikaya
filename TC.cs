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
    public partial class TC : Form
    {
        public TC()
        {
            InitializeComponent();
        }
        public static Model1 DB = new Model1();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TC_Load(object sender, EventArgs e)
        {
            LoadTables();
        }
        private void LoadTables()
        {
            mallBindingSource.DataSource = DB.Mall.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenedgersMenu menedgersMenu = new MenedgersMenu();
            menedgersMenu.ShowDialog();
            this.Close();
        }

    }
}
