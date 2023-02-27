namespace Pki.Admin.Data
{
	public class Member
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsActive { get; set; }
		public int Id { get; set; } = -1;
		public override int GetHashCode()
		{
			return (Tuple.Create(FirstName, LastName).GetHashCode());
		}
	}
}
