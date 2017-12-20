using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionHelper.Model
{
    public class ExpressionModel
    {
        /// <summary>
        /// 调用的方法集合
        /// </summary>
	    public List<ExpressionMethod> Methods { get; set; } = new List<ExpressionMethod>();

        /// <summary>
        /// 表达式的具体对象
        /// 例: x => x.Name == "sun"
        /// Alias = "x";
        /// Field = "Name";
        /// </summary>
        public List<ExpressionObject> Object { get; set; } = new List<ExpressionObject>();

        /// <summary>
        /// 表达式的关系 能够返回bool 的条件关系 
        /// 例: == / > 或者 方法的 Any(xxxx)  
        /// </summary>
        public string Relation { get; set; }

        /// <summary>
        /// 和后面的表达式之间关系
        /// </summary>
        public string Coexist { get; set; }
    }
}
