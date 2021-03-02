//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using DataAccess.Abstract;
//using Entities.Concrete;

//namespace DataAccess.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    { 
//        List<Car> _cars;

//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2012, DailyPrice = 500, Description = "A3 Sedan"},
//                new Car{Id = 2, BrandId = 2, ColorId = 1, ModelYear = 2015, DailyPrice = 700, Description = "Yeni BMW 1 Serisi"},
//                new Car{Id = 3, BrandId = 1, ColorId = 2, ModelYear = 2019, DailyPrice = 900, Description = "A3 Sedan Yeni Seri"}
//            };
//        }

//        public void Add(Car car)
//        {
//            _cars.Add(car);
//            Console.WriteLine("Araba Eklendi");
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.Description = car.Description;
//            Console.WriteLine("Araba Güncelledni");
//        }

//        public void Delete(Car car) 
//        {
//            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

//            _cars.Remove(carToDelete);
//            Console.WriteLine("Araba Silindi");
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetById(int carId) 
//        {
//            return _cars.Where(c => c.Id == carId).ToList();
            
//        }


//    }
//}
