namespace address_book;

using System;
using System.Windows.Forms;
using System.Xml.Linq;


public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        string email = txtEmail.Text;
        string phone = txtPhone.Text;

        MessageBox.Show($"Name: {name}\nEmail: {email}\nPhone: {phone}");

        
        

        //clear text boxes
        txtName.Text = ""; 
        txtEmail.Text = "";
        txtPhone.Text = "";
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
