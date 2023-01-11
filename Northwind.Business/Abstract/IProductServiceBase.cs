using Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Northwind.Business.Abstract
{
    public interface IProductServiceBase
    {
        List<Product> GetAll();
    }
}