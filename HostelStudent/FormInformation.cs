using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelStudent
{
    public partial class FormInformation : Form
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();
        public FormInformation()
        {
            InitializeComponent();
        }

        private void buttonGetDepartments_Click(object sender, EventArgs e)
        {
            dataGridViewInformation.DataSource = null;
            dataGridViewInformation.DataSource = db.up_sel_getDepartments();
        }

        private void buttonGetInfoGroup_Click(object sender, EventArgs e)
        {
            dataGridViewInformation.DataSource = null;
            dataGridViewInformation.DataSource = db.up_sel_getInfoGroup();
        }

        private void buttonGetInfoRooms_Click(object sender, EventArgs e)
        {
            dataGridViewInformation.DataSource = null;
            dataGridViewInformation.DataSource = db.up_sel_getInfoRooms();
        }

        private void buttonGetInfoTypeRooms_Click(object sender, EventArgs e)
        {
            dataGridViewInformation.DataSource = null;
            dataGridViewInformation.DataSource = db.up_sel_getTypeRooms();
        }

        private void buttonGetInfoUsers_Click(object sender, EventArgs e)
        {
            dataGridViewInformation.DataSource = null;
            dataGridViewInformation.DataSource = db.up_sel_getUsers();
        }
    }
}
