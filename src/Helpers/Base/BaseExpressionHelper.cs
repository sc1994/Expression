using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public abstract class BaseExpressionHelper<T> : IExpressionHelper
        where T : Expression
    {
        public abstract void AddShow(T exp, ExpressionInfo arg);

        public abstract void AddWhere(T exp, ExpressionInfo arg);

        public void AddWhere(Expression exp, ExpressionInfo arg)
        {
            AddWhere(exp as T, arg);
        }

        public void AddShow(Expression exp, ExpressionInfo arg)
        {
            AddShow(exp as T, arg);
        }
    }
}
