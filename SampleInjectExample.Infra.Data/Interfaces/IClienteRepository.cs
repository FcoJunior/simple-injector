using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleInjectExample.Infra.Data.Interfaces
{
    public interface IClienteRepository : IRepositoryBase<int>
    {
        string CaptureMessage();
    }
}
