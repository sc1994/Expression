using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using static System.String;

namespace ExpressionHelper.Model
{
    public class ExpressionInfo
    {
        public ExpressionInfo()
        {
            Expressions.Add(new ExpressionModel());
        }

        public List<ExpressionModel> Expressions { get; } = new List<ExpressionModel>();

        /// <summary>
        /// 存储变量名称,再需要解析变量值的时候获取此字段的值(算是无奈之举)
        /// </summary>
        public string ConstantName { get; set; } = string.Empty;

        private ExpressionModel Current => Expressions[Expressions.Count - 1];

        private void Add()
        {
            Expressions.Add(new ExpressionModel());
        }

        public void SetObjectAlias(string alias)
        {

        }

        public void SetObjectField(string field)
        {

        }

        /// <summary>
        /// 设置关系
        /// 关系包含了: 方法,等式,表达式之间的条件关系
        /// </summary>
        /// <param name="relation"></param>
        public void SetRelation(string relation)
        {
            var supports = new[]
                           {
                               "Contains",
                               "StartsWith",
                               "EndsWith",
                               "Equals",
                               "And",
                               "AndAlso",
                               "Or",
                               "OrElse",
                               "Equal",
                               "GreaterThan",
                               "GreaterThanOrEqual",
                               "LessThan",
                               "LessThanOrEqual"
                           };
            var coexists = new List<string>
                           {
                               "And",
                               "AndAlso",
                               "Or",
                               "OrElse"
                           };
            if (IsNullOrEmpty(relation))
            {
                throw new Exception(nameof(relation));
            }
            if (!supports.Contains(relation))
            {
                throw new Exception(nameof(relation));
            }
            Console.WriteLine(relation);
            if (coexists.Contains(relation))
            {
                Current.Coexist = relation;
                Add();
                Console.WriteLine();
                return; 
            }
            if (IsNullOrEmpty(Current.Relation))
            {
                Current.Relation = relation;
                return;
            }
            var method = Current.Methods[Current.Methods.Count - 1];
            if (IsNullOrEmpty(method.Method))
            {
                method.Method = relation;
                return;
            }
            Current.Methods.Add(new ExpressionMethod
            {
                Method = relation
            });
        }
    }
}
