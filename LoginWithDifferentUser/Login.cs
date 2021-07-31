using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;
using System.Net.Mime;
using System.Threading;
using System.Data.Sql;
using System.Net;

namespace LoginWithDifferentUser
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.slide2;
            System.Windows.Forms.Timer tim = new System.Windows.Forms.Timer();
            tim.Interval = 2000;
            tim.Tick += new EventHandler(changeimage);
            tim.Start();
        }

        private void changeimage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.post1);
            b1.Add(Properties.Resources.slide2);
            b1.Add(Properties.Resources._1);
            b1.Add(Properties.Resources._2);
            b1.Add(Properties.Resources._3);
            b1.Add(Properties.Resources._4);
            b1.Add(Properties.Resources._5);
            b1.Add(Properties.Resources._6);
            b1.Add(Properties.Resources._7);
            b1.Add(Properties.Resources._8);
            b1.Add(Properties.Resources._9);
            b1.Add(Properties.Resources._10);

            int index = DateTime.Now.Second % b1.Count;
            this.BackgroundImage = b1[index];
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string username = userNameTextbox.Text;
            string password = passwordTextbox.Text;
            // Console.Write(username + "," + password);

            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "(select * from user_login where username='" + username + "' and password = '" + password + "')";

            SqlCommand selectcommand = new SqlCommand(insertString, connection);

            SqlDataReader dataFromDb = selectcommand.ExecuteReader();
            if (dataFromDb.HasRows)
            {
                this.Hide();
                if (userNameTextbox.Text=="admin")
                {
                     Admin featureForm = new Admin();
                featureForm.Show();

                }
                else if (userNameTextbox.Text == "finance")
                {
                    Finance featureForm2 = new Finance();
                    featureForm2.Show();
                }
                else if (userNameTextbox.Text == "receiption")
                {
                    Receiption featureForm2 = new Receiption();
                    featureForm2.Show();
                }
               
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
