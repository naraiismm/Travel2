using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Dependence.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TravelManager>().As<ITravelManager>().SingleInstance();    
            builder.RegisterType<EfTravelDal>().As<ITravelDal>().SingleInstance();
            builder.RegisterType<BaseProjectContext>().As<BaseProjectContext>().SingleInstance();

        }
    }
}
