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
using System.Linq;

namespace GPAPredictor
{
    public partial class MainForm : Form
    {
        string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Dulanjalee Perera\OneDrive\Documents\GPAProject.mdf"";Integrated Security=True;Connect Timeout=30";
        public int moduleCount = 0;

        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void addMoreButton_Click(object sender, EventArgs e)
        {
            AddNewRow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                AddNewRow();
            }
        }

        private void AddNewRow()
        {
            // Increment the module count
            moduleCount++;

            // panel to hold the row components
            Panel panel = new Panel();
            panel.Size = new Size(flowLayoutPanel1.Width - 20, 30); // Adjust the size

            // Create and configure the Label for the module number
            Label moduleLabel = new Label();
            moduleLabel.Text = "Module " + moduleCount;
            moduleLabel.Size = new Size(150, 30);
            moduleLabel.Location = new Point(3, 3);
            panel.Controls.Add(moduleLabel);

            // TextBox for the grade
            ComboBox gradeComboBox = new ComboBox();
            gradeComboBox.Name = "gradeComboBox";
            gradeComboBox.Size = new Size(100, 30);
            gradeComboBox.Location = new Point(173, 3);
            gradeComboBox.Items.AddRange(new string[] { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D", "E", "F" });
            panel.Controls.Add(gradeComboBox);

            // TextBox for the credits
            NumericUpDown creditsNumericUpDown = new NumericUpDown();
            creditsNumericUpDown.Name = "creditsNumericUpDown";
            creditsNumericUpDown.Size = new Size(100, 30);
            creditsNumericUpDown.Location = new Point(283, 3);
            creditsNumericUpDown.Minimum = 2;
            creditsNumericUpDown.Maximum = 4;
            creditsNumericUpDown.Text = "";
            panel.Controls.Add(creditsNumericUpDown);

            // Add panel to FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(panel);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     

        private void calculatePredictedGPA_btn_Click(object sender, EventArgs e)
        {
            CalculateGPA();
        }

        private double? GetGradeValue(string grade)
        {
            switch(grade)
            {
                case "A+": return 4.0;
                case "A": return 4.0;
                case "A-": return 3.5;
                case "B+": return 3.3;
                case "B": return 3.0;
                case "B-": return 2.7;
                case "C+": return 2.5;
                case "C": return 2.0;
                case "C-": return 1.5;
                case "D": return 1.0;
                case "E": return 0.7;
                case "F": return 0.0;
                default: return null;

            }
        }

        private void CalculateGPA()
        {
            double totalWeightedGrades = 0;
            int totalCredits = 0;

            foreach (Panel panel in flowLayoutPanel1.Controls)
            {
                ComboBox gradeComboBox = panel.Controls.OfType<ComboBox>().FirstOrDefault(t => t.Name == "gradeComboBox");
                NumericUpDown creditsNumericUpDown = panel.Controls.OfType<NumericUpDown>().FirstOrDefault(t => t.Name == "creditsNumericUpDown");
            
                if (gradeComboBox != null && creditsNumericUpDown != null)
                {
                    double? gradeValue = GetGradeValue(gradeComboBox.Text);
                    int credits = (int)creditsNumericUpDown.Value;
                    if (gradeValue!= null)
                    {
                        totalWeightedGrades += gradeValue.Value * credits;
                        totalCredits += credits;
                    }
                }
            }

            if (totalCredits > 0)
            {
                double gpa = totalWeightedGrades / totalCredits;
                gpaResultTextBox.Text = gpa.ToString("F2");
            }
            else
            {
                MessageBox.Show("Please enter valid grade and credits.");
            }
        }

        private void valuesOfGrades_btn_Click(object sender, EventArgs e)
        {
            GradeEquivalence gradeEquivalence = new GradeEquivalence();
            gradeEquivalence.Show();
        }

        private void saveResult_btn_Click(object sender, EventArgs e)
        {
            if (semNameTextBox.Text.Length == 0)
            {
                    MessageBox.Show("Please enter Semester Name.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO Prediction (semester_name, result, number_of_modules, date_create)" +
                        "VALUES (@semname, @result, @nomodules, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@semname", semNameTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@result", gpaResultTextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@nomodules", moduleCount);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Saved Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close();
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure, you want to go back to the main page?");

            MenuPage menuPg = new MenuPage();
            menuPg.Show();

            this.Hide();
        }
    }
}
