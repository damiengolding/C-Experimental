using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace Pki.Admin.Data
{
	public class MemberContext :DbContext
	{
		public DbSet<Member> Members => Set< Member >();

		private string dbPath = string.Empty;

		public string DbPath
		{
			get { return dbPath; }
			set { dbPath = value; }
		}

		public MemberContext()
		{
			var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			dbPath = Path.Join(path, "pki.db");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseSqlite($"Data source={dbPath}");

	}
}
