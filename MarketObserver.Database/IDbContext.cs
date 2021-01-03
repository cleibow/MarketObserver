using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketObserver.Database
{
    public interface IDbContext: IDisposable
    {
        int SaveChanges();
    }
}
