using System;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class ParameterExpressionHelper:BaseExpressionHelper<ParameterExpression>
    {
        public override void AddWhere(ParameterExpression exp, ExpressionInfo arg)
        {
            Console.WriteLine(exp.Name);
        }
    }
}
