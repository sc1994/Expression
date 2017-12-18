using System.Linq.Expressions;

namespace ExpressionHelper.Helpers
{
    public abstract class BaseExpressionHelper<T> : IExpressionHelper
        where T : Expression
    {
        public abstract void AddWhere(T exp);

        public void AddWhere(Expression exp)
        {
            AddWhere(exp as T);
        }
    }
}
