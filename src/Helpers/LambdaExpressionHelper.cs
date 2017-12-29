using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class LambdaExpressionHelper : BaseExpressionHelper<LambdaExpression>
    {
        public override void AddShow(LambdaExpression exp, ExpressionInfo arg)
        {
            throw new System.NotImplementedException();
        }

        public override void AddWhere(LambdaExpression exp, ExpressionInfo arg)
        {
            HelperTool.AddWhere(exp.Body, arg);
        }
    }
}
