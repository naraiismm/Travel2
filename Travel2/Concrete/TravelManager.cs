using BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;
using BusinessLayer.Validation.FluentValidation;
using Core.CrossCuttingConcern.Validation;
using Core.Helpers.Results.Abstract;
using Core.Helpers.Results.Concrete;
using Core.Aspects.Autofac.Validation.FluentValidation;

namespace BusinessLayer.Concrete
{
    public class TravelManager(ITravelDal travelDal) : ITravelManager
    {
        private readonly ITravelDal _travelDal=travelDal;

        
        [ValidationAspect<Travel>(typeof(TravelValidator))]
        public IResult Add(Travel travel)
        {
            
            
            
            
                _travelDal.Add(travel);
                return new SuccessResult(true,"Added succesfully");
           

        }

        public IResult Delete(int id)
        {
            var deletedTravel=_travelDal.Get(t=>t.Id==id&&t.IsDeleted==false);
            if(deletedTravel != null)
            {
                deletedTravel.IsDeleted = true;
                _travelDal.Delete(deletedTravel);
                return new SuccessResult(true,"Travel was deleted");
            }
            else
            {
                return new ErrorResult();
            }

        } 

        public IDataResult<Travel> Get(int id)
        {
            var getTravel = _travelDal.Get(t => t.IsDeleted == false && t.Id == id);
            if(getTravel != null)
            {
                return new SuccessDataResult<Travel>(getTravel, "Travel get successfuly");
            }
            else
            {
                return new ErrorDataResult<Travel>(getTravel,false,"Something went wrong");
            }
           
        }

        public IDataResult<List<Travel>> GetAll()
        {

            var getAll = _travelDal.GetAll(g => g.IsDeleted == false ).ToList();
            if(getAll != null)
            {
                return new SuccessDataResult<List<Travel>>(getAll, "Get all successfuly");
            }
            else
            {
                return new ErrorDataResult<List<Travel>>(getAll,false,"Something went wrong");
            }
            
        }

        public IResult Update(Travel travel)
        {
            var updatedTravel=_travelDal.Get(t=>t.IsDeleted==false&&t.Id==travel.Id);
            if (updatedTravel != null)
            {
                updatedTravel.Description = travel.Description;
                updatedTravel.Title = travel.Title;
                _travelDal.Update(updatedTravel);
                return new SuccessResult();
            }
            else
            {
                return new ErrorResult();
            }

        }
    }
}
