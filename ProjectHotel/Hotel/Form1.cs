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

namespace Hotel
{
    public partial class Form1 : Form
    {
        List<Client> people = new List<Client>(); // list that holds all the informations about persons.
        List<Room> room = new List<Room>();
        public Form1()
        {
            InitializeComponent();
        }

        public string data = "Data Source=DESKTOP-DQCLD4J;Initial Catalog=Clients;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            Client p = new Client();
            p.ID = textBox1.Text;
            p.Name = textBox2.Text;
            p.Surname = textBox3.Text;
            p.Birthday = dateTimePicker1.Value;
            p.Information = textBox5.Text;
            people.Add(p);//We add the person to the people list.
            listView1.Items.Add(p.Name);
            //Nese deshirojm me i fshi te dhenat nga textboxet pasi qe i kemi shtuar per te shtuar te reja.
            Room r = new Room();
            r.IDRoom = textBox4.Text;
            room.Add(r);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = " ";
            textBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = people[listView1.SelectedItems[0].Index].ID;
                textBox2.Text = people[listView1.SelectedItems[0].Index].Name;
                textBox3.Text = people[listView1.SelectedItems[0].Index].Surname;
                textBox4.Text = room[listView1.SelectedItems[0].Index].IDRoom;
                textBox5.Text = people[listView1.SelectedItems[0].Index].Information;
                dateTimePicker1.Value = people[listView1.SelectedItems[0].Index].Birthday;
            }
            catch
            {

            }

        }

        

        

        private void ADDdb_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(data);
            con.Open();
            if (con.State==System.Data.ConnectionState.Open)
            {
                string q = "insert into klientet(Id,Name,Surname,Room_nr)" +
                    " values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','" +
                    "" + textBox3.Text.ToString() + "','" +
                    "" + textBox4.Text.ToString() +"')";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection made Successfuly....!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


    
}
