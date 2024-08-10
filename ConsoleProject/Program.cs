

using BusinessLayer.Concrete;
using DataAccess.Concrete;
using EntityLayer.Concrete;

TravelManager travelManager = new(new EfTravelDal(new BaseProjectContext()));

Travel travel = new() { DepartureDate = DateTime.Now,Description="dxds",Destination="dcsdsd",Title="dcdc",IsDeleted=false };