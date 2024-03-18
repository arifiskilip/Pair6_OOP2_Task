namespace Pair6_OOP2_Task
{
	public class GenericRepository<TEntity,TLog> : IGenericRepository<TEntity>
		where TLog : ILog
	{
		private TLog logType;

		public GenericRepository(TLog log)
		{
			this.logType = log;
		}

		public void Create(TEntity entity)
		{
            Console.WriteLine("Created!");
			logType.Log();
        }

		public void Delete(int id)
		{
			Console.WriteLine("Deleted!");
			logType.Log();
		}

		public void GetById(int id)
		{
			Console.WriteLine("Listed!");
			logType.Log();
		}

		public void Update(TEntity entity)
		{
			Console.WriteLine("Updated!");
			logType.Log();
		}
	}
}
