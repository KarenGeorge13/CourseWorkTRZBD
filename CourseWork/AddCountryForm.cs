using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddCountryForm : Form
    {
        private Country country;
        public AddCountryForm(int id)
        {
            InitializeComponent();
            if (id < 0)
            {
                this.country = new Country();
                this.changeButton.Enabled = false;
            }
            else 
            {
                this.Text = "Изменение страны";
                this.country = DbConnect.Entities.Country.Find(id);
                this.addButton.Enabled = false;
                this.nameTextBox.Text = this.country.Name;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.country.Name = this.nameTextBox.Text;
            DbConnect.Entities.Country.Add(this.country);
            DbConnect.Entities.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.country.Name = nameTextBox.Text;
            DbConnect.Entities.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
