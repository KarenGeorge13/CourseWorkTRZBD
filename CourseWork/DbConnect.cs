using System;

namespace CourseWork
{
	public static class DbConnect
	{
		public static DirectoryEntities Entities = new DirectoryEntities();
		public static void UpdateContext(string connectionString) 
		{
			Entities = new DirectoryEntities(connectionString);
		}
	}
}
