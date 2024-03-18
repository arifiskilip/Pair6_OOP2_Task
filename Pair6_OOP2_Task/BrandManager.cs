namespace Pair6_OOP2_Task
{
	public class BrandManager : GenericRepository<Brand, ILog>
	{
		public BrandManager(ILog log) : base(log)
		{
		}
	}
}

public class Brand
{
    public int  Id { get; set; }
}
