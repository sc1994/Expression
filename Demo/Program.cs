using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using ExpressionHelper;
using ExpressionHelper.Model;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "123";
            Expression<Func<Product, bool>> exp =
                x => x.Name == "1" && (x.Id == 2 || x.Name == "3" || x.Id == 4);

            var arg = new ExpressionInfo();
            HelperTool.AddWhere(exp.Body, arg);

            foreach (var item in arg.Exps)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine(exp.Body.ToString());
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
}
