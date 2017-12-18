
using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public interface IExpressionHelper
    {
        void AddWhere(Expression exp, List<ExpressionInfo> args);
    }
}
