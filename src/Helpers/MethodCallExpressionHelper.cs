using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class MethodCallExpressionHelper : BaseExpressionHelper<MethodCallExpression>
    {
        public override void AddWhere(MethodCallExpression exp, ExpressionInfo arg)
        {
            foreach (var argument in exp.Arguments)
            {
                HelperTool.AddWhere(argument, arg);
            }
        }
    }
}
