using System;
namespace VehicleManagemnetSystem
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
    }
    public class PrimeCustomer
    {
        public bool IsActive { get; set; }
    }
}
