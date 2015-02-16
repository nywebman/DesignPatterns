using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class Hotel : IEntity
    {
        public string Name { get; set; }
        public virtual City MyCity { get; set; }

        #region IEntity Members

        public int Id { get; set; }

        #endregion
    }
}
