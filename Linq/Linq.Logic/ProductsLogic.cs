using Linq.Data;
using Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Logic
{
    public class ProductsLogic
    {
        private readonly NorthwindContext _context;

        public ProductsLogic()
        {
            _context = new NorthwindContext();
        }

        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        public List<Products> WithoutStock()
        {
            return (from p in _context.Products
                    where p.UnitsInStock == 0
                    select p).ToList();      
        }

        public List<Products> FilterWithStockAndPrice(int price)
        {
            return _context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > price).ToList();   
        }

        public Products FindById(int id)
        {
           return _context.Products.Find(id);
        }

        public List<Products> OrderByName()
        {
            return _context.Products.OrderBy(p => p.ProductName).ToList();
        }

        public List<Products> OrderByStockDesc()
        {
            return _context.Products.OrderByDescending(p => p.UnitsInStock).ToList();
        }

        public List<CategoriesDTO> GroupByCategories()
        {
            return  (_context.Categories.GroupJoin(
                        _context.Products,
                        category => category.CategoryID,
                        product => product.CategoryID,
                        (category, product) =>
                            new CategoriesDTO
                            {
                                CategoryName = category.CategoryName.ToString()
                            })
                    ).ToList();       
        }

        public Products FirstProduct()
        {
            return _context.Products.First();
        }
    }
}
