using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBLL
    {
        // public ProductDAL pDal { get; set; }
        private ProductDAL pDal;
        public ProductBLL()
        {
           pDal = new ProductDAL(); 
        }

        public Product CreateBLL(Product product)
        {
            try
            {
                return pDal.Create(product);
            }
             catch(NumberAlreadyExists nae)
            {
                throw nae;
            }
           
        }

        public Product ReadBLL(int numberToFind)
        {
          try
            {
                return pDal.Read(numberToFind);
            }
            catch(NumberDoesNotExist ndne)
            {
                throw ndne;
                /*Console.WriteLine(ndne.Message);
                return null;*/
            }
                 
        }

        public List<Product> ReadAll()
        {
            return pDal.ReadAll();
        }

        public void DeleteBLL(int num)
        {
            try
            {
                pDal.Delete(num);
            }
            catch(NumberDoesNotExist nd)
            {
                throw nd;
            }
          
        }

        public void UpdateBLL(Product toUpdate)
        {
            try
            {
                pDal.Update(toUpdate);
            }
           catch(NumberDoesNotExist nonExistent)
            {
                throw nonExistent;
            }
        }
    }
}
