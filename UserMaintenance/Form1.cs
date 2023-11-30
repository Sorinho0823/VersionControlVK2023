using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            labelFullName.Text = Resource1.Fullname;
            buttonAdd.Text = Resource1.Add;

            listBox.DataSource = users;
            listBox.ValueMember = "ID";
            listBox.DisplayMember = "FullName";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.FullName = textBoxFullName.Text;
            users.Add(u);
            textBoxFullName.Clear();
        
        
        }
    }
}
