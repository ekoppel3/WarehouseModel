using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class CustomerBLL
    {
        // public ProductDAL pDal { get; set; }
        private CustomerDAL cDal;
        public CustomerBLL()
        {
            cDal = new CustomerDAL();
        }

        public Customer CreateBLL(Customer customer)
        {
            try
            {
                return cDal.Create(customer);
            }
            catch (NumberAlreadyExists nae)
            {
                throw nae;
            }

        }

        public Customer ReadBLL(int idToFind)
        {
            try
            {
                return cDal.Read(idToFind);
            }
            catch (NumberDoesNotExist ndne)
            {
                throw ndne;
            }

        }

        public List<Customer> ReadAll()
        {
            return cDal.ReadAll();
        }

        public void DeleteBLL(int num)
        {
            try
            {
                cDal.Delete(num);
            }
            catch (NumberDoesNotExist nd)
            {
                throw nd;
            }

        }

        public void UpdateBLL(Customer toUpdate)
        {
            try
            {
                cDal.Update(toUpdate);
            }
            catch (NumberDoesNotExist nonExistent)
            {
                throw nonExistent;
            }
        }
    }
}

