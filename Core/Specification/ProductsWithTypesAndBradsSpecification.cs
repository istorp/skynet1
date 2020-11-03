using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specification
{
    public class ProductsWithTypesAndBradsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBradsSpecification()
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
            
        }

        public ProductsWithTypesAndBradsSpecification(int id) : base(x=>x.Id==id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }
    }
}