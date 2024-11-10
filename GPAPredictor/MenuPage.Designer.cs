namespace GPAPredictor
{
    partial class MenuPage
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
            this.predictGPA_btn = new System.Windows.Forms.Button();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // predictGPA_btn
            // 
            this.predictGPA_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.predictGPA_btn.FlatAppearance.BorderSize = 0;
            this.predictGPA_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.predictGPA_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.predictGPA_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predictGPA_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictGPA_btn.ForeColor = System.Drawing.Color.White;
            this.predictGPA_btn.Location = new System.Drawing.Point(191, 223);
            this.predictGPA_btn.Name = "predictGPA_btn";
            this.predictGPA_btn.Size = new System.Drawing.Size(288, 40);
            this.predictGPA_btn.TabIndex = 6;
            this.predictGPA_btn.Text = "Predict GPA";
            this.predictGPA_btn.UseVisualStyleBackColor = false;
            this.predictGPA_btn.Click += new System.EventHandler(this.predictGPA_btn_Click);
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.logOut_btn.FlatAppearance.BorderSize = 0;
            this.logOut_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.logOut_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.logOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut_btn.ForeColor = System.Drawing.Color.White;
            this.logOut_btn.Location = new System.Drawing.Point(191, 291);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(288, 40);
            this.logOut_btn.TabIndex = 8;
            this.logOut_btn.Text = "Log out";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(638, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 21);
            this.close.TabIndex = 25;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DodgerBlue;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(254, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 47);
            this.label7.TabIndex = 26;
            this.label7.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 41);
            this.label2.TabIndex = 27;
            this.label2.Text = "Predictor";
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.close);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.predictGPA_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button predictGPA_btn;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}