using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class ParameterExpressionHelper:BaseExpressionHelper<ParameterExpression>
    {
        public override void AddShow(ParameterExpression exp, ExpressionInfo arg)
        {
            throw new System.NotImplementedException();
        }

        public override void AddWhere(ParameterExpression exp, ExpressionInfo arg)
        {
            arg.SetObjectAlias(exp.Name);
        }
    }
}
