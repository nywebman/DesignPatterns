using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Repository
{
    public class RepositoryMain
    {
        //https://github.com/remondo/RepositoryPatternEntityFramework
        public RepositoryMain()
        {
            using (var dataContext = new HotelContext())
            {
                var hotelRepository = new Repository<Hotel>(dataContext);
                var cityRepository = new Repository<City>(dataContext);

                City city = cityRepository
                    .SearchFor(c => c.Name.StartsWith("Ams"))
                    .Single();

                IEnumerable<Hotel> orderedHotels = hotelRepository
                    .GetAll()
                    .Where(c => c.MyCity.Equals(city))
                    .OrderBy(h => h.Name);

                Console.WriteLine("* Hotels in {0} *", city.Name);

                foreach (Hotel orderedHotel in orderedHotels)
                {
                    Console.WriteLine(orderedHotel.Name);
                }

                Console.ReadKey();
            }
        }
    }
}
