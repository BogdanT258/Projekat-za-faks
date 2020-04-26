namespace ProjekatZaFaks
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.age1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.becomeEmployee = new System.Windows.Forms.Button();
            this.becomePartTimer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(6, 18);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 24);
            this.name.TabIndex = 0;
            this.name.Text = "label1";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.surname.Location = new System.Drawing.Point(84, 18);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(60, 24);
            this.surname.TabIndex = 1;
            this.surname.Text = "label2";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gender.Location = new System.Drawing.Point(91, 61);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(53, 18);
            this.gender.TabIndex = 2;
            this.gender.Text = "gender";
            this.gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // age1
            // 
            this.age1.AutoSize = true;
            this.age1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.age1.Location = new System.Drawing.Point(20, 59);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(32, 18);
            this.age1.TabIndex = 3;
            this.age1.Text = "age";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.gender);
            this.groupBox1.Controls.Add(this.age1);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Location = new System.Drawing.Point(156, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // becomeEmployee
            // 
            this.becomeEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.becomeEmployee.Location = new System.Drawing.Point(44, 195);
            this.becomeEmployee.Name = "becomeEmployee";
            this.becomeEmployee.Size = new System.Drawing.Size(120, 50);
            this.becomeEmployee.TabIndex = 5;
            this.becomeEmployee.Text = "Become Employee";
            this.becomeEmployee.UseVisualStyleBackColor = true;
            this.becomeEmployee.Click += new System.EventHandler(this.BecomeEmployee_Click);
            // 
            // becomePartTimer
            // 
            this.becomePartTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.becomePartTimer.Location = new System.Drawing.Point(223, 195);
            this.becomePartTimer.Name = "becomePartTimer";
            this.becomePartTimer.Size = new System.Drawing.Size(120, 50);
            this.becomePartTimer.TabIndex = 6;
            this.becomePartTimer.Text = "Become a Part Timer";
            this.becomePartTimer.UseVisualStyleBackColor = true;
            this.becomePartTimer.Click += new System.EventHandler(this.BecomePartTimer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 274);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.becomePartTimer);
            this.Controls.Add(this.becomeEmployee);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recommendation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label age1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button becomeEmployee;
        private System.Windows.Forms.Button becomePartTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}