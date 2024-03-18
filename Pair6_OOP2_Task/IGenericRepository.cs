namespace Pair6_OOP2_Task;

public interface IGenericRepository<TEntity>
{
	void GetById(int id);
	void Create(TEntity entity);
	void Update(TEntity entity);
	void Delete(int id);
}
