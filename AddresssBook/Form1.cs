using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        private List<Contact> contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;

            contacts.Add(new Contact { Name = name, Email = email, Phone = phone });
            MessageBox.Show("Contact saved!");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
