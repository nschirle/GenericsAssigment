using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAssignment
{
    class CustomerRecord
    {
        private string lastName { get; set; }
        private string firstName { get; set; }
        private string customerNumber { get; set; }
        public string _lastName { get { return lastName; } }
        public string _firstName { get { return firstName; } }
        public string _customerNumber { get { return customerNumber; } }
        public CustomerRecord(string LastName, string FirstName, string CustomerNumber)
        {
            lastName = LastName;
            firstName = FirstName;
            customerNumber = CustomerNumber;
        }


        public override string ToString()
        {
            return $"{firstName}, {lastName}: {customerNumber}.";
        }
    }
}
