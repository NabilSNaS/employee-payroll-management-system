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
    public partial class Finance : Form
    {
        public Finance()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox8.Items.Clear();
            string position = (string)this.listBox7.SelectedItem;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("Select * from staff_info where position='" + position + "'", connection);
            insertcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(insertcommand);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox8.Items.Add(dr["name"].ToString());
              




            }
        }
        public void listbox15()
        {

            listBox7.Items.Clear();
           

            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("Select position from staff_info", connection);
            insertcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(insertcommand);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox7.Items.Add(dr["position"].ToString());
                

            }
        }

        private void eight_Enter(object sender, EventArgs e)
        {
            listbox15();
        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("update staff_info set  id='" + textBox44.Text + "',name='" + textBox43.Text + "',gender='" + comboBox2.Text + "',position='" + comboBox3.Text + "',salary='" + textBox40.Text + "',phone='" + textBox39.Text + "',address='" + textBox38.Text + "'   where id='" + textBox44.Text + "'", connection);
            insertcommand.ExecuteNonQuery();
            MessageBox.Show("UPDATE successfully");

            listbox15();
            textBox44.Text = "";
            textBox43.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            nine.Visible = true;
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = (string)this.listBox8.SelectedItem;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("Select * from staff_info where name='" + name + "'", connection);
            insertcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(insertcommand);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox44.Text = dr["id"].ToString();
                textBox43.Text = dr["name"].ToString();
                comboBox2.Text = dr["gender"].ToString();
                comboBox3.Text = dr["position"].ToString();
                textBox40.Text = dr["salary"].ToString();
                textBox39.Text = dr["phone"].ToString();
                textBox38.Text = dr["address"].ToString();

            }
        }

        private void one_Click(object sender, EventArgs e)
        {
           
           
        }

        private void two_Click(object sender, EventArgs e)
        {
            
        }

        private void three_Click(object sender, EventArgs e)
        {
            
        }

        private void five_Click(object sender, EventArgs e)
        {
            
            
        }

        private void one_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            nine.Visible = false;

        }

        private void two_Click_1(object sender, EventArgs e)
        {
            
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            nine.Visible = false;
        }

        private void three_Click_1(object sender, EventArgs e)
        {
            
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            nine.Visible = false;
        }

        private void five_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            nine.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string building = buildig.Text;
            string floor = floor1.Text;
            string room_number = roomNo.Text;
            string room_type = roomType.Text;
            string no_of_bed = noOfBed.Text;
            string unit_price = unitPrice.Text;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "INSERT INTO new_ward(building,floor,room_number,room_type,no_of_bed,unit_price) values('" + building + "','" + floor + "','" + room_number + "','" + room_type + "','" + no_of_bed + "','" + unit_price + "')";

            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();
            MessageBox.Show("insert successfully");
        }

        private void button22_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "delete  from patient_registration where name='" + textBox24.Text + "'";
            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();

            textBox25.Text = "";
            textBox24.Text = "";
            dateTimePicker3.Text = "";
            textBox27.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            listbox();
            MessageBox.Show("Delete successful");
            
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        public void listbox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            selectRoom.Items.Clear();
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("Select name from patient_registration", connection);
            insertcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(insertcommand);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["name"].ToString());
                listBox2.Items.Add(dr["name"].ToString());
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            listbox();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("update patient_registration set name='" + textBox4.Text + "',gender='" + textBox12.Text + "',age='" + textBox5.Text + "', phone='" + textBox6.Text + "',address='" + textBox7.Text + "',diseases='" + textBox9.Text + "',status_of_diseases='" + textBox8.Text + "',building='" + textBox11.Text + "',room_number='" + textBox10.Text + "',room_type='" + textBox1.Text + "',price='" + textBox2.Text + "'   where pid='" + textBox3.Text + "'", connection);
            insertcommand.ExecuteNonQuery();
            MessageBox.Show("UPDATE successfully");
            listbox();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox12.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            listbox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string reg_number = noText.Text;

            string pid = pidText.Text;
            string name = nameText.Text;
            string gender = genderText.Text;
            string age = ageText.Text;
            string phone = phoneText.Text;
            string address = addressText.Text;
            string diseases = diseasesText.Text;
            string status_of_diseases = statusText.Text;
            string building = buildingText.Text;
            string room_number = roomnumberText.Text;
            string room_type = roomtypeText.Text;
            string price = priceText.Text;
            string room_status = comboBox1.Text;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "INSERT INTO patient_registration(reg_number,date,pid,name,gender,age,phone,address,diseases,status_of_diseases,building,room_number,room_type,price,room_status)  values('" + reg_number + "','" + dateTimePicker1.Text + "','" + pid + "','" + name + "','" + gender + "','" + age + "','" + phone + "','" + address + "','" + diseases + "','" + status_of_diseases + "','" + building + "','" + room_number + "','" + room_type + "','" + price + "','" + room_status + "')";

            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();
            listbox();
            MessageBox.Show("insert successfully");
            noText.Text = "";

            pidText.Text = "";
            nameText.Text = "";
            genderText.Text = "";
            ageText.Text = "";
            phoneText.Text = "";
            addressText.Text = "";
            diseasesText.Text = "";
            statusText.Text = "";
            buildingText.Text = "";
            roomnumberText.Text = "";
            roomtypeText.Text = "";
            priceText.Text = "";
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void selectRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buildingText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomnumberText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage fearureForm = new LoginPage();
            fearureForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {

            
        }

        private void button20_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {
            listbox();
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
        }

        private void button22_Click_2(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "delete  from patient_registration where name='" + textBox24.Text + "'";
            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();

            textBox25.Text = "";
            textBox24.Text = "";
            dateTimePicker3.Text = "";
            textBox27.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            listbox();
            MessageBox.Show("Delete successful");
            
        }

        private void button20_Click_2(object sender, EventArgs e)
        {
            DateTime fd = dateTimePicker3.Value.Date;
            DateTime ld = dateTimePicker2.Value.Date;
            TimeSpan result = ld - fd;
            int d, f;
            int.TryParse(textBox14.Text, out d);
            int.TryParse(textBox26.Text, out f);
            int days = (result.Days * d) + f;
            textBox28.Text = days.ToString();
        }

        private void groupBox4_Enter_2(object sender, EventArgs e)
        {
            listbox();
        }

        private void listBox2_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            string name = (string)this.listBox2.SelectedItem;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("Select * from patient_registration where name='" + name + "'", connection);
            insertcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(insertcommand);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox25.Text = dr["pid"].ToString();
                textBox24.Text = dr["name"].ToString();
                dateTimePicker3.Text = dr["date"].ToString();
                textBox27.Text = dr["date"].ToString();
                textBox23.Text = dr["gender"].ToString();
                textBox22.Text = dr["age"].ToString();
                textBox21.Text = dr["phone"].ToString();
                textBox20.Text = dr["address"].ToString();
                textBox19.Text = dr["diseases"].ToString();
                textBox18.Text = dr["status_of_diseases"].ToString();
                textBox17.Text = dr["building"].ToString();
                textBox16.Text = dr["room_number"].ToString();
                textBox15.Text = dr["room_type"].ToString();
                textBox14.Text = dr["price"].ToString();
            }
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            int index = listBox2.FindString(this.textBox13.Text);
            if (0 <= index)
            {
                listBox2.SelectedIndex = index;
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("update patient_registration set name='" + textBox4.Text + "',gender='" + textBox12.Text + "',age='" + textBox5.Text + "', phone='" + textBox6.Text + "',address='" + textBox7.Text + "',diseases='" + textBox9.Text + "',status_of_diseases='" + textBox8.Text + "',building='" + textBox11.Text + "',room_number='" + textBox10.Text + "',room_type='" + textBox1.Text + "',price='" + textBox2.Text + "'   where pid='" + textBox3.Text + "'", connection);
            insertcommand.ExecuteNonQuery();
            MessageBox.Show("UPDATE successfully");
            listbox();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox12.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {
            listbox();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string name = (string)this.listBox1.SelectedItem;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("Select * from patient_registration where name='" + name + "'", connection);
            insertcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(insertcommand);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox3.Text = dr["pid"].ToString();
                textBox4.Text = dr["name"].ToString();
                textBox12.Text = dr["gender"].ToString();
                textBox5.Text = dr["age"].ToString();
                textBox6.Text = dr["phone"].ToString();
                textBox7.Text = dr["address"].ToString();
                textBox9.Text = dr["diseases"].ToString();
                textBox8.Text = dr["status_of_diseases"].ToString();
                textBox11.Text = dr["building"].ToString();
                textBox10.Text = dr["room_number"].ToString();
                textBox1.Text = dr["room_type"].ToString();
                textBox2.Text = dr["price"].ToString();
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            int index = listBox1.FindString(this.textBoxSearch.Text);
            if (0 <= index)
            {
                listBox1.SelectedIndex = index;
            }
         
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string reg_number = noText.Text;

            string pid = pidText.Text;
            string name = nameText.Text;
            string gender = genderText.Text;
            string age = ageText.Text;
            string phone = phoneText.Text;
            string address = addressText.Text;
            string diseases = diseasesText.Text;
            string status_of_diseases = statusText.Text;
            string building = buildingText.Text;
            string room_number = roomnumberText.Text;
            string room_type = roomtypeText.Text;
            string price = priceText.Text;
            string room_status = comboBox1.Text;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "INSERT INTO patient_registration(reg_number,date,pid,name,gender,age,phone,address,diseases,status_of_diseases,building,room_number,room_type,price,room_status)  values('" + reg_number + "','" + dateTimePicker1.Text + "','" + pid + "','" + name + "','" + gender + "','" + age + "','" + phone + "','" + address + "','" + diseases + "','" + status_of_diseases + "','" + building + "','" + room_number + "','" + room_type + "','" + price + "','" + room_status + "')";

            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();
            listbox();
            MessageBox.Show("insert successfully");
            noText.Text = "";

            pidText.Text = "";
            nameText.Text = "";
            genderText.Text = "";
            ageText.Text = "";
            phoneText.Text = "";
            addressText.Text = "";
            diseasesText.Text = "";
            statusText.Text = "";
            buildingText.Text = "";
            roomnumberText.Text = "";
            roomtypeText.Text = "";
            priceText.Text = "";
            
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void selectRoom_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void buildingText_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void roomnumberText_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            string reg_number = noText.Text;

            string pid = pidText.Text;
            string name = nameText.Text;
            string gender = genderText.Text;
            string age = ageText.Text;
            string phone = phoneText.Text;
            string address = addressText.Text;
            string diseases = diseasesText.Text;
            string status_of_diseases = statusText.Text;
            string building = buildingText.Text;
            string room_number = roomnumberText.Text;
            string room_type = roomtypeText.Text;
            string price = priceText.Text;
            string room_status = comboBox1.Text;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "INSERT INTO patient_registration(reg_number,date,pid,name,gender,age,phone,address,diseases,status_of_diseases,building,room_number,room_type,price,room_status)  values('" + reg_number + "','" + dateTimePicker1.Text + "','" + pid + "','" + name + "','" + gender + "','" + age + "','" + phone + "','" + address + "','" + diseases + "','" + status_of_diseases + "','" + building + "','" + room_number + "','" + room_type + "','" + price + "','" + room_status + "')";

            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();
            listbox();
            MessageBox.Show("insert successfully");
            noText.Text = "";

            pidText.Text = "";
            nameText.Text = "";
            genderText.Text = "";
            ageText.Text = "";
            phoneText.Text = "";
            addressText.Text = "";
            diseasesText.Text = "";
            statusText.Text = "";
            buildingText.Text = "";
            roomnumberText.Text = "";
            roomtypeText.Text = "";
            priceText.Text = "";
            
        }

        private void button8_Click_2(object sender, EventArgs e)
        {

        }

        private void selectRoom_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            string a = "BUSY";
            roomnumberText.Items.Clear();
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select  distinct room_number from new_ward where new_ward.room_type='" + selectRoom.Text + "' and new_ward.room_number not in(select patient_registration.room_number from  patient_registration where patient_registration.room_status='" + a + "')", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                roomnumberText.Items.Add(dr["room_number"].ToString());

            }
        }

        private void groupBox2_Enter_2(object sender, EventArgs e)
        {

            buildingText.Items.Clear();
            selectRoom.Items.Clear();
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("Select distinct building from new_ward", connection);
            insertcommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(insertcommand);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                buildingText.Items.Add(dr["building"].ToString());

            }
        }

        private void buildingText_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            selectRoom.Items.Clear();
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select  distinct room_type,building from new_ward where building='" + buildingText.Text + "'", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                selectRoom.Items.Add(dr["room_type"].ToString());

            }
        }

        private void roomnumberText_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("Select room_type,unit_price from new_ward where room_type='" + selectRoom.Text + "'", connection);
            insertcommand.ExecuteNonQuery();

            SqlDataReader dr = insertcommand.ExecuteReader();
            while (dr.Read())
            {
                string roomtype = (string)dr["room_type"].ToString();
                roomtypeText.Text = roomtype;
                string price = (string)dr["unit_price"].ToString();
                priceText.Text = price;
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage fearureForm = new LoginPage();
            fearureForm.Show();







        }

        private void circulerButton2_Click(object sender, EventArgs e)
        {
            string reg_number = noText.Text;

            string pid = pidText.Text;
            string name = nameText.Text;
            string gender = genderText.Text;
            string age = ageText.Text;
            string phone = phoneText.Text;
            string address = addressText.Text;
            string diseases = diseasesText.Text;
            string status_of_diseases = statusText.Text;
            string building = buildingText.Text;
            string room_number = roomnumberText.Text;
            string room_type = roomtypeText.Text;
            string price = priceText.Text;
            string room_status = comboBox1.Text;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "INSERT INTO patient_registration(reg_number,date,pid,name,gender,age,phone,address,diseases,status_of_diseases,building,room_number,room_type,price,room_status)  values('" + reg_number + "','" + dateTimePicker1.Text + "','" + pid + "','" + name + "','" + gender + "','" + age + "','" + phone + "','" + address + "','" + diseases + "','" + status_of_diseases + "','" + building + "','" + room_number + "','" + room_type + "','" + price + "','" + room_status + "')";

            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();
            listbox();
            MessageBox.Show("insert successfully");
            noText.Text = "";

            pidText.Text = "";
            nameText.Text = "";
            genderText.Text = "";
            ageText.Text = "";
            phoneText.Text = "";
            addressText.Text = "";
            diseasesText.Text = "";
            statusText.Text = "";
            buildingText.Text = "";
            roomnumberText.Text = "";
            roomtypeText.Text = "";
            priceText.Text = "";
        }

        private void circulerButton1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void circulerButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage fearureForm = new LoginPage();
            fearureForm.Show();




        }

        private void circulerButton3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            nine.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
        }

        private void circulerButton5_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void circulerButton6_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("update patient_registration set name='" + textBox4.Text + "',gender='" + textBox12.Text + "',age='" + textBox5.Text + "', phone='" + textBox6.Text + "',address='" + textBox7.Text + "',diseases='" + textBox9.Text + "',status_of_diseases='" + textBox8.Text + "',building='" + textBox11.Text + "',room_number='" + textBox10.Text + "',room_type='" + textBox1.Text + "',price='" + textBox2.Text + "'   where pid='" + textBox3.Text + "'", connection);
            insertcommand.ExecuteNonQuery();
            MessageBox.Show("UPDATE successfully");
            listbox();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox12.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            
            textBox2.Text = "";
        }

        private void circulerButton7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            int index = listBox1.FindString(this.textBoxSearch.Text);
            if (0 <= index)
            {
                listBox1.SelectedIndex = index;
            }
        }

        private void circulerButton8_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void circulerButton9_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "delete  from patient_registration where name='" + textBox24.Text + "'";
            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();

            textBox25.Text = "";
            textBox24.Text = "";
            dateTimePicker3.Text = "";
            textBox27.Text = "";
            textBox23.Text = "";
            textBox22.Text = "";
            textBox21.Text = "";
            textBox20.Text = "";
            textBox19.Text = "";
            textBox18.Text = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            listbox();
            MessageBox.Show("Delete successful");
            
        }

        private void circulerButton10_Click(object sender, EventArgs e)
        {
            DateTime fd = dateTimePicker3.Value.Date;
            DateTime ld = dateTimePicker2.Value.Date;
            TimeSpan result = ld - fd;
            int d, f;
            int.TryParse(textBox14.Text, out d);
            int.TryParse(textBox26.Text, out f);
            int days = (result.Days * d) + f;
            textBox28.Text = days.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void circulerButton11_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
        }

        private void circulerButton12_Click(object sender, EventArgs e)
        {
            string building = buildig.Text;
            string floor = floor1.Text;
            string room_number = roomNo.Text;
            string room_type = roomType.Text;
            string no_of_bed = noOfBed.Text;
            string unit_price = unitPrice.Text;
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            string insertString = "INSERT INTO new_ward(building,floor,room_number,room_type,no_of_bed,unit_price) values('" + building + "','" + floor + "','" + room_number + "','" + room_type + "','" + no_of_bed + "','" + unit_price + "')";

            SqlCommand insertcommand = new SqlCommand(insertString, connection);
            insertcommand.ExecuteNonQuery();
            MessageBox.Show("insert successfully");
        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void circulerButton13_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("update staff_info set  id='" + textBox44.Text + "',name='" + textBox43.Text + "',gender='" + comboBox2.Text + "',position='" + comboBox3.Text + "',salary='" + textBox40.Text + "',phone='" + textBox39.Text + "',address='" + textBox38.Text + "'   where id='" + textBox44.Text + "'", connection);
            insertcommand.ExecuteNonQuery();
            MessageBox.Show("UPDATE successfully");

            listbox15();
            textBox44.Text = "";
            textBox43.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
        }

      
        private void circulerButton14_Click_1(object sender, EventArgs e)
        {
            nine.Visible = false;
        }

        private void circulerButton13_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            SqlCommand insertcommand = new SqlCommand("update staff_info set  id='" + textBox44.Text + "',name='" + textBox43.Text + "',gender='" + comboBox2.Text + "',position='" + comboBox3.Text + "',salary='" + textBox40.Text + "',phone='" + textBox39.Text + "',address='" + textBox38.Text + "'   where id='" + textBox44.Text + "'", connection);
            insertcommand.ExecuteNonQuery();
            MessageBox.Show("UPDATE successfully");

            listbox15();
            textBox44.Text = "";
            textBox43.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox40.Text = "";
            textBox39.Text = "";
            textBox38.Text = "";
        }

        private void circulerButton15_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-FUOKFP6; Initial Catalog=HMS; Integrated Security= true");
            connection.Open();
            int index = listBox2.FindString(this.textBox13.Text);
            if (0 <= index)
            {
                listBox2.SelectedIndex = index;
            }
        }
    }
}
