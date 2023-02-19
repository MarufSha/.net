using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudLabTask.Modelclass
{
    public class ProductModelClass
    {
       
      public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }
    }
}