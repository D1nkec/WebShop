using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopFresh.Shared.Models.Base
{
    public abstract class CategoryBase 
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
