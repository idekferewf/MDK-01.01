namespace MySqlSimpleTest
{
    partial class AddUserForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.fioLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 16);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(121, 13);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(122, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(121, 39);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(122, 20);
            this.passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 42);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль:";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(121, 65);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(122, 20);
            this.fioTextBox.TabIndex = 5;
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Location = new System.Drawing.Point(12, 68);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(37, 13);
            this.fioLabel.TabIndex = 4;
            this.fioLabel.Text = "ФИО:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(12, 94);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(52, 13);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Возраст:";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(12, 120);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(89, 13);
            this.birthDateLabel.TabIndex = 8;
            this.birthDateLabel.Text = "Дата рождения:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(121, 143);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(122, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 146);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(40, 13);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Почта:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(155, 178);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 27);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(47, 178);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(102, 27);
            this.addUserButton.TabIndex = 13;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(121, 117);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.birthDateTimePicker.TabIndex = 14;
            this.birthDateTimePicker.Value = new System.DateTime(2025, 4, 3, 11, 56, 49, 0);
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(121, 91);
            this.ageNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(122, 20);
            this.ageNumericUpDown.TabIndex = 15;
            this.ageNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 217);
            this.Controls.Add(this.ageNumericUpDown);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.MaximumSize = new System.Drawing.Size(271, 256);
            this.MinimumSize = new System.Drawing.Size(271, 256);
            this.Name = "AddUserForm";
            this.Text = "Добавить пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.NumericUpDown ageNumericUpDown;
    }
}