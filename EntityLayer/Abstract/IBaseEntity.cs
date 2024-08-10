using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Abstract;

namespace EntityLayer.Abstract
{
    public abstract class IBaseEntity :IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
