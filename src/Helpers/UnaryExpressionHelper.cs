using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class UnaryExpressionHelper : BaseExpressionHelper<UnaryExpression>
    {
        public override void AddWhere(UnaryExpression exp, ExpressionInfo arg)
        {
            HelperTool.AddWhere(exp.Operand, arg);
        }
    }
}
