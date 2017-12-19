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
                // 存储变量名称,再需要解析变量值的时候获取此字段的值
                arg.ConstantName = exp.Member.Name;
                HelperTool.AddWhere(exp.Expression, arg);
                Console.WriteLine(exp.Member.Name);
                arg.Add(exp.Member.Name);
            }
            else
            {
                var fi = (PropertyInfo)exp.Member;
                var val = fi.GetValue(((ConstantExpression)exp.Expression)?.Value, null);
                Console.WriteLine(val);
            }
        }
    }
}
