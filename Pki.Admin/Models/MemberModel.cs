namespace Pki.Admin.Models
{
	public class MemberModel
	{
		public MemberModel(string fName, string lName, bool active = true, int id = -1)
		{
			FirstName = fName;
			LastName = lName;
			IsActive = active;
			Id = id;
		}
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
