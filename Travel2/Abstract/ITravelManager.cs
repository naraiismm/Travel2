using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayer.Concrete;
using System.Threading.Tasks;
using Core.Helpers.Results.Abstract;

namespace BusinessLayer.Abstract
{
    public interface ITravelManager
    {
        IResult Add(Travel travel);
        IResult Delete(int id);
        IResult Update(Travel travel); 
        IDataResult<Travel> Get(int id);
       IDataResult< List<Travel> >GetAll();  

        

    }
}
