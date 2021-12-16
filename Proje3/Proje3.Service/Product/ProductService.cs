using AutoMapper;
using Proje3.DB.Entities.DataContext;
using Proje3.Model;
using Proje3.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje3.Service.Product
{
    public class ProductService : IProductService
    {

        private readonly IMapper mapper;

        public ProductService(IMapper _mapper)
        {
            mapper = _mapper;
        }


        public General<ProductDetail> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public General<ProductDetail> Insert(InsertProduct newProduct)
        {
            var result = new General<ProductDetail>() { IsSucces = false };
            var model = mapper.Map<Proje3.DB.Entities.Product>(newProduct);

            using (var srv = new Proje3Context())
            {
                model.Idate = System.DateTime.Now;
                model.Name = model.DisplayName;
                model.Iuser = 1;
                srv.Product.Add(model);
                srv.SaveChanges();
                result.Entity = mapper.Map<ProductDetail>(model);
                result.IsSucces = true;
            }
            return result;
        }

        public General<ListProduct> List()
        {
            throw new NotImplementedException();
        }

        
    }
}
