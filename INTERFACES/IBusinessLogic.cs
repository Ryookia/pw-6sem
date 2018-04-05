using System.Collections.Generic;

namespace Durczak.AplikacjaWielowarstowa.Interfaces
{
    public interface IBusinessLogic
    {
        List<IProducer> GetAllProducers();
        List<IProducer> GetProducersSorted();

        List<IProduct> GetAllProducts();
        List<IProducer> GetProductsSorted();
    }
}