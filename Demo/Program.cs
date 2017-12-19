using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ExpressionHelper;
using ExpressionHelper.Model;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = DateTime.Now;
            var b = "1";
            var c = new [] { 2, 3, 4, 5 };
            Expression<Func<Product, bool>> exp =
                x => c.Any(u => u == x.Id);

            var arg = new ExpressionInfo();
            HelperTool.AddWhere(exp.Body, arg);























            Console.WriteLine((DateTime.Now - a).ToString("c"));
            Console.Write("END");
            Console.ReadLine();
        }
    }

    class Product
    {
        public string Name;

        public int Id;

        public DateTime Data;
    }

    class Product2
    {
        public string Name2;

        public int Id2;

        public DateTime Data2;
    }
}
