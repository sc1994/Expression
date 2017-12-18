using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper;
using ExpressionHelper.Model;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "123";
            Expression<Func<string, bool>> exp =
                x => x == "1" ||
                x.Contains(a);

            var exps = new List<ExpressionInfo>();
            HelperTool.AddWhere(exp.Body, exps);
        }
    }
}
