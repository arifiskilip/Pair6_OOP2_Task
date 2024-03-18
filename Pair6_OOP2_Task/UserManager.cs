namespace Pair6_OOP2_Task
{
	public class UserManager : GenericRepository<User, ILog>
	{
		public UserManager(ILog log) : base(log)
		{
		}
	}
}
