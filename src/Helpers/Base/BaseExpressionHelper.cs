using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public abstract class BaseExpressionHelper<T> : IExpressionHelper
        where T : Expression
    {
        public abstract void AddWhere(T exp, ExpressionInfo arg);

        public void AddWhere(Expression exp, ExpressionInfo arg)
        {
            AddWhere(exp as T, arg);
        }
    }
}
