using System;
using System.Windows.Forms;

namespace CourseWork
{
	public partial class AuthorizationForm : Form
	{
		public AuthorizationForm()
		{
			InitializeComponent();
			
		}

		private void buttonAuthorization_Click(object sender, EventArgs e)
		{
			string connectionString = $"metadata=res://*/DirectoryOfTeaAndCoffee.csdl|" +
				$"res://*/DirectoryOfTeaAndCoffee.ssdl|" +
				$"res://*/DirectoryOfTeaAndCoffee.msl;" +
				$"provider=System.Data.SqlClient;" +
				$"provider connection string=\"data source=DESKTOP-N3477KM" +
				$";initial catalog=CourseWork;persist security info=True" +
				$";user id={textBoxLogin.Text};password={textBoxPassword.Text};" +
				$"MultipleActiveResultSets=True;App=EntityFramework\"";
			DbConnect.UpdateContext(connectionString);
			try
			{
				MainForm f = new MainForm(textBoxLogin.Text);
				this.Visible = false;
				if (f.ShowDialog() == DialogResult.OK)
					this.Visible = true;
				else
					this.Close();
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Похоже вы ввели неверные данные");
			}
			
		}

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				buttonAuthorization_Click(sender, e);
			}
		}
    }
}
