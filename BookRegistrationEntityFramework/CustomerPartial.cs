using System;
using System.Collections.Generic;
using System.Text;

namespace BookRegistrationEntityFramework
{
    public partial class Customer
    {
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}