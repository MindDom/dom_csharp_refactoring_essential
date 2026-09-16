using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongMethod
{
    public class Customer
    {
        public bool IsLoyal { get; }

        public Customer(bool loyal)
        {
            IsLoyal = loyal;
        }
    }
}
