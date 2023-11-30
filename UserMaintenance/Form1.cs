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
            labelfirstname.Text = Resource1.FirstName;
            labelLastName.Text = Resource1.LastName;
            buttonAdd.Text = Resource1.Add;

            listBox.DataSource = users;
            listBox.ValueMember = "ID";
            listBox.DisplayMember = "FullName";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.LastName = textBoxLastName.Text;
            u.FirstName = textBoxfirstname.Text;
            users.Add(u);
            textBoxfirstname.Clear();
            textBoxLastName.Clear();
        
        
        }
    }
}
