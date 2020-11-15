using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddDrinkForm : Form
    {
        private Drink drink;
        public AddDrinkForm(int id)
        {
            InitializeComponent();
            Fill();
            if (id < 0)
            {
                this.drink = new Drink();
                this.changeButton.Enabled = false;
            }
            else
            {
                this.Text = "Изменение напитка";
                this.drink = DbConnect.Entities.Drink.Find(id);
                this.addButton.Enabled = false;
                this.nameTextBox.Text = this.drink.Name;
                this.priceNumericUpDown.Value = this.drink.PricePerKilo;
                this.manufacturerComboBox.SelectedItem = DbConnect.Entities.Manufacturer.Find(this.drink.ManufacturerID).Name;
                this.countryComboBox.SelectedItem = DbConnect.Entities.Country.Find(this.drink.CountryID).Name;
            }
            
        }
        private void Fill()
        {
            manufacturerComboBox.DataSource = (from m in DbConnect.Entities.Manufacturer
                                               select m.Name).ToList();
            countryComboBox.DataSource = (from c in DbConnect.Entities.Country
                                               select c.Name).ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.drink.Name = this.nameTextBox.Text; 
            this.drink.PricePerKilo = this.priceNumericUpDown.Value;
            this.drink.ManufacturerID = (from m in DbConnect.Entities.Manufacturer
                                         where m.Name == manufacturerComboBox.SelectedItem.ToString()
                                         select m.ManufacturerID).ToList().FirstOrDefault();
            this.drink.CountryID = (from c in DbConnect.Entities.Country
                                    where c.Name == countryComboBox.SelectedItem.ToString()
                                    select c.CountryID).ToList().FirstOrDefault();
            DbConnect.Entities.SaveChanges();
            DbConnect.Entities.Drink.Add(this.drink);
            DbConnect.Entities.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.drink.Name = this.nameTextBox.Text;
            this.drink.PricePerKilo = this.priceNumericUpDown.Value;
            this.drink.ManufacturerID = (from m in DbConnect.Entities.Manufacturer
                                         where m.Name == manufacturerComboBox.SelectedItem.ToString()
                                         select m.ManufacturerID).ToList().FirstOrDefault();
            this.drink.CountryID = (from c in DbConnect.Entities.Country
                                    where c.Name == countryComboBox.SelectedItem.ToString()
                                    select c.CountryID).ToList().FirstOrDefault();
            DbConnect.Entities.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
