using Durczak.AplikacjaWielowarstowa.Interfaces;

namespace Durczak.AplikacjaWielowarstowa.Dao
{
    public class Producer : IProducer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryOrigin { get; set; }


        public override string ToString()
        {
            return "Producer{" +
                   "id= " + Id +
                   ", name= " + Name +
                   ", countryOrigin= " + CountryOrigin +
                   "}";
        }
    }

}