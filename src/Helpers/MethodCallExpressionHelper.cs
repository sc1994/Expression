using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class MethodCallExpressionHelper : BaseExpressionHelper<MethodCallExpression>
    {
        public override void AddWhere(MethodCallExpression exp, List<ExpressionInfo> args)
        {
            foreach (var arg in exp.Arguments)
            {
                HelperTool.AddWhere(arg, args);
            }
        }
    }
}
