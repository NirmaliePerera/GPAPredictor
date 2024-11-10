namespace GPAPredictor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addMoreButton = new System.Windows.Forms.Button();
            this.calculatePredictedGPA_btn = new System.Windows.Forms.Button();
            this.gpaResultTextBox = new System.Windows.Forms.TextBox();
            this.valuesOfGrades_btn = new System.Windows.Forms.Button();
            this.saveResult_btn = new System.Windows.Forms.Button();
            this.semNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA PREDICTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(670, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your grades (from mid semester evaluation) and credits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Module";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(791, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 21);
            this.close.TabIndex = 9;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 206);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(543, 417);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // addMoreButton
            // 
            this.addMoreButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMoreButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoreButton.ForeColor = System.Drawing.Color.White;
            this.addMoreButton.Location = new System.Drawing.Point(607, 206);
            this.addMoreButton.Name = "addMoreButton";
            this.addMoreButton.Size = new System.Drawing.Size(185, 40);
            this.addMoreButton.TabIndex = 12;
            this.addMoreButton.Text = "Add More Modules";
            this.addMoreButton.UseVisualStyleBackColor = false;
            this.addMoreButton.Click += new System.EventHandler(this.addMoreButton_Click);
            // 
            // calculatePredictedGPA_btn
            // 
            this.calculatePredictedGPA_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.calculatePredictedGPA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatePredictedGPA_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatePredictedGPA_btn.ForeColor = System.Drawing.Color.White;
            this.calculatePredictedGPA_btn.Location = new System.Drawing.Point(607, 262);
            this.calculatePredictedGPA_btn.Name = "calculatePredictedGPA_btn";
            this.calculatePredictedGPA_btn.Size = new System.Drawing.Size(185, 40);
            this.calculatePredictedGPA_btn.TabIndex = 13;
            this.calculatePredictedGPA_btn.Text = "Predict GPA";
            this.calculatePredictedGPA_btn.UseVisualStyleBackColor = false;
            this.calculatePredictedGPA_btn.Click += new System.EventHandler(this.calculatePredictedGPA_btn_Click);
            // 
            // gpaResultTextBox
            // 
            this.gpaResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaResultTextBox.Location = new System.Drawing.Point(607, 330);
            this.gpaResultTextBox.Name = "gpaResultTextBox";
            this.gpaResultTextBox.Size = new System.Drawing.Size(185, 30);
            this.gpaResultTextBox.TabIndex = 14;
            // 
            // valuesOfGrades_btn
            // 
            this.valuesOfGrades_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.valuesOfGrades_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valuesOfGrades_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuesOfGrades_btn.ForeColor = System.Drawing.Color.White;
            this.valuesOfGrades_btn.Location = new System.Drawing.Point(607, 565);
            this.valuesOfGrades_btn.Name = "valuesOfGrades_btn";
            this.valuesOfGrades_btn.Size = new System.Drawing.Size(185, 58);
            this.valuesOfGrades_btn.TabIndex = 15;
            this.valuesOfGrades_btn.Text = "See the values for the grades";
            this.valuesOfGrades_btn.UseVisualStyleBackColor = false;
            this.valuesOfGrades_btn.Click += new System.EventHandler(this.valuesOfGrades_btn_Click);
            // 
            // saveResult_btn
            // 
            this.saveResult_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveResult_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveResult_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveResult_btn.ForeColor = System.Drawing.Color.White;
            this.saveResult_btn.Location = new System.Drawing.Point(633, 493);
            this.saveResult_btn.Name = "saveResult_btn";
            this.saveResult_btn.Size = new System.Drawing.Size(140, 40);
            this.saveResult_btn.TabIndex = 16;
            this.saveResult_btn.Text = "Save Result";
            this.saveResult_btn.UseVisualStyleBackColor = false;
            this.saveResult_btn.Click += new System.EventHandler(this.saveResult_btn_Click);
            // 
            // semNameTextBox
            // 
            this.semNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semNameTextBox.Location = new System.Drawing.Point(607, 443);
            this.semNameTextBox.Name = "semNameTextBox";
            this.semNameTextBox.Size = new System.Drawing.Size(185, 30);
            this.semNameTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(602, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Semester Name:";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 9);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(55, 21);
            this.back.TabIndex = 19;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(824, 725);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.semNameTextBox);
            this.Controls.Add(this.saveResult_btn);
            this.Controls.Add(this.valuesOfGrades_btn);
            this.Controls.Add(this.gpaResultTextBox);
            this.Controls.Add(this.calculatePredictedGPA_btn);
            this.Controls.Add(this.addMoreButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addMoreButton;
        private System.Windows.Forms.Button calculatePredictedGPA_btn;
        private System.Windows.Forms.TextBox gpaResultTextBox;
        private System.Windows.Forms.Button valuesOfGrades_btn;
        private System.Windows.Forms.Button saveResult_btn;
        private System.Windows.Forms.TextBox semNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label back;
    }
}