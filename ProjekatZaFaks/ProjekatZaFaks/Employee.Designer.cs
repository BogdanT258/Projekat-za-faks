namespace ProjekatZaFaks
{
    partial class Employee
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
            this.question1 = new System.Windows.Forms.Label();
            this.experience = new System.Windows.Forms.NumericUpDown();
            this.question2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.question3 = new System.Windows.Forms.Label();
            this.relocateyes = new System.Windows.Forms.RadioButton();
            this.relocateno = new System.Windows.Forms.RadioButton();
            this.submitEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.experience)).BeginInit();
            this.SuspendLayout();
            // 
            // question1
            // 
            this.question1.AutoSize = true;
            this.question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question1.Location = new System.Drawing.Point(13, 13);
            this.question1.Name = "question1";
            this.question1.Size = new System.Drawing.Size(76, 18);
            this.question1.TabIndex = 0;
            this.question1.Text = "Question1";
            this.question1.Click += new System.EventHandler(this.Question1_Click);
            // 
            // experience
            // 
            this.experience.Location = new System.Drawing.Point(122, 34);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(99, 22);
            this.experience.TabIndex = 1;
            // 
            // question2
            // 
            this.question2.AutoSize = true;
            this.question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question2.Location = new System.Drawing.Point(13, 70);
            this.question2.Name = "question2";
            this.question2.Size = new System.Drawing.Size(76, 18);
            this.question2.TabIndex = 2;
            this.question2.Text = "Question2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 111);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 67);
            this.textBox1.TabIndex = 3;
            // 
            // question3
            // 
            this.question3.AutoSize = true;
            this.question3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question3.Location = new System.Drawing.Point(13, 192);
            this.question3.Name = "question3";
            this.question3.Size = new System.Drawing.Size(76, 18);
            this.question3.TabIndex = 4;
            this.question3.Text = "Question3";
            // 
            // relocateyes
            // 
            this.relocateyes.AutoSize = true;
            this.relocateyes.Location = new System.Drawing.Point(16, 235);
            this.relocateyes.Name = "relocateyes";
            this.relocateyes.Size = new System.Drawing.Size(53, 21);
            this.relocateyes.TabIndex = 5;
            this.relocateyes.TabStop = true;
            this.relocateyes.Text = "Yes";
            this.relocateyes.UseVisualStyleBackColor = true;
            // 
            // relocateno
            // 
            this.relocateno.AutoSize = true;
            this.relocateno.Location = new System.Drawing.Point(122, 235);
            this.relocateno.Name = "relocateno";
            this.relocateno.Size = new System.Drawing.Size(47, 21);
            this.relocateno.TabIndex = 6;
            this.relocateno.TabStop = true;
            this.relocateno.Text = "No";
            this.relocateno.UseVisualStyleBackColor = true;
            // 
            // submitEmployee
            // 
            this.submitEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.submitEmployee.Location = new System.Drawing.Point(109, 302);
            this.submitEmployee.Name = "submitEmployee";
            this.submitEmployee.Size = new System.Drawing.Size(144, 50);
            this.submitEmployee.TabIndex = 7;
            this.submitEmployee.Text = "Submit";
            this.submitEmployee.UseVisualStyleBackColor = true;
            this.submitEmployee.Click += new System.EventHandler(this.SubmitEmployee_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 383);
            this.Controls.Add(this.submitEmployee);
            this.Controls.Add(this.relocateno);
            this.Controls.Add(this.relocateyes);
            this.Controls.Add(this.question3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.question2);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.question1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.experience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question1;
        private System.Windows.Forms.NumericUpDown experience;
        private System.Windows.Forms.Label question2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label question3;
        private System.Windows.Forms.RadioButton relocateyes;
        private System.Windows.Forms.RadioButton relocateno;
        private System.Windows.Forms.Button submitEmployee;
    }
}