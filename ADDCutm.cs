using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ATMmachine
{
    public partial class ADDCutm : Form
    {
        public ADDCutm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Apple-MacBook-Air\Documents\ATM.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            int Balance = 0;

            if(AccountNo.Text == "" || CustName.Text == "" || Pin.Text == "" || Dob.Text==""  || Address.Text== "" || Occupation.Text == "" || Balance.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    String query = "insert into Account values('" + AccountNo.Text + "','" + CustName.Text + "','" + Pin.Text + "','" + Dob.Text + "','" + Address.Text + "','" + Occupation.Text + "','" + Balance + "')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Con.Close();

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Addess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
