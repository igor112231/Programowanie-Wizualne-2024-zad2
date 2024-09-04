namespace Programowanie_Wizualne_2024_zad2
{
    using Microsoft.Data.Sqlite;
    using Microsoft.VisualBasic.Logging;
    using System;
    using System.Data;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using static Programowanie_Wizualne_2024_zad2.Form1;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

    public partial class Form1 : Form
    {
        public static string path = Directory.GetCurrentDirectory();
        DataGridView dataGridView1 = new DataGridView
        {
            Location = new System.Drawing.Point(20, 20),    // Set location of the DataGridView
            Size = new System.Drawing.Size(500, 300),       // Set the size of the DataGridView
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, // Auto-size columns
            AllowUserToAddRows = false,                     // Disable adding new rows
            ReadOnly = true,                                 // Set to read-only mode
            Visible = false
        };

        string connectionString = "Data Source=employee.db";
        public Form1()
        {
            InitializeComponent();
            InitializeDatabase(connectionString);
        }

        public static void InitializeDatabase(string connectionString)
        {

            //path = path + "\\employees.db";
            if (File.Exists(path))
            {
                File.Create("employee.db");
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                CREATE TABLE IF NOT EXISTS Employees (
                    ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL,
                        Position TEXT NOT NULL,
                        Department TEXT NOT NULL,
                        Age INTEGER,
                        Email TEXT,
                        PhoneNumber TEXT,
                        Address TEXT,
                        StartDate DATE,
                        Salary INTEGER,
                        Boss TEXT
                    );
                ";

                command.ExecuteNonQuery();
            }
        }
        public class Employee
        {
            // Properties
            public int ID { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Department { get; set; }
            public string Age { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public double Address { get; set; }
            public string Start_Date { get; set; }
            public int Salary { get; set; }
            public string Boss { get; set; }
        }
        /* public class Manager : Employee
         {
             public string Current_Proect { get; set; }
             public string Dresscode { get; set; }
             public bool Has_PhD { get; set; }
             public int Num_Projects { get; set; }



         }
         public class Programmer : Employee
         {
             public string Boss { get; set; }
             public string Laptop { get; set; }
             public string Main_language { get; set; }
             public bool Morks_from_Home { get; set; }


         }
         public class Cleaner : Employee
         {
             public string Boss { get; set; }
             public string Equipment { get; set; }
             public int Experience { get; set; }
             public string Prev_Job { get; set; }
         }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = path;

        }

        private void add_Employee_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            Exit.Show();

        }

        private void next_Step_Click(object sender, EventArgs e)
        {
            checkgr1();
            //label1.Text = comboBox5.Text;
        }
        public void checkgr1()
        {
            bool check = true;
            int x;
            label1.Text = "";

            if (comboBox5.Text == "Manager")
            {
                comboBox1.Items.Add("5000");
                comboBox1.Items.Add("10000");
                comboBox1.Items.Add("24000");
                comboBox2.Items.Add("HR");
                comboBox2.Items.Add("Finance");
                comboBox2.Items.Add("Sales");
                comboBox3.Items.Add("Frank");
                comboBox3.Items.Add("Harry");
                comboBox3.Items.Add("Megan");

            }
            if (comboBox5.Text == "Cleaner")
            {
                comboBox1.Items.Add("500");
                comboBox1.Items.Add("1000");
                comboBox1.Items.Add("2000");
                comboBox2.Items.Add("Researche and development");
                comboBox2.Items.Add("Production");
                comboBox2.Items.Add("Marketing");
                comboBox3.Items.Add("Alex");
                comboBox3.Items.Add("Juliette");
                comboBox3.Items.Add("Ceasar");
            }
            if (comboBox5.Text == "Programmer")
            {
                comboBox1.Items.Add("2000");
                comboBox1.Items.Add("30000");
                comboBox1.Items.Add("44000");
                comboBox2.Items.Add("IT");
                comboBox2.Items.Add("Sales");
                comboBox2.Items.Add("Finance");
                comboBox3.Items.Add("Henry");
                comboBox3.Items.Add("Harry");
                comboBox3.Items.Add("Cheng");
            }
            if (textBox1.Text.Length < 1)
            {
                label1.Text += "write proper name";
                check = false;
            }
            if (!Int32.TryParse(textBox2.Text, out x) || x < 18)
            {
                label1.Text += "\nwrite proper age";
                check = false;
            }
            if (!Int32.TryParse(textBox3.Text, out x) || x < 99)
            {
                label1.Text += "\nwrite proper phone number";
                check = false;
            }
            if (textBox5.Text.Length < 1)
            {
                label1.Text += "\nwrite proper address";
                check = false;
            }
            if (textBox6.Text.Length < 1)
            {
                label1.Text += "\nwrite proper email";
                check = false;
            }
            if (!comboBox5.Items.Contains(comboBox5.Text))
            {
                label1.Text += "\nchoose proper position";
                check = false;
            }
            if (check == true)
            {
                groupBox1.Hide();
                groupBox2.Show();
            }
        }

        public void SQLmagic()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    INSERT INTO Employees (Name, Position, Department, Age, Email, PhoneNumber, Address, StartDate, Salary)
                    VALUES ($name, $position, $department, $age, $email, $phoneNumber, $address, $startDate, $salary)
                ";

                command.Parameters.AddWithValue("$name", textBox1.Text);
                command.Parameters.AddWithValue("$position", comboBox5.Text);
                command.Parameters.AddWithValue("$department", comboBox2.Text);
                command.Parameters.AddWithValue("$age", textBox2.Text);
                command.Parameters.AddWithValue("$email", textBox6.Text);
                command.Parameters.AddWithValue("$phoneNumber", textBox3.Text);
                command.Parameters.AddWithValue("$address", textBox5.Text);
                command.Parameters.AddWithValue("$startDate", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("$salary", comboBox1.Text);
                command.Parameters.AddWithValue("$boss", comboBox3.Text);

                command.ExecuteNonQuery();
            }
        }

        public void checkgr2()
        {
            bool check = true;
            int x;
            label1.Text = "";

            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                label1.Text += "choose proper salary";
                check = false;
            }
            if (!comboBox2.Items.Contains(comboBox2.Text))
            {
                label1.Text += "\nchoose proper department";
                check = false;
            }
            if (!comboBox3.Items.Contains(comboBox3.Text))
            {
                label1.Text += "\nchoose proper boss";
                check = false;
            }
            if (dateTimePicker1.Value > DateTime.Now.Date)
            {
                label1.Text += "\nthe latest date can be ";
                check = false;
            }

            if (check == true)
            {
                groupBox2.Hide();
                SQLmagic();
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            checkgr2();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_Employees_Click(object sender, EventArgs e)
        {
            Exit.Show();
            add_Employee.Hide();
            show_Employees.Hide();
            string connectionString = "Data Source=employee.db"; // Adjust this path as needed

            // Create a new DataTable to hold the data
            DataTable dataTable = new DataTable();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // SQL query to retrieve all data from the Employees table
                string query = "SELECT * FROM Employees";

                using (var command = new SqliteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    // Load the data from the SqliteDataReader into the DataTable
                    dataTable.Load(reader);
                }

                connection.Close();
            }



            // Add the DataGridView to the form's controls
            this.Controls.Add(dataGridView1);

            // Set the DataTable as the DataSource of the DataGridView
            dataGridView1.DataSource = dataTable;
            dataGridView1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            dataGridView1.Hide();
            add_Employee.Show();
            show_Employees.Show();
            groupBox1.Hide();
            groupBox2.Hide();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}