using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace GPAPredictor
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dulanjalee Perera\OneDrive\Documents\GPAProject.mdf"";Integrated Security=True;Connect Timeout=30");
        public RegisterForm()
        {
            InitializeComponent();
        }

        public bool checkConnection() 
        { 
            return (connect.State == ConnectionState.Closed) ? true :  false;
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1 ();
            loginForm.Show();

            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {//check if all the fields are filled by the
                MessageBox.Show("Please fill all balnk fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        //check if the username you want to register already exist 
                        string selectUsername = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                            
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable(); 

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {   //to put the 1st letter to big letter 
                                string tempUsern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show("Username " + tempUsern + " already exists ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if(register_password.Text.Length < 8)
                            {
                                MessageBox.Show("minimum 8 characters are required","Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            
                            }
                            else if (register_password.Text != register_cPassword.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                String insertData = "INSERT INTO users (username, password, date_create)VALUES(@usern,@pass,@date)";
                                //QUERY THAT INSERT DATA INTO THE USERS TABLE
                                using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", register_password.Text.Trim());

                                    DateTime today = DateTime.Today; //date now
                                    insertUser.Parameters.AddWithValue("@date",today);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();
                                }
                            }
                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';    
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void register_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
