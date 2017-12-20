using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using ExpressionHelper.Model;

namespace ExpressionHelper.Helpers
{
    public class ConstantExpressionHelper : BaseExpressionHelper<ConstantExpression>
    {
        public override void AddWhere(ConstantExpression exp, ExpressionInfo arg)
        {
            if (exp.Type.Name.Contains("DisplayClass"))
            {
                var type = exp.Value.GetType();
                var value = type.InvokeMember(arg.ConstantName, BindingFlags.GetField, null, exp.Value, null);
                arg.SetObjectValue(value); 
            }
            else
            {
                arg.SetObjectValue(exp.Value);
            }

        }

        /// <summary>
        /// 这边是为了能打印出结果,
        /// 如果用做sql,再使用Dapper 做ORM框架时,无需解析内容,直接放入object就可以了
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private object GetValue(object value)
        {
            switch (value)
            {
                case int _:
                case uint _:
                case short _:
                case ushort _:
                case long _:
                case ulong _:
                case decimal _:
                case float _:
                case double _:
                case char _:
                case string _:
                    return value;
                case int[] _:
                    return string.Join(",", value as int[] ?? throw new InvalidOperationException());
                case uint[] _:
                    return string.Join(",", value as uint[] ?? throw new InvalidOperationException());
                case short[] _:
                    return string.Join(",", value as short[] ?? throw new InvalidOperationException());
                case ushort[] _:
                    return string.Join(",", value as ushort[] ?? throw new InvalidOperationException());
                case long[] _:
                    return string.Join(",", value as long[] ?? throw new InvalidOperationException());
                case ulong[] _:
                    return string.Join(",", value as ulong[] ?? throw new InvalidOperationException());
                case decimal[] _:
                    return string.Join(",", value as decimal[] ?? throw new InvalidOperationException());
                case float[] _:
                    return string.Join(",", value as float[] ?? throw new InvalidOperationException());
                case double[] _:
                    return string.Join(",", value as double[] ?? throw new InvalidOperationException());
                case char[] _:
                    return string.Join(",", value as char[] ?? throw new InvalidOperationException());
                case string[] _:
                    return string.Join(",", value as string[] ?? throw new InvalidOperationException());
                case List<int> _:
                    return string.Join(",", value as List<int> ?? throw new InvalidOperationException());
                case List<uint> _:
                    return string.Join(",", value as List<uint> ?? throw new InvalidOperationException());
                case List<short> _:
                    return string.Join(",", value as List<short> ?? throw new InvalidOperationException());
                case List<ushort> _:
                    return string.Join(",", value as List<ushort> ?? throw new InvalidOperationException());
                case List<long> _:
                    return string.Join(",", value as List<long> ?? throw new InvalidOperationException());
                case List<ulong> _:
                    return string.Join(",", value as List<ulong> ?? throw new InvalidOperationException());
                case List<decimal> _:
                    return string.Join(",", value as List<decimal> ?? throw new InvalidOperationException());
                case List<float> _:
                    return string.Join(",", value as List<float> ?? throw new InvalidOperationException());
                case List<double> _:
                    return string.Join(",", value as List<double> ?? throw new InvalidOperationException());
                case List<char> _:
                    return string.Join(",", value as List<char> ?? throw new InvalidOperationException());
                case List<string> _:
                    return string.Join(",", value as List<string> ?? throw new InvalidOperationException());
                default:
                    throw new Exception("-----不支持的类型, 请自行添加类型支持-----\r\n" + nameof(value));
            }
        }
    }
}
