namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}

		public System.Data.Entity.DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<Doctors> Doctor { get; set; }

        public System.Data.Entity.DbSet<Reservations> Reservation { get; set; }

        public System.Data.Entity.DbSet<Patients> Patient { get; set; }
	}
}
