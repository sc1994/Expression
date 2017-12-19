using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class LambdaExpressionHelper : BaseExpressionHelper<LambdaExpression>
    {
        public override void AddWhere(LambdaExpression exp, ExpressionInfo arg)
        {
            HelperTool.AddWhere(exp.Body, arg);
        }
    }
}
