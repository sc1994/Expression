using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class ConstantExpressionHelper : BaseExpressionHelper<ConstantExpression>
    {
        public override void AddWhere(ConstantExpression exp, ExpressionInfo arg)
        {
            if (exp.Type.Name.Contains("DisplayClass"))
            {
                var type = exp.Value.GetType();
                var value = type.InvokeMember(arg.ConstantName, BindingFlags.GetField, null, exp.Value, null);
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine(exp.Value);
            }
        }
    }
}
