using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category :IBaseEntity
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }

    }
}
