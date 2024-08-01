using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System_Employee.Models
{
    public class Sale( Employee seller, Client buyer, List<Product> products)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Employee Seller { get; set; } = seller;
        public Client Buyer { get; set; } = buyer;
        public List<Product> Products { get; set; } = products;

        public void ShowInfo()
        {
            Console.WriteLine($@"
                Nro: {Id}
                Vendedor: {Seller.GetName()}, {Seller.GetLastName()}
                Comprador: {Buyer.GetName()}, {Buyer.GetLastName()}
                Productos:
                {
                    string.Join(", ", Products.Select(p => $"{p.Name} - {p.Price}"))
                }
            ");
        }
    }
}