using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Interfaces
{
   public interface IBaseTableAtributes
    {
        DateTime Created { get; set; }
        long Id { get; set; }
        DateTime Updated { get; set; }
        bool Valid { get; set; }
    }
}
