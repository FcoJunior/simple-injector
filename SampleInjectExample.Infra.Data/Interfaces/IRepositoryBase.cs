using SampleInjectExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleInjectExample.Infra.Data.Interfaces
{
    public interface IRepositoryBase<TDomain>
    {
        void Insert(TDomain obj);

        void Update(TDomain obj);

        void Delete(TDomain obj);

        IQueryable<TDomain> Get();

        TDomain GetById(long id);

        bool Exist(Expression<Func<object, bool>> expression);

        void Save();
    }
}
