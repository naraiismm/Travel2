


using BusinessLayer.Concrete;
using DataAccess.Concrete;
using EntityLayer.Concrete;

TravelManager travelManager = new TravelManager(new EfTravelDal());

Travel travel1=new Travel() { Title="Oslo",Description="jdndsklsjdjsndjn",ImgUrl="hckjjhcgfcvb",IsDeleted=false};
travelManager.Add(travel1);
