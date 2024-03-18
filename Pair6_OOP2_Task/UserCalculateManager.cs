namespace Pair6_OOP2_Task
{
	public class UserCalculateManager : Calculate
	{
		public override string NumberOfUserGenders(List<User> users)
		{
			return base.NumberOfUserGenders(users);
		}

		// Or

		//public override string NumberOfUserGenders(List<User> users)
		//{
		//	int numberOfMans = users.Count(x => x.Gender == GenderType.Man);
		//	int numberOfWomens = 0;
		//	return $"Number of mans = {numberOfMans}\nNumber of womens= {numberOfWomens}";
		//}
	}
}
