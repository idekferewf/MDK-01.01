namespace MySqlSimpleTest
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usersGridView.Location = new System.Drawing.Point(0, 61);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(800, 389);
            this.usersGridView.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(12, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(176, 42);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addUserButton.Location = new System.Drawing.Point(194, 13);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(176, 42);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.usersGridView);
            this.Name = "MainForm";
            this.Text = "Список пользователей";
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addUserButton;
    }
}

