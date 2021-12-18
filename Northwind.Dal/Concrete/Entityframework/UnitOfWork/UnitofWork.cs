using Northwind.Dal.Abstract;

namespace Northwind.Dal.Concrete.Entityframework.UnitOfWork
{
    public class UnitofWork : IUnitOfWork
    {
        public bool BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool RollBackTransaction()
        {
            throw new System.NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}
