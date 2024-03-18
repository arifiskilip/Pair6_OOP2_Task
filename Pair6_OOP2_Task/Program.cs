using Pair6_OOP2_Task;

User manUser = new()
{
	Id = 1,
	FirstName = "Arif",
	Gender = GenderType.Man,
	Status = true
};

User womenUser = new()
{
	Id = 2,
	FirstName = "Gamze",
	Gender = GenderType.Women,
	Status = true
};


UserManager userManager = new(new FileLog());
userManager.Create(manUser);
UserCalculateManager userCalculateManager = new();
Console.WriteLine(userCalculateManager.NumberOfUserGenders(new() { manUser, womenUser })); 


