namespace Models
{
	public abstract class BaseEntity : object
	{
		public BaseEntity() : base()
		{
            
		}

		// **********
		public string Id { get; set; }
		// **********
	}
}
