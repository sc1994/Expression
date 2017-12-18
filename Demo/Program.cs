using System;
using System.Linq.Expressions;
using ExpressionHelper;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<string, bool>> exp = x => x.Length == 1;

            HelperTool.GetPort(exp.Body).AddWhere(exp.Body);
        }
    }
}
