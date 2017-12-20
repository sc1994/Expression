using System;
using System.Collections.Generic;
using System.Linq;
using static System.String;

namespace ExpressionHelper.Model
{
    public class ExpressionInfo
    {
        public ExpressionInfo()
        {
            Expressions = new List<ExpressionModel>
                          {
                              new ExpressionModel()
                          };

        }

        public List<ExpressionModel> Expressions { get; }

        /// <summary>
        /// 存储变量名称,再需要解析变量值的时候获取此字段的值(算是无奈之举)
        /// </summary>
        public string ConstantName { get; set; } = Empty;

        private ExpressionModel Current => Expressions[Expressions.Count - 1];

        private ExpressionObject CurrentObject => Current.Object[Current.Object.Count - 1];

        private void Add()
        {
            Expressions.Add(new ExpressionModel());
        }


        public void SetObjectAlias(string alias)
        {
            if (IsNullOrEmpty(alias))
            {
                throw new Exception(nameof(alias));
            }
            CurrentObject.Alias = alias;
        }

        /// <summary>
        /// 设置字段,或者值的别名
        /// </summary>
        /// <param name="obj"></param>
        public void SetObject(string obj)
        {
            if (IsNullOrEmpty(obj))
            {
                throw new Exception(nameof(obj));
            }
            if (IsNullOrEmpty(CurrentObject.Field))
            {
                CurrentObject.Field = obj;
                return;
            }
            if (IsNullOrEmpty(CurrentObject.ValueName))
            {
                CurrentObject.ValueName = obj;
                Current.Object.Add(new ExpressionObject());
                return;
            }
            Current.Object.Add(new ExpressionObject());
            CurrentObject.ValueName = obj;
        }

        /// <summary>
        /// 设置表达式的值
        /// </summary>
        /// <param name="value"></param>
        public void SetObjectValue(object value)
        {
            if (value == null)
            {
                throw new Exception(nameof(value));
            }
            CurrentObject.Value.Add(value);
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
                               "Trim",
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
