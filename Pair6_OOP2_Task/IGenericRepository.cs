namespace Pair6_OOP2_Task;

public interface IGenericRepository<TUser>
{
	void GetById(int id);
	void Create(TUser user);
	void Update(TUser user);
	void Delete(int id);
}
