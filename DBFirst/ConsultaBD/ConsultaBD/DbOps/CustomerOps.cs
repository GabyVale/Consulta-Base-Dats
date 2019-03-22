using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaBD.DbOps
{
    class CustomerOps
    {
        //Hacer las operaciones CRUD
        string id;
        private NorthwindEntities entities = new NorthwindEntities();

        //Mostramos toda la tabla
        public List<Customer> GetCustomers()
        {
            return entities.Customers.ToList();
        }

        //Buscamos un dato
        public Customer GetCustomerById(string id)
        {
            return entities.Customers.FirstOrDefault(c => c.CustomerID==id);
        }

        public void UpdateCustomerCompanyName(string id, string companyName)
        {
            var customer = GetCustomerById(id);
            if(customer != null)
            {
                customer.CompanyName = companyName;
                entities.SaveChanges();
            }
        }

        //Borrar un colo cliente
        public void DeleteCustomer(string id)
        {
            var customer = GetCustomerById(id);
            if (customer != null)
            {
                customer.CustomerID = id;
                entities.Orders.ToList();//Muestra todos
                entities.Orders.FirstOrDefault(c => c.CustomerID == id);//Buscamos las coincidencias
                entities.Customers.Remove(customer);
                entities.SaveChanges();
            }
        }

        public void AgregarCustomer(Customer customer)
        {
            entities.Customers.Add(customer);
            entities.SaveChanges();
        }

    }
}
