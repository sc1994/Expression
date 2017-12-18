using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class BinaryExpressionHelper : BaseExpressionHelper<BinaryExpression>
    {
        public override void AddWhere(BinaryExpression exp, ExpressionInfo arg)
        {
            var body = exp.ToString();
            arg.Add(body.Replace(body.TrimStart('('), ""));
            HelperTool.AddWhere(exp.Left, arg);
            arg.Add(body.Replace(body.TrimEnd(')'), ""));


            arg.Add(body.Replace(body.TrimStart('('), ""));
            HelperTool.AddWhere(exp.Right, arg);
            arg.Add(body.Replace(body.TrimEnd(')'), ""));

        }
    }
}
