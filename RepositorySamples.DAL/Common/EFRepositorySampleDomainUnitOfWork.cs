using RepositorySamples.DAL;
using RepositorySamples.Domain.Common;
using RepositorySamples.Framework;

namespace RepositorySamples.DAL.Common
{
    public class EFRepositorySampleDomainUnitOfWork : BaseEfUnitOfWork<RepSampleDBContext>,  IRepositorySampleDomainUnitOfWork
    {
        public EFRepositorySampleDomainUnitOfWork(RepSampleDBContext dbContext) : base(dbContext)
        {
        }
    }
}
