using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
	public partial class MainForm : Form
	{
		public MainForm(string login)
		{
			InitializeComponent();
			loginToolStrip.Text = login;
			Fill();
			
		}
		private void NameColumns() 
		{
			dgvMain.Columns[0].HeaderText = "Название напитка";
			dgvMain.Columns[1].HeaderText = "Название производителя";
			dgvMain.Columns[2].HeaderText = "Страна поставщик сырья";
			dgvMain.Columns[3].HeaderText = "Дата добавления записи";

			dgvMain.Columns[0].Width = 200;
			dgvMain.Columns[1].Width = 220;
			dgvMain.Columns[2].Width = 220;
			dgvMain.Columns[3].Width = 210;
		}
		private void Fill()
		{
			dgvMain.DataSource = (from n in DbConnect.Entities.Note
								  join d in DbConnect.Entities.Drink on n.DrinkID equals d.DrinkID
								  join m in DbConnect.Entities.Manufacturer on d.ManufacturerID equals m.ManufacturerID
								  join c in DbConnect.Entities.Country on d.CountryID equals c.CountryID
								  orderby d.Name
								  select new { d.Name, ManufacName = m.Name, CountryName = c.Name, n.AddedDate }).ToList();
			NameColumns();
		}

		private void changeUserToolStripMeniItem_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void openTablesButton_Click(object sender, EventArgs e)
        {
			TablesForm f = new TablesForm();
			f.ShowDialog();
			Fill();
        }
    }
}
