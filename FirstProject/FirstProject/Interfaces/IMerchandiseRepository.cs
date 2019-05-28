using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Models;

namespace FirstProject.Interfaces
{
    public interface IMerchandiseRepository
    {
        IEnumerable<Merchandise> Merchandises { get; }
        Merchandise GetMerchandiseById(int id);
    }
}
