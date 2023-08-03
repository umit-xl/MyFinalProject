using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concsrote.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _producDal;

        public ProductManager(IProductDal producDal)
        {
            _producDal = producDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları

            return _producDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _producDal.GetAll(p=> p.CategoryId == id);
        }

        public List<Product> GetAllByUnitePrice(decimal min, decimal max)
        {
            return _producDal.GetAll(p => p.UnitPrice>=min && p.UnitPrice<=max);
        }
    }
}
