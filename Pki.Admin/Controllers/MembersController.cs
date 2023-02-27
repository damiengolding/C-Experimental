using Microsoft.AspNetCore.Mvc;
using Pki.Admin.Models;

namespace Pki.Admin.Controllers
{
	public class MembersController : Controller
	{
		public List<MemberModel> Members { get; set; }

		private MemberModel? _memberModel;
		public MemberModel memberModel
		{
			get { return _memberModel; }
			set { _memberModel = value; }
		}

		public MembersController()
		{
			Members = GetSampleMembers();
		}

		private List<MemberModel>? GetSampleMembers()
		{
			return new List<MemberModel>() {
				new MemberModel("Alice","Alisson",true,1),
				new MemberModel("Bob","Robertson",true,2),
				new MemberModel("Chas","Charleson",false,3),
				new MemberModel("Fred","Fredericsdauter",true,4),
				new MemberModel("George","Georgeson",true,5)
			};
		}

		public IActionResult Index()
		{
			return View(Members);
		}
	}
}
