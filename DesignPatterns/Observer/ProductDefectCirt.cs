using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class ProductDefectCirt : Cirt
    {
        public ProductDefectCirt (string description, DateTime start) :
            base(description, start)
        {

        }
    }
}
