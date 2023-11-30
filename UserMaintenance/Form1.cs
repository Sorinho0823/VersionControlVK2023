using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            buttonfile.Text = Resource1.File;
            buttonDel.Text = Resource1.Delete;

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

        private void buttonfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var path = sfd.FileName;
                StreamWriter sw = new StreamWriter(path); // using()

                // for ciklussal a user.countig

                foreach (User item in users)
                {
                    sw.WriteLine(item.ID + "," + item.FullName);
                }

                sw.Close();     // ha van using akkor ez nem kell

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            User kivalasztott = (User)listBox.SelectedItem;
            users.Remove(kivalasztott);

        }
    }
}
