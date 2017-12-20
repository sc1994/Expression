using System;
using System.Linq.Expressions;
using ExpressionHelper;
using ExpressionHelper.Model;

namespace Demo
{
    class Program
    {
        static void Main()
        {
            var a = DateTime.Now;
            var c = new[] { 2, 3, 4, 5 };
            var arg = new ExpressionInfo();
            Expression<Func<Product, bool>> exp;

            var d = '1';

            var b = new[] { "((abcdef))", "1", "6", "3" };

            exp = x => c[2] > x.Id;

            HelperTool.AddWhere(exp.Body, arg);

            Console.WriteLine(arg.Expressions[0].Object[0].Value);

            var s = "";
            s.TrimStart();
            s.TrimEnd();
            s.Trim(',', ' ', ',', ' ');
            s.Contains("");
            s.StartsWith("");
            s.EndsWith("");
            s.Equals("");
            s.ToLower();
            s.ToUpper();



            //exp = x => b.Contains(x.Name);
            //HelperTool.AddWhere(exp.Body, arg);

            //exp = x => c.Any(u => u == x.Id);
            //HelperTool.AddWhere(exp.Body, arg);

            //exp = x => x.Data == DateTime.Now;
            //HelperTool.AddWhere(exp.Body, arg);

            //Expression<Func<Product, dynamic>> exp1 =
            //    x => new
            //    {
            //        x.Id
            //    };

            //HelperTool.AddWhere(exp1.Body, arg);

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
