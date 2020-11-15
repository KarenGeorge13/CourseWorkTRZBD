using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{   
    public partial class AddNoteForm : Form
    {
        private Note note;
        private bool flag = false;
        public AddNoteForm(int id)
        {
            InitializeComponent();
            Fill(id);
            if (id < 0)
            {
                this.note = new Note();
                this.changeButton.Enabled = false;
            }
            else
            {
                this.Text = "Изменение записи";
                this.note = DbConnect.Entities.Note.Find(id);
                this.addButton.Enabled = false;
                this.drinkComboBox.SelectedItem = DbConnect.Entities.Drink.Find(this.note.DrinkID);
                this.descTextBox.Text = this.note.TasteDescription;
                this.dateTimePicker1.Value = this.note.AddedDate;
            }
        }

        private void Fill(int id) 
        {
            
            var col1 = (from d in DbConnect.Entities.Drink
                        select d.DrinkID).ToList();
            var col2 = (from n in DbConnect.Entities.Note
                        select n.DrinkID).ToList();
            foreach (var item in col2) 
            {
                col1.Remove(item);
            }
            if (col1.Count == 0 && id < 0) 
            {
                MessageBox.Show("Сделаны записи обо всех напитках");
                flag = true;
                return;
            }
            if (id >= 0)
            {
                col1.Add(DbConnect.Entities.Note.Find(id).DrinkID);
            }
            var ds = (from d in DbConnect.Entities.Drink
                      where col1.Contains(d.DrinkID)
                      select d.Name).ToList();
            drinkComboBox.DataSource = ds; 
           
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            this.note.DrinkID = (from d in DbConnect.Entities.Drink
                                 where d.Name == drinkComboBox.SelectedItem.ToString()
                                 select d.DrinkID).ToList().FirstOrDefault();
            this.note.TasteDescription = this.descTextBox.Text;
            this.note.AddedDate = this.dateTimePicker1.Value;
            DbConnect.Entities.Note.Add(this.note);
            DbConnect.Entities.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.note.DrinkID = (from d in DbConnect.Entities.Drink
                                 where d.Name == drinkComboBox.SelectedItem.ToString()
                                 select d.DrinkID).ToList().FirstOrDefault();
            this.note.TasteDescription = this.descTextBox.Text;
            this.note.AddedDate = this.dateTimePicker1.Value;
            DbConnect.Entities.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddNoteForm_Load(object sender, EventArgs e)
        {
            if(flag) 
                this.Close();
        }
    }
}
