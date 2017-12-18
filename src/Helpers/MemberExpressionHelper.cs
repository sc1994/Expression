using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    class MemberExpressionHelper : BaseExpressionHelper<MemberExpression>
    {
        public override void AddWhere(MemberExpression exp, ExpressionInfo arg)
        {
            if (exp.Expression != null)
            {
                HelperTool.AddWhere(exp.Expression, arg);
            }
            else
            {
                var fi = (PropertyInfo)exp.Member;
                var val = fi.GetValue(((ConstantExpression)exp.Expression)?.Value, null);
                //HelperTool.Log(val.ToString(), "MemberExpression");
            }
        }
    }
}
