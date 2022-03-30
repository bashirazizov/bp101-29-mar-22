using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    class Singer : Worker
    {
        //private string _name;
        //public string Name {
        //    get { return _name; }
        //    set {
        //        if (value.Length < 100)
        //        {
        //            _name = value;
        //        }
        //    }
        //}
        //private string _surName;
        //public string SurName
        //{
        //    get { return _surName; }
        //    set
        //    {
        //        if (value.Length < 100)
        //        {
        //            _surName = value;
        //        }
        //    }
        //}
        //private int _age;
        //public int Age
        //{
        //    get { return _age; }
        //    set
        //    {
        //        if (value < 170)
        //        {
        //            _age = value;
        //        }
        //    }
        //}

        public Song[] Songs { get; set; }

        public int CalculatePension()
        {
            return (int)(Salary * 0.1);
        }
    }
}
