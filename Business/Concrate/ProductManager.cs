using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ProductManager : IProductService
    {
        IProductDal _ıProductDal;
        public ProductManager(IProductDal productDal)
        {
            _ıProductDal = productDal;
        }
        public List<Product> GetAll()
        {
            //iş kodları kontrol
            //yetkilimi
            return _ıProductDal.GetAll();
        }
    }
}
