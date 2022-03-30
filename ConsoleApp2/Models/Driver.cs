using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    class Driver : Worker
    {
        public int CalculatePension()
        {
            return (int)(Salary * 0.1);
        }
    }
}
