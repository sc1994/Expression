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

            var d = "1";

            var b = new[] { "((abcdef))", "1", "6", "3" };

            exp = x => x.Name == b[2];

            HelperTool.AddWhere(exp.Body, arg);

            Console.WriteLine("*********************START****************************");

            foreach (var expression in arg.Expressions)
            {
                foreach (var obj in expression.Object)
                {
                    Console.WriteLine($"表达式的内容{(obj.Unary == "Add" ? "" : obj.Unary)}  {obj.Alias}.{obj.Field}");
                    Console.WriteLine($"值为:{obj.Value}");
                }
                if (expression.Methods.Count > 0)
                {
                    foreach (var method in expression.Methods)
                    {
                        Console.WriteLine($"表达式中包含的方法:.{method.Method}({string.Join(",", method.Parameters).Trim(',')})");
                    }
                }
                Console.WriteLine($"表达式的内容关系{expression.Relation}");
                Console.WriteLine($"向后的条件关系{expression.Coexist}");
            }

            Console.WriteLine("**********************END*****************************");




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
