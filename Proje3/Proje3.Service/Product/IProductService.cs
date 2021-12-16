using Proje3.Model;
using Proje3.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3.Service.Product
{
    public interface IProductService
    {
        public General<ProductDetail> Insert(InsertProduct newProduct);
        public General<ListProduct> List();
        public General<ProductDetail> GetById(int id);
    }
}
