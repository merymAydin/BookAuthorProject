using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public abstract class BaseEntity :IEntity
    {
        public string imageUrl { get; set; } = string.Empty;
        public string Description { get; set; }
    }
}
