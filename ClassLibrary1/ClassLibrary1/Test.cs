﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Test
    {
        public void test()
        {
            Notification n = new Notification();
            n.Notify("Necesen", ConsoleColor.Green);

        }
    }
}
