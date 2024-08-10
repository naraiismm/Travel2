using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfTravelDal :BaseRepository<Travel,BaseProjectContext>,ITravelDal
    {
        

        public EfTravelDal(BaseProjectContext context):base( context)
        {
            
            
        }
    }
}
