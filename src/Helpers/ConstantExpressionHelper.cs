using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class ConstantExpressionHelper:BaseExpressionHelper<ConstantExpression>
    {
        public override void AddWhere(ConstantExpression exp, List<ExpressionInfo> args)
        {
            
        }
    }
}
