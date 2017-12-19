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
            var b = "abcdef";
            var c = new[] { 2, 3, 4, 5 };
            var arg = new ExpressionInfo();
            Expression<Func<Product, bool>> exp;


            exp = x => 
            b.StartsWith(x.Name) 
            && b.Contains(x.Name) 
            || c.Any(u => u == x.Id) 
            && x.Data == DateTime.Now;

            HelperTool.AddWhere(exp.Body, arg);
            

            //exp = x => b.Contains(x.Name);
            //HelperTool.AddWhere(exp.Body, arg);

            //exp = x => c.Any(u => u == x.Id);
            //HelperTool.AddWhere(exp.Body, arg);

            //exp = x => x.Data == DateTime.Now;
            //HelperTool.AddWhere(exp.Body, arg);

























            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
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
