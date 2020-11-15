using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
	public partial class TablesForm : Form
	{
		public TablesForm()
		{
			InitializeComponent();
			
			FillCountry();
			FillManufacturer();
			FillDrink();
			FillNote();
		}
		//Работа с таблицей Country
		private void CountryFilter() 
		{
			nameCountryFilter.Visible = true;
			nameCountryFilter.Location = new Point(dgvCountry.Location.X + dgvCountry.RowHeadersWidth + 1, 6);
			nameCountryFilter.Width = dgvCountry.Columns[1].Width - 2;
		}
		private void FillCountry() 
		{
			dgvCountry.DataSource = (from c in DbConnect.Entities.Country
									 select new { c.CountryID, c.Name}).ToList();
			NameColumnsCountry();
		}
		private void NameColumnsCountry() 
		{
			dgvCountry.Columns[0].Visible = false;
			dgvCountry.Columns[1].HeaderText = "Название страны";
		}
		private void addCountryButton_Click(object sender, EventArgs e)
		{
			try
			{
				AddCountryForm f = new AddCountryForm(-1);
				if (f.ShowDialog() == DialogResult.OK)
				{
					FillCountry();
				}
			}
			catch (Exception ex) 
			{
				MessageBox.Show("У вас нет прав на проведение этой операции");
			}
		}
		private void changeCountryButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)dgvCountry.Rows[dgvCountry.CurrentRow.Index].Cells[0].Value;
				AddCountryForm f = new AddCountryForm(id);
				if (f.ShowDialog() == DialogResult.OK)
				{
					FillCountry();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("У вас нет прав на проведение этой операции");
			}
		}
		private void removeCountryButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)dgvCountry.Rows[dgvCountry.CurrentRow.Index].Cells[0].Value;
				DbConnect.Entities.Country.Remove(DbConnect.Entities.Country.Find(id));
				DbConnect.Entities.SaveChanges();
				FillCountry();
				FillDrink();
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Удалить данные не получилось");
            }
		}
		private void addCountryFilterButton_Click(object sender, EventArgs e)
		{
			if (addCountryFilterButton.Text == "Открыть фильтры")
			{
				CountryFilter();
				dgvCountry.Location = new Point(8, 41);
				dgvCountry.Size = new Size(782, 323);
				addCountryFilterButton.Text = "Скрыть фильтры";
			}
			else
			{
				nameCountryFilter.Visible = false;
				dgvCountry.Location = new Point(8, 6);
				dgvCountry.Size = new Size(782, 358);
				addCountryFilterButton.Text = "Открыть фильтры";
			}
		}
		private void nameFilterTextBox_TextChanged(object sender, EventArgs e)
		{
			var ds = (from c in DbConnect.Entities.Country
					  where c.Name.ToString().Contains(nameCountryFilter.Text)
					  select new { c.CountryID, c.Name }).ToList();
			dgvCountry.DataSource = ds;
			CountryFilter();
		}

		//Работа с таблицей Manufacturer
		private void ManufacturerFilter() 
		{
			nameManufacFilter.Visible = true;
			nameManufacFilter.Location = new Point(dgvCountry.Location.X + dgvCountry.RowHeadersWidth + 1, 6);
			nameManufacFilter.Width = dgvManufacturer.Columns[1].Width - 2;

			adresManufacFilter.Visible = true;
			adresManufacFilter.Location = new Point(nameManufacFilter.Location.X + dgvManufacturer.Columns[1].Width + 1, 6);
			adresManufacFilter.Width = 185 - 2;

			emailManufacFilter.Visible = true;
			emailManufacFilter.Location = new Point(adresManufacFilter.Location.X + 185 + 1, 6);
			emailManufacFilter.Width = 185 - 2;

			phoneManufacFilter.Visible = true;
			phoneManufacFilter.Location = new Point(emailManufacFilter.Location.X + 185 + 1, 6);
			phoneManufacFilter.Width = 185 - 2;
		}
		private void FillManufacturer() 
		{
			dgvManufacturer.DataSource = (from m in DbConnect.Entities.Manufacturer
										  select new { m.ManufacturerID, m.Name, m.Adres, m.Email, m.Phone }).ToList();
			NameColumnsManufacturer();
		}
		private void NameColumnsManufacturer() 
		{
			dgvManufacturer.Columns[0].Visible = false;
			dgvManufacturer.Columns[1].HeaderText = "Название компании";
			dgvManufacturer.Columns[2].HeaderText = "Юридический адрес";
			dgvManufacturer.Columns[3].HeaderText = "E-mail";
			dgvManufacturer.Columns[4].HeaderText = "Телефон";
		}
		private void addManufacButton_Click(object sender, EventArgs e)
		{
			try
			{
				AddManufacForm f = new AddManufacForm(-1);
				if (f.ShowDialog() == DialogResult.OK)
				{
					FillManufacturer();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("У вас нет прав на проведение этой операции");
			}
		}
		private void changeManufacButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)dgvManufacturer.Rows[dgvManufacturer.CurrentRow.Index].Cells[0].Value;
				AddManufacForm f = new AddManufacForm(id);
				if (f.ShowDialog() == DialogResult.OK)
				{
					FillManufacturer();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("У вас нет прав на проведение этой операции");
			}
		}
		private void removeManufacButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)dgvManufacturer.Rows[dgvManufacturer.CurrentRow.Index].Cells[0].Value;
				DbConnect.Entities.Manufacturer.Remove(DbConnect.Entities.Manufacturer.Find(id));
				DbConnect.Entities.SaveChanges();
				FillManufacturer();
				FillDrink();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Удалить данные не получилось");
			}
		}
		private void addManufacturerFilterButton_Click(object sender, EventArgs e)
		{
			if (addManufacturerFilterButton.Text == "Открыть фильтры")
			{
				ManufacturerFilter();
				dgvManufacturer.Location = new Point(8, 41);
				dgvManufacturer.Size = new Size(782, 323);
				addManufacturerFilterButton.Text = "Скрыть фильтры";
			}
			else
			{
				nameManufacFilter.Visible = false;
				adresManufacFilter.Visible = false;
				emailManufacFilter.Visible = false;
				phoneManufacFilter.Visible = false;
				dgvManufacturer.Location = new Point(8, 6);
				dgvManufacturer.Size = new Size(782, 358);
				addManufacturerFilterButton.Text = "Открыть фильтры";
			}
		}
		private void manufacFilter_TextChanged(object sender, EventArgs e)
		{
			var ds = (from m in DbConnect.Entities.Manufacturer
					  where m.Name.ToString().Contains(nameManufacFilter.Text) &
							m.Adres.ToString().Contains(adresManufacFilter.Text) &
							m.Email.ToString().Contains(emailManufacFilter.Text) &
							m.Phone.ToString().Contains(phoneManufacFilter.Text)
					  select new { m.ManufacturerID, m.Name, m.Adres, m.Email, m.Phone }).ToList();
			dgvManufacturer.DataSource = ds;
			ManufacturerFilter();
		}
		//Работа с таблицей Drink
		private void DrinkFilter()
		{
			nameDrinkFilter.Visible = true;
			nameDrinkFilter.Location = new Point(dgvDrink.Location.X + dgvDrink.RowHeadersWidth + 1, 6);
			nameDrinkFilter.Width = dgvDrink.Columns[1].Width - 2;

			priceDrinkFilter.Visible = true;
			priceDrinkFilter.Location = new Point(nameDrinkFilter.Location.X + dgvDrink.Columns[1].Width + 1, 6);
			priceDrinkFilter.Width = dgvDrink.Columns[2].Width - 2;

			manufacDrinkFilter.Visible = true;
			manufacDrinkFilter.Location = new Point(priceDrinkFilter.Location.X + dgvDrink.Columns[2].Width + 1, 6);
			manufacDrinkFilter.Width = dgvDrink.Columns[3].Width - 2;

			countryDrinkFilter.Visible = true;
			countryDrinkFilter.Location = new Point(manufacDrinkFilter.Location.X + dgvDrink.Columns[3].Width + 1, 6);
			countryDrinkFilter.Width = dgvDrink.Columns[4].Width - 2;
		}
		private void FillDrink() 
		{
			dgvDrink.DataSource = (from d in DbConnect.Entities.Drink
								   join m in DbConnect.Entities.Manufacturer on d.ManufacturerID equals m.ManufacturerID
								   join c in DbConnect.Entities.Country on d.CountryID equals c.CountryID
								   select new { d.DrinkID, d.Name, d.PricePerKilo, ManufactureerName = m.Name, CountryName = c.Name}).ToList();
			NameColumnsDrink();
		}
		private void NameColumnsDrink() 
		{
			dgvDrink.Columns[0].Visible = false;
			dgvDrink.Columns[1].HeaderText = "Название напитка";
			dgvDrink.Columns[2].HeaderText = "Цена за килограмм";
			dgvDrink.Columns[3].HeaderText = "Производитель";
			dgvDrink.Columns[4].HeaderText = "Страна";
		}
		private void addDrinkButton_Click(object sender, EventArgs e)
		{
			try
			{
				AddDrinkForm f = new AddDrinkForm(-1);
				if (f.ShowDialog() == DialogResult.OK)
				{
					FillDrink();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("У вас нет прав на проведение этой операции");
			}
		}
		private void changeDrinkButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)dgvDrink.Rows[dgvDrink.CurrentRow.Index].Cells[0].Value;
				AddDrinkForm f = new AddDrinkForm(id);
				if (f.ShowDialog() == DialogResult.OK)
				{
					FillDrink();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("У вас нет прав на проведение этой операции");
			}
		}
		private void removeDrinkButton_Click(object sender, EventArgs e)
		{
			try
			{
				int id = (int)dgvDrink.Rows[dgvDrink.CurrentRow.Index].Cells[0].Value;
				DbConnect.Entities.Drink.Remove(DbConnect.Entities.Drink.Find(id));
				DbConnect.Entities.SaveChanges();
				FillDrink();
				FillNote();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Удалить данные не получилось");
			}
		}
		private void addDrinkFilterButton_Click(object sender, EventArgs e)
		{
			if (addDrinkFilterButton.Text == "Открыть фильтры")
			{
				DrinkFilter();
				dgvDrink.Location = new Point(8, 41);
				dgvDrink.Size = new Size(782, 323);
				addDrinkFilterButton.Text = "Скрыть фильтры";
			}
			else
			{
				nameDrinkFilter.Visible = false;
				priceDrinkFilter.Visible = false;
				manufacDrinkFilter.Visible = false;
				countryDrinkFilter.Visible = false;
				dgvDrink.Location = new Point(8, 6);
				dgvDrink.Size = new Size(782, 358);
				addDrinkFilterButton.Text = "Открыть фильтры";
			}
		}
		private void drinkFilter_TextChanged(object sender, EventArgs e)
		{

			var ds = (from d in DbConnect.Entities.Drink
					  join m in DbConnect.Entities.Manufacturer on d.ManufacturerID equals m.ManufacturerID
					  join c in DbConnect.Entities.Country on d.CountryID equals c.CountryID
					  where d.Name.ToString().Contains(nameDrinkFilter.Text) &
							d.PricePerKilo.ToString().Contains(priceDrinkFilter.Text) &
							m.Name.ToString().Contains(manufacDrinkFilter.Text) &
							c.Name.ToString().Contains(countryDrinkFilter.Text)
					  select new { d.DrinkID, d.Name, d.PricePerKilo, ManufactureerName = m.Name, CountryName = c.Name }).ToList();
			

			dgvDrink.DataSource = ds;
			DrinkFilter();
		}

		//Работа с таблицей Note
		private void NoteFilter() 
		{
			drinkNoteFilter.Visible = true;
			drinkNoteFilter.Location = new Point(dgvNote.Location.X + dgvNote.RowHeadersWidth + 1, 6);
			drinkNoteFilter.Width = dgvNote.Columns[1].Width - 2;

			dateNoteFilter.Visible = true;
			dateNoteFilter.Location = new Point(drinkNoteFilter.Location.X + dgvNote.Columns[1].Width + 1, 6);
			dateNoteFilter.Width = dgvNote.Columns[2].Width - 2;
		}
		private void FillNote() 
		{
			dgvNote.DataSource = (from n in DbConnect.Entities.Note
								  join d in DbConnect.Entities.Drink on n.DrinkID equals d.DrinkID
								  select new { n.NoteID, d.Name, n.AddedDate, n.TasteDescription }).ToList();
			NameColumnsNote();
		}
		private void NameColumnsNote()
		{
			dgvNote.Columns[0].Visible = false;
			dgvNote.Columns[1].HeaderText = "Напиток";
			dgvNote.Columns[2].HeaderText = "Дата добавления записи";
			dgvNote.Columns[3].HeaderText = "Описание вкуса";
		}
        private void addNoteButton_Click(object sender, EventArgs e)
        {
			try
			{
				AddNoteForm f = new AddNoteForm(-1);
				if (f.ShowDialog() == DialogResult.OK)
				{
					FillNote();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("У вас нет прав на проведение этой операции");
			}
		}
        private void changeNoteButton_Click(object sender, EventArgs e)
        {
			try
			{
				int id = (int)dgvNote.Rows[dgvNote.CurrentRow.Index].Cells[0].Value;
				AddNoteForm f = new AddNoteForm(id);
				if (f.ShowDialog() == DialogResult.OK)
				{
					FillNote();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("У вас нет прав на проведение этой операции");
			}
		}
        private void removeNoteButton_Click(object sender, EventArgs e)
        {
			try
			{
				int id = (int)dgvNote.Rows[dgvNote.CurrentRow.Index].Cells[0].Value;
				DbConnect.Entities.Note.Remove(DbConnect.Entities.Note.Find(id));
				DbConnect.Entities.SaveChanges();
				FillNote();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Удалить данные не получилось");
			}
		}
        private void addNoteFilterButton_Click(object sender, EventArgs e)
        {
			if (addNoteFilterButton.Text == "Открыть фильтры")
			{
				NoteFilter();
				dgvNote.Location = new Point(8, 41);
				dgvNote.Size = new Size(782, 323);
				addNoteFilterButton.Text = "Скрыть фильтры";
			}
			else
			{
				drinkNoteFilter.Visible = false;
				dateNoteFilter.Visible = false;
				dgvNote.Location = new Point(8, 6);
				dgvNote.Size = new Size(782, 358);
				addNoteFilterButton.Text = "Открыть фильтры";
			}
		}
		private void noteFilter_TextChanged(object sender, EventArgs e)
		{
			var ds = (from n in DbConnect.Entities.Note
					  join d in DbConnect.Entities.Drink on n.DrinkID equals d.DrinkID
					  where d.Name.ToString().Contains(drinkNoteFilter.Text) &
							n.AddedDate.ToString().Contains(dateNoteFilter.Text)
					  select new { n.NoteID, d.Name, n.AddedDate, n.TasteDescription }).ToList();
			dgvNote.DataSource = ds;
		}
	}
}