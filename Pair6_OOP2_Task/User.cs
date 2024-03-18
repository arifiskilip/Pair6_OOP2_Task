namespace Pair6_OOP2_Task;

public class User : BaseEntity 
{
	private string _firstName;

	public GenderType Gender { get; set; }

	public string FirstName
	{
		get
		{
			return _firstName;
		}
		set
		{
			if (Gender == GenderType.Man)
			{
				_firstName = "Mr. " + value;
			}
			else
			{
				_firstName = "Ms. " + value;
			}
		}
	}
}

public enum GenderType
{
	Man = 0,
	Women = 1,
}
