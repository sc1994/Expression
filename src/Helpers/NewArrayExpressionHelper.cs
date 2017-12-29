using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class NewArrayExpressionHelper : BaseExpressionHelper<NewArrayExpression>
    {
        public override void AddShow(NewArrayExpression exp, ExpressionInfo arg)
        {
            throw new System.NotImplementedException();
        }

        public override void AddWhere(NewArrayExpression exp, ExpressionInfo arg)
        {
            foreach (var item in exp.Expressions)
            {
                HelperTool.AddWhere(item, arg);
            }
        }
    }
}
