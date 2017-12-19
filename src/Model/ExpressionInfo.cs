using System.Collections.Generic;

namespace ExpressionHelper.Model
{
    public class ExpressionInfo
    {
        public List<ExpressionModel> Expressions { get; } = new List<ExpressionModel>();

        /// <summary>
        /// 存储变量名称,再需要解析变量值的时候获取此字段的值(算是无奈之举)
        /// </summary>
        public string ConstantName { get; set; } = string.Empty;

        public void Add(ExpressionModel model)
        {
            Expressions.Add(model);
        }
    }
}
