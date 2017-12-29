using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class BinaryExpressionHelper : BaseExpressionHelper<BinaryExpression>
    {
        public override void AddShow(BinaryExpression exp, ExpressionInfo arg)
        {
            HelperTool.AddWhere(exp.Left, arg);

            HelperTool.AddWhere(exp.Right, arg);
        }

        public override void AddWhere(BinaryExpression exp, ExpressionInfo arg)
        {
            HelperTool.AddWhere(exp.Left, arg);

            arg.SetRelation(exp.NodeType.ToString());

            HelperTool.AddWhere(exp.Right, arg);
        }
    }
}
