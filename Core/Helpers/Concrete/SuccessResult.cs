using Core.Helpers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helpers.Concrete
{
    public class SuccessResult : Result
    {
        public SuccessResult(bool success,string message) : base(true,message)
        {
            
        }
        public SuccessResult():base(true)
        {
            
        }
    }
}
