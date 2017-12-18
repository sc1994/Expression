using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    class MemberExpressionHelper : BaseExpressionHelper<MemberExpression>
    {
        public override void AddWhere(MemberExpression exp, List<ExpressionInfo> args)
        {
            HelperTool.AddWhere(exp.Expression, args);
        }
    }
}
