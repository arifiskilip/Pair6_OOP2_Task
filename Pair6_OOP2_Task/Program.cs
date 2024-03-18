using Pair6_OOP2_Task;

User manUser = new()
{
	Id = 1,
	Gender = GenderType.Man,
	Status = true,
	FirstName = "Arif"
};

User womenUser = new()
{
	Id = 2,
	Gender = GenderType.Women,
	Status = true,
	FirstName = "Gamze"
};

List<User> users = new()
{
	new()
	{
		Gender=GenderType.Man,
		Id=2,
		Status=false,
	    FirstName="Ahmet",
	},
	manUser,
	womenUser
};

Console.WriteLine(womenUser.FirstName);

UserManager userManager = new(new DataBaseLog());
userManager.Delete(manUser.Id);

BrandManager brandManager = new BrandManager(new FileLog());
brandManager.Create(new Brand() { Id = 1 });

UserCalculateManager userCalculateManager = new();
Console.WriteLine(userCalculateManager.NumberOfUserGenders(users));




