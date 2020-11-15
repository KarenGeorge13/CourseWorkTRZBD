namespace CourseWork
{
    partial class TablesForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.countryTabPage = new System.Windows.Forms.TabPage();
            this.addCountryFilterButton = new System.Windows.Forms.Button();
            this.nameCountryFilter = new System.Windows.Forms.TextBox();
            this.removeCountryButton = new System.Windows.Forms.Button();
            this.changeCountryButton = new System.Windows.Forms.Button();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.manufacturerTabPage = new System.Windows.Forms.TabPage();
            this.emailManufacFilter = new System.Windows.Forms.TextBox();
            this.nameManufacFilter = new System.Windows.Forms.TextBox();
            this.phoneManufacFilter = new System.Windows.Forms.TextBox();
            this.adresManufacFilter = new System.Windows.Forms.TextBox();
            this.addManufacturerFilterButton = new System.Windows.Forms.Button();
            this.removeManufacButton = new System.Windows.Forms.Button();
            this.changeManufacButton = new System.Windows.Forms.Button();
            this.addManufacButton = new System.Windows.Forms.Button();
            this.dgvManufacturer = new System.Windows.Forms.DataGridView();
            this.drinkTabPage = new System.Windows.Forms.TabPage();
            this.manufacDrinkFilter = new System.Windows.Forms.TextBox();
            this.nameDrinkFilter = new System.Windows.Forms.TextBox();
            this.countryDrinkFilter = new System.Windows.Forms.TextBox();
            this.priceDrinkFilter = new System.Windows.Forms.TextBox();
            this.addDrinkFilterButton = new System.Windows.Forms.Button();
            this.removeDrinkButton = new System.Windows.Forms.Button();
            this.changeDrinkButton = new System.Windows.Forms.Button();
            this.addDrinkButton = new System.Windows.Forms.Button();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.noteTabPage = new System.Windows.Forms.TabPage();
            this.drinkNoteFilter = new System.Windows.Forms.TextBox();
            this.dateNoteFilter = new System.Windows.Forms.TextBox();
            this.addNoteFilterButton = new System.Windows.Forms.Button();
            this.removeNoteButton = new System.Windows.Forms.Button();
            this.changeNoteButton = new System.Windows.Forms.Button();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.dgvNote = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.countryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            this.manufacturerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturer)).BeginInit();
            this.drinkTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            this.noteTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.countryTabPage);
            this.tabControl1.Controls.Add(this.manufacturerTabPage);
            this.tabControl1.Controls.Add(this.drinkTabPage);
            this.tabControl1.Controls.Add(this.noteTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // countryTabPage
            // 
            this.countryTabPage.Controls.Add(this.addCountryFilterButton);
            this.countryTabPage.Controls.Add(this.nameCountryFilter);
            this.countryTabPage.Controls.Add(this.removeCountryButton);
            this.countryTabPage.Controls.Add(this.changeCountryButton);
            this.countryTabPage.Controls.Add(this.addCountryButton);
            this.countryTabPage.Controls.Add(this.dgvCountry);
            this.countryTabPage.Location = new System.Drawing.Point(4, 30);
            this.countryTabPage.Name = "countryTabPage";
            this.countryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.countryTabPage.Size = new System.Drawing.Size(796, 414);
            this.countryTabPage.TabIndex = 0;
            this.countryTabPage.Text = "Страны";
            this.countryTabPage.UseVisualStyleBackColor = true;
            // 
            // addCountryFilterButton
            // 
            this.addCountryFilterButton.Location = new System.Drawing.Point(8, 366);
            this.addCountryFilterButton.Name = "addCountryFilterButton";
            this.addCountryFilterButton.Size = new System.Drawing.Size(199, 42);
            this.addCountryFilterButton.TabIndex = 7;
            this.addCountryFilterButton.Text = "Открыть фильтры";
            this.addCountryFilterButton.UseVisualStyleBackColor = true;
            this.addCountryFilterButton.Click += new System.EventHandler(this.addCountryFilterButton_Click);
            // 
            // nameCountryFilter
            // 
            this.nameCountryFilter.Location = new System.Drawing.Point(114, 6);
            this.nameCountryFilter.Name = "nameCountryFilter";
            this.nameCountryFilter.Size = new System.Drawing.Size(100, 29);
            this.nameCountryFilter.TabIndex = 6;
            this.nameCountryFilter.Visible = false;
            this.nameCountryFilter.TextChanged += new System.EventHandler(this.nameFilterTextBox_TextChanged);
            // 
            // removeCountryButton
            // 
            this.removeCountryButton.Location = new System.Drawing.Point(328, 366);
            this.removeCountryButton.Name = "removeCountryButton";
            this.removeCountryButton.Size = new System.Drawing.Size(150, 42);
            this.removeCountryButton.TabIndex = 4;
            this.removeCountryButton.Text = "Удалить";
            this.removeCountryButton.UseVisualStyleBackColor = true;
            this.removeCountryButton.Click += new System.EventHandler(this.removeCountryButton_Click);
            // 
            // changeCountryButton
            // 
            this.changeCountryButton.Location = new System.Drawing.Point(484, 366);
            this.changeCountryButton.Name = "changeCountryButton";
            this.changeCountryButton.Size = new System.Drawing.Size(150, 42);
            this.changeCountryButton.TabIndex = 2;
            this.changeCountryButton.Text = "Изменить";
            this.changeCountryButton.UseVisualStyleBackColor = true;
            this.changeCountryButton.Click += new System.EventHandler(this.changeCountryButton_Click);
            // 
            // addCountryButton
            // 
            this.addCountryButton.Location = new System.Drawing.Point(640, 366);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.Size = new System.Drawing.Size(150, 42);
            this.addCountryButton.TabIndex = 1;
            this.addCountryButton.Text = "Добавить";
            this.addCountryButton.UseVisualStyleBackColor = true;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // dgvCountry
            // 
            this.dgvCountry.AllowUserToResizeColumns = false;
            this.dgvCountry.AllowUserToResizeRows = false;
            this.dgvCountry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Location = new System.Drawing.Point(8, 6);
            this.dgvCountry.MultiSelect = false;
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.RowHeadersWidth = 40;
            this.dgvCountry.Size = new System.Drawing.Size(782, 358);
            this.dgvCountry.TabIndex = 0;
            this.dgvCountry.DoubleClick += new System.EventHandler(this.changeCountryButton_Click);
            // 
            // manufacturerTabPage
            // 
            this.manufacturerTabPage.Controls.Add(this.emailManufacFilter);
            this.manufacturerTabPage.Controls.Add(this.nameManufacFilter);
            this.manufacturerTabPage.Controls.Add(this.phoneManufacFilter);
            this.manufacturerTabPage.Controls.Add(this.adresManufacFilter);
            this.manufacturerTabPage.Controls.Add(this.addManufacturerFilterButton);
            this.manufacturerTabPage.Controls.Add(this.removeManufacButton);
            this.manufacturerTabPage.Controls.Add(this.changeManufacButton);
            this.manufacturerTabPage.Controls.Add(this.addManufacButton);
            this.manufacturerTabPage.Controls.Add(this.dgvManufacturer);
            this.manufacturerTabPage.Location = new System.Drawing.Point(4, 30);
            this.manufacturerTabPage.Name = "manufacturerTabPage";
            this.manufacturerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.manufacturerTabPage.Size = new System.Drawing.Size(796, 414);
            this.manufacturerTabPage.TabIndex = 1;
            this.manufacturerTabPage.Text = "Производители";
            this.manufacturerTabPage.UseVisualStyleBackColor = true;
            // 
            // emailManufacFilter
            // 
            this.emailManufacFilter.Location = new System.Drawing.Point(345, 27);
            this.emailManufacFilter.Name = "emailManufacFilter";
            this.emailManufacFilter.Size = new System.Drawing.Size(100, 29);
            this.emailManufacFilter.TabIndex = 13;
            this.emailManufacFilter.Visible = false;
            this.emailManufacFilter.TextChanged += new System.EventHandler(this.manufacFilter_TextChanged);
            // 
            // nameManufacFilter
            // 
            this.nameManufacFilter.Location = new System.Drawing.Point(133, 27);
            this.nameManufacFilter.Name = "nameManufacFilter";
            this.nameManufacFilter.Size = new System.Drawing.Size(100, 29);
            this.nameManufacFilter.TabIndex = 12;
            this.nameManufacFilter.Visible = false;
            this.nameManufacFilter.TextChanged += new System.EventHandler(this.manufacFilter_TextChanged);
            // 
            // phoneManufacFilter
            // 
            this.phoneManufacFilter.Location = new System.Drawing.Point(451, 27);
            this.phoneManufacFilter.Name = "phoneManufacFilter";
            this.phoneManufacFilter.Size = new System.Drawing.Size(100, 29);
            this.phoneManufacFilter.TabIndex = 11;
            this.phoneManufacFilter.Visible = false;
            this.phoneManufacFilter.TextChanged += new System.EventHandler(this.manufacFilter_TextChanged);
            // 
            // adresManufacFilter
            // 
            this.adresManufacFilter.Location = new System.Drawing.Point(239, 27);
            this.adresManufacFilter.Name = "adresManufacFilter";
            this.adresManufacFilter.Size = new System.Drawing.Size(100, 29);
            this.adresManufacFilter.TabIndex = 10;
            this.adresManufacFilter.Visible = false;
            this.adresManufacFilter.TextChanged += new System.EventHandler(this.manufacFilter_TextChanged);
            // 
            // addManufacturerFilterButton
            // 
            this.addManufacturerFilterButton.Location = new System.Drawing.Point(8, 366);
            this.addManufacturerFilterButton.Name = "addManufacturerFilterButton";
            this.addManufacturerFilterButton.Size = new System.Drawing.Size(199, 42);
            this.addManufacturerFilterButton.TabIndex = 8;
            this.addManufacturerFilterButton.Text = "Открыть фильтры";
            this.addManufacturerFilterButton.UseVisualStyleBackColor = true;
            this.addManufacturerFilterButton.Click += new System.EventHandler(this.addManufacturerFilterButton_Click);
            // 
            // removeManufacButton
            // 
            this.removeManufacButton.Location = new System.Drawing.Point(328, 366);
            this.removeManufacButton.Name = "removeManufacButton";
            this.removeManufacButton.Size = new System.Drawing.Size(150, 42);
            this.removeManufacButton.TabIndex = 7;
            this.removeManufacButton.Text = "Удалить";
            this.removeManufacButton.UseVisualStyleBackColor = true;
            this.removeManufacButton.Click += new System.EventHandler(this.removeManufacButton_Click);
            // 
            // changeManufacButton
            // 
            this.changeManufacButton.Location = new System.Drawing.Point(484, 366);
            this.changeManufacButton.Name = "changeManufacButton";
            this.changeManufacButton.Size = new System.Drawing.Size(150, 42);
            this.changeManufacButton.TabIndex = 6;
            this.changeManufacButton.Text = "Изменить";
            this.changeManufacButton.UseVisualStyleBackColor = true;
            this.changeManufacButton.Click += new System.EventHandler(this.changeManufacButton_Click);
            // 
            // addManufacButton
            // 
            this.addManufacButton.Location = new System.Drawing.Point(640, 366);
            this.addManufacButton.Name = "addManufacButton";
            this.addManufacButton.Size = new System.Drawing.Size(150, 42);
            this.addManufacButton.TabIndex = 5;
            this.addManufacButton.Text = "Добавить";
            this.addManufacButton.UseVisualStyleBackColor = true;
            this.addManufacButton.Click += new System.EventHandler(this.addManufacButton_Click);
            // 
            // dgvManufacturer
            // 
            this.dgvManufacturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManufacturer.Location = new System.Drawing.Point(8, 6);
            this.dgvManufacturer.MultiSelect = false;
            this.dgvManufacturer.Name = "dgvManufacturer";
            this.dgvManufacturer.Size = new System.Drawing.Size(782, 358);
            this.dgvManufacturer.TabIndex = 0;
            this.dgvManufacturer.DoubleClick += new System.EventHandler(this.changeManufacButton_Click);
            // 
            // drinkTabPage
            // 
            this.drinkTabPage.Controls.Add(this.manufacDrinkFilter);
            this.drinkTabPage.Controls.Add(this.nameDrinkFilter);
            this.drinkTabPage.Controls.Add(this.countryDrinkFilter);
            this.drinkTabPage.Controls.Add(this.priceDrinkFilter);
            this.drinkTabPage.Controls.Add(this.addDrinkFilterButton);
            this.drinkTabPage.Controls.Add(this.removeDrinkButton);
            this.drinkTabPage.Controls.Add(this.changeDrinkButton);
            this.drinkTabPage.Controls.Add(this.addDrinkButton);
            this.drinkTabPage.Controls.Add(this.dgvDrink);
            this.drinkTabPage.Location = new System.Drawing.Point(4, 30);
            this.drinkTabPage.Name = "drinkTabPage";
            this.drinkTabPage.Size = new System.Drawing.Size(796, 414);
            this.drinkTabPage.TabIndex = 2;
            this.drinkTabPage.Text = "Напитки";
            this.drinkTabPage.UseVisualStyleBackColor = true;
            // 
            // manufacDrinkFilter
            // 
            this.manufacDrinkFilter.Location = new System.Drawing.Point(372, 16);
            this.manufacDrinkFilter.Name = "manufacDrinkFilter";
            this.manufacDrinkFilter.Size = new System.Drawing.Size(100, 29);
            this.manufacDrinkFilter.TabIndex = 19;
            this.manufacDrinkFilter.Visible = false;
            this.manufacDrinkFilter.TextChanged += new System.EventHandler(this.drinkFilter_TextChanged);
            // 
            // nameDrinkFilter
            // 
            this.nameDrinkFilter.Location = new System.Drawing.Point(160, 16);
            this.nameDrinkFilter.Name = "nameDrinkFilter";
            this.nameDrinkFilter.Size = new System.Drawing.Size(100, 29);
            this.nameDrinkFilter.TabIndex = 18;
            this.nameDrinkFilter.Visible = false;
            this.nameDrinkFilter.TextChanged += new System.EventHandler(this.drinkFilter_TextChanged);
            // 
            // countryDrinkFilter
            // 
            this.countryDrinkFilter.Location = new System.Drawing.Point(478, 16);
            this.countryDrinkFilter.Name = "countryDrinkFilter";
            this.countryDrinkFilter.Size = new System.Drawing.Size(100, 29);
            this.countryDrinkFilter.TabIndex = 17;
            this.countryDrinkFilter.Visible = false;
            this.countryDrinkFilter.TextChanged += new System.EventHandler(this.drinkFilter_TextChanged);
            // 
            // priceDrinkFilter
            // 
            this.priceDrinkFilter.Location = new System.Drawing.Point(266, 16);
            this.priceDrinkFilter.Name = "priceDrinkFilter";
            this.priceDrinkFilter.Size = new System.Drawing.Size(100, 29);
            this.priceDrinkFilter.TabIndex = 16;
            this.priceDrinkFilter.Visible = false;
            this.priceDrinkFilter.TextChanged += new System.EventHandler(this.drinkFilter_TextChanged);
            // 
            // addDrinkFilterButton
            // 
            this.addDrinkFilterButton.Location = new System.Drawing.Point(8, 366);
            this.addDrinkFilterButton.Name = "addDrinkFilterButton";
            this.addDrinkFilterButton.Size = new System.Drawing.Size(199, 42);
            this.addDrinkFilterButton.TabIndex = 14;
            this.addDrinkFilterButton.Text = "Открыть фильтры";
            this.addDrinkFilterButton.UseVisualStyleBackColor = true;
            this.addDrinkFilterButton.Click += new System.EventHandler(this.addDrinkFilterButton_Click);
            // 
            // removeDrinkButton
            // 
            this.removeDrinkButton.Location = new System.Drawing.Point(328, 366);
            this.removeDrinkButton.Name = "removeDrinkButton";
            this.removeDrinkButton.Size = new System.Drawing.Size(150, 42);
            this.removeDrinkButton.TabIndex = 7;
            this.removeDrinkButton.Text = "Удалить";
            this.removeDrinkButton.UseVisualStyleBackColor = true;
            this.removeDrinkButton.Click += new System.EventHandler(this.removeDrinkButton_Click);
            // 
            // changeDrinkButton
            // 
            this.changeDrinkButton.Location = new System.Drawing.Point(484, 366);
            this.changeDrinkButton.Name = "changeDrinkButton";
            this.changeDrinkButton.Size = new System.Drawing.Size(150, 42);
            this.changeDrinkButton.TabIndex = 6;
            this.changeDrinkButton.Text = "Изменить";
            this.changeDrinkButton.UseVisualStyleBackColor = true;
            this.changeDrinkButton.Click += new System.EventHandler(this.changeDrinkButton_Click);
            // 
            // addDrinkButton
            // 
            this.addDrinkButton.Location = new System.Drawing.Point(640, 366);
            this.addDrinkButton.Name = "addDrinkButton";
            this.addDrinkButton.Size = new System.Drawing.Size(150, 42);
            this.addDrinkButton.TabIndex = 5;
            this.addDrinkButton.Text = "Добавить";
            this.addDrinkButton.UseVisualStyleBackColor = true;
            this.addDrinkButton.Click += new System.EventHandler(this.addDrinkButton_Click);
            // 
            // dgvDrink
            // 
            this.dgvDrink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrink.Location = new System.Drawing.Point(8, 6);
            this.dgvDrink.MultiSelect = false;
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.Size = new System.Drawing.Size(782, 358);
            this.dgvDrink.TabIndex = 0;
            this.dgvDrink.DoubleClick += new System.EventHandler(this.changeDrinkButton_Click);
            // 
            // noteTabPage
            // 
            this.noteTabPage.Controls.Add(this.drinkNoteFilter);
            this.noteTabPage.Controls.Add(this.dateNoteFilter);
            this.noteTabPage.Controls.Add(this.addNoteFilterButton);
            this.noteTabPage.Controls.Add(this.removeNoteButton);
            this.noteTabPage.Controls.Add(this.changeNoteButton);
            this.noteTabPage.Controls.Add(this.addNoteButton);
            this.noteTabPage.Controls.Add(this.dgvNote);
            this.noteTabPage.Location = new System.Drawing.Point(4, 30);
            this.noteTabPage.Name = "noteTabPage";
            this.noteTabPage.Size = new System.Drawing.Size(796, 414);
            this.noteTabPage.TabIndex = 3;
            this.noteTabPage.Text = "Записи";
            this.noteTabPage.UseVisualStyleBackColor = true;
            // 
            // drinkNoteFilter
            // 
            this.drinkNoteFilter.Location = new System.Drawing.Point(183, 21);
            this.drinkNoteFilter.Name = "drinkNoteFilter";
            this.drinkNoteFilter.Size = new System.Drawing.Size(100, 29);
            this.drinkNoteFilter.TabIndex = 22;
            this.drinkNoteFilter.Visible = false;
            this.drinkNoteFilter.TextChanged += new System.EventHandler(this.noteFilter_TextChanged);
            // 
            // dateNoteFilter
            // 
            this.dateNoteFilter.Location = new System.Drawing.Point(289, 21);
            this.dateNoteFilter.Name = "dateNoteFilter";
            this.dateNoteFilter.Size = new System.Drawing.Size(100, 29);
            this.dateNoteFilter.TabIndex = 21;
            this.dateNoteFilter.Visible = false;
            this.dateNoteFilter.TextChanged += new System.EventHandler(this.noteFilter_TextChanged);
            // 
            // addNoteFilterButton
            // 
            this.addNoteFilterButton.Location = new System.Drawing.Point(8, 366);
            this.addNoteFilterButton.Name = "addNoteFilterButton";
            this.addNoteFilterButton.Size = new System.Drawing.Size(199, 42);
            this.addNoteFilterButton.TabIndex = 19;
            this.addNoteFilterButton.Text = "Открыть фильтры";
            this.addNoteFilterButton.UseVisualStyleBackColor = true;
            this.addNoteFilterButton.Click += new System.EventHandler(this.addNoteFilterButton_Click);
            // 
            // removeNoteButton
            // 
            this.removeNoteButton.Location = new System.Drawing.Point(328, 366);
            this.removeNoteButton.Name = "removeNoteButton";
            this.removeNoteButton.Size = new System.Drawing.Size(150, 42);
            this.removeNoteButton.TabIndex = 7;
            this.removeNoteButton.Text = "Удалить";
            this.removeNoteButton.UseVisualStyleBackColor = true;
            this.removeNoteButton.Click += new System.EventHandler(this.removeNoteButton_Click);
            // 
            // changeNoteButton
            // 
            this.changeNoteButton.Location = new System.Drawing.Point(484, 366);
            this.changeNoteButton.Name = "changeNoteButton";
            this.changeNoteButton.Size = new System.Drawing.Size(150, 42);
            this.changeNoteButton.TabIndex = 6;
            this.changeNoteButton.Text = "Изменить";
            this.changeNoteButton.UseVisualStyleBackColor = true;
            this.changeNoteButton.Click += new System.EventHandler(this.changeNoteButton_Click);
            // 
            // addNoteButton
            // 
            this.addNoteButton.Location = new System.Drawing.Point(640, 366);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(150, 42);
            this.addNoteButton.TabIndex = 5;
            this.addNoteButton.Text = "Добавить";
            this.addNoteButton.UseVisualStyleBackColor = true;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // dgvNote
            // 
            this.dgvNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNote.Location = new System.Drawing.Point(8, 6);
            this.dgvNote.MultiSelect = false;
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.Size = new System.Drawing.Size(782, 358);
            this.dgvNote.TabIndex = 0;
            this.dgvNote.DoubleClick += new System.EventHandler(this.changeNoteButton_Click);
            // 
            // TablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "TablesForm";
            this.Text = "Таблицы";
            this.tabControl1.ResumeLayout(false);
            this.countryTabPage.ResumeLayout(false);
            this.countryTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            this.manufacturerTabPage.ResumeLayout(false);
            this.manufacturerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManufacturer)).EndInit();
            this.drinkTabPage.ResumeLayout(false);
            this.drinkTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            this.noteTabPage.ResumeLayout(false);
            this.noteTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage countryTabPage;
        private System.Windows.Forms.TabPage manufacturerTabPage;
        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.TabPage drinkTabPage;
        private System.Windows.Forms.TabPage noteTabPage;
        private System.Windows.Forms.DataGridView dgvManufacturer;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.DataGridView dgvNote;
        private System.Windows.Forms.Button removeCountryButton;
        private System.Windows.Forms.Button changeCountryButton;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.Button removeManufacButton;
        private System.Windows.Forms.Button changeManufacButton;
        private System.Windows.Forms.Button addManufacButton;
        private System.Windows.Forms.Button removeDrinkButton;
        private System.Windows.Forms.Button changeDrinkButton;
        private System.Windows.Forms.Button addDrinkButton;
        private System.Windows.Forms.Button removeNoteButton;
        private System.Windows.Forms.Button changeNoteButton;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.TextBox nameCountryFilter;
        private System.Windows.Forms.Button addCountryFilterButton;
        private System.Windows.Forms.Button addManufacturerFilterButton;
        private System.Windows.Forms.TextBox nameManufacFilter;
        private System.Windows.Forms.TextBox phoneManufacFilter;
        private System.Windows.Forms.TextBox adresManufacFilter;
        private System.Windows.Forms.TextBox emailManufacFilter;
        private System.Windows.Forms.TextBox manufacDrinkFilter;
        private System.Windows.Forms.TextBox nameDrinkFilter;
        private System.Windows.Forms.TextBox countryDrinkFilter;
        private System.Windows.Forms.TextBox priceDrinkFilter;
        private System.Windows.Forms.Button addDrinkFilterButton;
        private System.Windows.Forms.TextBox drinkNoteFilter;
        private System.Windows.Forms.TextBox dateNoteFilter;
        private System.Windows.Forms.Button addNoteFilterButton;
    }
}