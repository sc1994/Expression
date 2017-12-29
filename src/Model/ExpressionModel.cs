using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionHelper.Model
{
    public class ExpressionModel
    {

        public ExpressionModel()
        {
            Object = new List<ExpressionObject>
                     {
                         new ExpressionObject()
                     };
            Methods = new List<ExpressionMethod>
                      {
                          new ExpressionMethod()
                      };
            Member = new List<ExpressionMember>
                        {
                            new ExpressionMember()
                        };
        }

        /// <summary>
        /// 调用的方法集合
        /// </summary>
	    public List<ExpressionMethod> Methods { get; }

        /// <summary>
        /// 表达式的具体对象
        /// 例: x => x.Name == "sun"
        /// Alias = "x";
        /// Field = "Name";
        /// </summary>
        public List<ExpressionObject> Object { get; }

        /// <summary>
        /// 对象的成员,这边混乱的指代了 只有包含成员的情况
        /// </summary>
        public List<ExpressionMember> Member { get; }

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
