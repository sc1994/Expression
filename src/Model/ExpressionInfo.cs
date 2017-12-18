using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionHelper.Model
{
    public class ExpressionInfo
    {
        /// <summary>
        /// 当前表达式的类型命名如:
        /// BinaryExpression,MethodCallExpression
        /// </summary>
        public string ExpressionClassName { get; set; }

        /// <summary>
        /// 表达式的实例
        /// </summary>
        public Expression Expression { get; set; }

        /// <summary>
        /// 和后一个表达式之间的关系
        /// </summary>
        public ExpressionType Relation { get; set; }

        /// <summary>
        /// 存储表达式左边的括号
        /// </summary>
        public string LeftBracket { get; set; }

        /// <summary>
        /// 存储表达式右边的括号
        /// </summary>
        public string RightBracket { get; set; }

        /// <summary>
        /// 可能含有的子表达式
        /// </summary>
        public List<ExpressionInfo> Childs { get; set; } = new List<ExpressionInfo>();
    }
}
