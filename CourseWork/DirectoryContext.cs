using System.Data.Entity;

namespace CourseWork
{
	public class DirectoryEntities : DbContext
	{
		public DirectoryEntities() : base("name=CourseWorkEntities1")
        {
        }
        public DirectoryEntities(string connectionString) : base(connectionString)
		{
		}
		public virtual DbSet<Country> Country { get; set; }
		public virtual DbSet<Drink> Drink { get; set; }
		public virtual DbSet<Manufacturer> Manufacturer { get; set; }
		public virtual DbSet<Note> Note { get; set; }
	}
}
