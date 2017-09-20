using SampleInjectExample.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SampleInjectExample.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<string, int>, IClienteRepository
    {
        public string CaptureMessage()
        {
            return "Message";
        }

        public void Delete(int obj)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Expression<Func<object, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<int> Get()
        {
            throw new NotImplementedException();
        }

        public int GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Insert(int obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(int obj)
        {
            throw new NotImplementedException();
        }
    }
}
