using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Travel :IBaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Destination { get; set; }
    }
}
