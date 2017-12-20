﻿using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class UnaryExpressionHelper : BaseExpressionHelper<UnaryExpression>
    {
        public override void AddWhere(UnaryExpression exp, ExpressionInfo arg)
        {
            arg.SetObjectUnary(exp.NodeType);
            HelperTool.AddWhere(exp.Operand, arg);
        }
    }
}
