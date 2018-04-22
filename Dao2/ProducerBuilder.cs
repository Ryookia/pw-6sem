namespace Durczak.AplikacjaWielowarstowa.Dao2
{
    public class ProducerBuilder
    {

        private Producer _producer;

        public ProducerBuilder()
        {
            _producer = new Producer();
        }

        public ProducerBuilder SetId(int id)
        {
            _producer.Id = id;
            return this;
        }

        public ProducerBuilder SetName(string name)
        {
            _producer.Name = name;
            return this;
        }

        public ProducerBuilder SetOriginCountry(string country)
        {
            _producer.CountryOrigin = country;
            return this;
        }

        public Producer Build()
        {
            var toReturn = _producer;
            _producer = new Producer();
            return toReturn;
        }
    }
}