using System;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class BinaryExpressionHelper : BaseExpressionHelper<BinaryExpression>
    {
        public override void AddWhere(BinaryExpression exp, ExpressionInfo arg)
        {
            HelperTool.AddWhere(exp.Left, arg);

            Console.WriteLine(exp.NodeType.ToString());

            HelperTool.AddWhere(exp.Right, arg);
        }
    }
}
