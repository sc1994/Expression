using System;
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

            Expression<Func<Product, bool>> exp =
                x => x.Data == a || x.Name == "1";

            var arg = new ExpressionInfo();
            HelperTool.AddWhere(exp.Body, arg);

            var r = new Random().Next(0, 100);

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
