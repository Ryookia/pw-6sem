using Durczak.AplikacjaWielowarstowa.Core;

namespace Durczak.AplikacjaWielowarstowa.Dao
{
    public class ProductBuilder
    {
        private Product _product;

        public ProductBuilder()
        {
            _product = new Product();
        }

        public ProductBuilder SetName(string name)
        {
            _product.Name = name;
            return this;
        }

        public ProductBuilder SetId(int id)
        {
            _product.Id = id;
            return this;
        }

        public ProductBuilder SetPropulsion(Propulsion propulsion)
        {
            _product.Propulsion = propulsion;
            return this;
        }

        public ProductBuilder SetMaterial(Material material)
        {
            _product.Material = material;
            return this;
        }

        public ProductBuilder SetVelocity(int velocity)
        {
            _product.Velocity = velocity;
            return this;
        }

        public ProductBuilder SetProducerId(int producerId)
        {
            _product.ProducerId = producerId;
            return this;
        }

        public Product Build()
        {
            var toReturn = _product;
            _product = new Product();
            return toReturn;

        }

    }
}