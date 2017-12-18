using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public abstract class BaseExpressionHelper<T> : IExpressionHelper
        where T : Expression
    {
        public abstract void AddWhere(T exp, List<ExpressionInfo> args);

        public void AddWhere(Expression exp, List<ExpressionInfo> args)
        {
            AddWhere(exp as T, args);
        }
    }
}
