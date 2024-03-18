namespace Pair6_OOP2_Task
{
	public class UserManager : GenericRepository<User, FileLog>
	{
		public UserManager(FileLog log) : base(log)
		{
		}
	}
}
