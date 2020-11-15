using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddManufacForm : Form
    {
        private Manufacturer manufacturer;
        public AddManufacForm(int id)
        {
            InitializeComponent();
            if (id < 0)
            {
                this.manufacturer = new Manufacturer();
                this.changeButton.Enabled = false;
            }
            else
            {
                this.Text = "Изменение производителя";
                this.manufacturer = DbConnect.Entities.Manufacturer.Find(id);
                this.addButton.Enabled = false;
                this.nameTextBox.Text = this.manufacturer.Name;
                this.adresTextBox.Text = this.manufacturer.Adres;
                this.emailTextBox.Text = this.manufacturer.Email;
                this.phoneTextBox.Text = this.manufacturer.Phone;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.manufacturer.Name = this.nameTextBox.Text;
            this.manufacturer.Adres = this.adresTextBox.Text;
            this.manufacturer.Email = this.emailTextBox.Text;
            this.manufacturer.Phone = this.phoneTextBox.Text;
            DbConnect.Entities.Manufacturer.Add(this.manufacturer);
            DbConnect.Entities.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.manufacturer.Name = this.nameTextBox.Text;
            this.manufacturer.Adres = this.adresTextBox.Text;
            this.manufacturer.Email = this.emailTextBox.Text;
            this.manufacturer.Phone = this.phoneTextBox.Text;
            DbConnect.Entities.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
