namespace ProjekatZaFaks
{
    partial class InputForm
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
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ageInput = new System.Windows.Forms.NumericUpDown();
            this.gender = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.submitInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).BeginInit();
            this.gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(52, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(35, 65);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(65, 17);
            this.surname.TabIndex = 1;
            this.surname.Text = "Surname";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(0, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 23);
            this.age.TabIndex = 0;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(103, 25);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(167, 22);
            this.nameInput.TabIndex = 2;
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(103, 62);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(167, 22);
            this.surnameInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Age";
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(104, 102);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(79, 22);
            this.ageInput.TabIndex = 5;
            // 
            // gender
            // 
            this.gender.Controls.Add(this.female);
            this.gender.Controls.Add(this.male);
            this.gender.Location = new System.Drawing.Point(38, 147);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(218, 79);
            this.gender.TabIndex = 6;
            this.gender.TabStop = false;
            this.gender.Text = "Select your gender";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(119, 32);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 21);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(17, 32);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 21);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // submitInput
            // 
            this.submitInput.Location = new System.Drawing.Point(91, 262);
            this.submitInput.Name = "submitInput";
            this.submitInput.Size = new System.Drawing.Size(165, 41);
            this.submitInput.TabIndex = 7;
            this.submitInput.Text = "Submit";
            this.submitInput.UseVisualStyleBackColor = true;
            this.submitInput.Click += new System.EventHandler(this.SubmitInput_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 333);
            this.Controls.Add(this.submitInput);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.ageInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.age);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Name = "InputForm";
            this.Text = "Input Form";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageInput)).EndInit();
            this.gender.ResumeLayout(false);
            this.gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox surnameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ageInput;
        private System.Windows.Forms.GroupBox gender;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button submitInput;
    }
}

