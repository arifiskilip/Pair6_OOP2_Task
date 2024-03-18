namespace Pair6_OOP2_Task
{
	public class Calculate
	{
		public virtual string NumberOfUserGenders(List<User> users)
		{
			int numberOfMans = users.Count(x => x.Gender == GenderType.Man);
			int numberOfWomens = users.Count(x => x.Gender == GenderType.Women);
			return $"Number of mans = {numberOfMans}\nNumber of womens= {numberOfWomens}";
		}
	}
}
