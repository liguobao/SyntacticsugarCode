﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace SyntacticsugarCode
{
    class Myclass
    {
        public int Value
        {

            get;
            set;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           /* Myclass obj = new Myclass();
            obj.Value = 50;
            Console.WriteLine(obj.Value);
            */


           /* var index = 1;
            Console.WriteLine(index);
            var str_test = "hello var!";
            Console.WriteLine(str_test);*/


            //var obj1 = new { Name="obj1",Age=20};
            //var obj2 = new { Name = "obj2", Age = 30 };
            //Console.WriteLine(obj1.GetType()==obj2.GetType());
            //Console.WriteLine(obj2.GetType());
            //Console.ReadLine();

            //dynamic test = "Test";
            //Console.WriteLine(test.GetType());
            //test = 100;
            //Console.WriteLine(test.GetType());
            
            //var myclass = new Myclass();
            //myclass.Value = 10;
            //test = myclass;
            //Console.WriteLine(test.GetType());

            //dynamic dynEO = new ExpandoObject();
            //dynEO.intValue = 100;
            //dynEO.message = "hello!";
            //Console.WriteLine(dynEO.GetType());
            //Console.WriteLine(dynEO.intValue);
            //Action<string> act = (str) => { Console.WriteLine(str); };
            //dynEO.say = act;
            //dynEO.say(dynEO.intValue.ToString());
            //Console.ReadLine();
        }
    }
}
