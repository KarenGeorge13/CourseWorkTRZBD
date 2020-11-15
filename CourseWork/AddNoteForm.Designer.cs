namespace CourseWork
{
    partial class AddNoteForm
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
            this.drinkIdLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.RichTextBox();
            this.drinkComboBox = new System.Windows.Forms.ComboBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // drinkIdLabel
            // 
            this.drinkIdLabel.AutoSize = true;
            this.drinkIdLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkIdLabel.Location = new System.Drawing.Point(27, 19);
            this.drinkIdLabel.Name = "drinkIdLabel";
            this.drinkIdLabel.Size = new System.Drawing.Size(82, 21);
            this.drinkIdLabel.TabIndex = 1;
            this.drinkIdLabel.Text = "Напиток:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(27, 222);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(209, 21);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Дата добавления записи:";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descLabel.Location = new System.Drawing.Point(27, 59);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(210, 21);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Описание вкуса напитка:";
            // 
            // descTextBox
            // 
            this.descTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descTextBox.Location = new System.Drawing.Point(31, 105);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(250, 96);
            this.descTextBox.TabIndex = 5;
            this.descTextBox.Text = "";
            // 
            // drinkComboBox
            // 
            this.drinkComboBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drinkComboBox.FormattingEnabled = true;
            this.drinkComboBox.Location = new System.Drawing.Point(115, 16);
            this.drinkComboBox.Name = "drinkComboBox";
            this.drinkComboBox.Size = new System.Drawing.Size(167, 29);
            this.drinkComboBox.TabIndex = 6;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(41, 306);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(110, 40);
            this.changeButton.TabIndex = 9;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(161, 306);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 40);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 356);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.drinkComboBox);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.drinkIdLabel);
            this.Name = "AddNoteForm";
            this.Text = "Добавление записей";
            this.Load += new System.EventHandler(this.AddNoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label drinkIdLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.RichTextBox descTextBox;
        private System.Windows.Forms.ComboBox drinkComboBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}