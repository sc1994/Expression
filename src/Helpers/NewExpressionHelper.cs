using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class NewExpressionHelper : BaseExpressionHelper<NewExpression>
    {
        public override void AddShow(NewExpression exp, ExpressionInfo arg)
        {
            foreach (var item in exp.Arguments)
            {
                arg.SetNewMember(item.ToString());
            }
        }

        public override void AddWhere(NewExpression exp, ExpressionInfo arg)
        {
            foreach (var item in exp.Arguments)
            {
                arg.SetNewMember(item.ToString());
            }
        }
    }
}
