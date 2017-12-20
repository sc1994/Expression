using System;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class MethodCallExpressionHelper : BaseExpressionHelper<MethodCallExpression>
    {
        public override void AddWhere(MethodCallExpression exp, ExpressionInfo arg)
        {
            arg.SetRelation(exp.Method.Name);
            Console.WriteLine(exp.Method.Name);
            foreach (var argument in exp.Arguments)
            {
                HelperTool.AddWhere(argument, arg);
            }
            HelperTool.AddWhere(exp.Object, arg);
        }
    }
}
