using System.Linq.Expressions;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public interface IExpressionHelper
    {
        void AddWhere(Expression exp, ExpressionInfo arg);

        void AddShow(Expression exp, ExpressionInfo info);
    }
}
