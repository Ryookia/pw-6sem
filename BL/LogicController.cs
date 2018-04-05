using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Durczak.AplikacjaWielowarstowa.Dao;
using Durczak.AplikacjaWielowarstowa.Interfaces;

namespace Durczak.AplikacjaWielowarstowa.BL
{
    public class LogicController : IBusinessLogic
    {

        private readonly IDao _database;

        public LogicController()
        {
            _database = new DaoMock();
        }

        public List<IProducer> GetAllProducers()
        {
            return _database.GetProducerList();
        }

        public List<IProduct> GetAllProducts()
        {
            return _database.GetProductList();
        }

        public List<IProducer> GetProducersSorted()
        {
            throw new NotImplementedException();
        }

        public List<IProducer> GetProductsSorted()
        {
            throw new NotImplementedException();
        }
    }
}
