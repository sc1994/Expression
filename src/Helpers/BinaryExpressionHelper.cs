using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class BinaryExpressionHelper : BaseExpressionHelper<BinaryExpression>
    {
        public override void AddWhere(BinaryExpression exp, List<ExpressionInfo> args)
        {
            HelperTool.AddWhere(exp.Left, args);
            HelperTool.AddWhere(exp.Right, args);
        }
    }
}
