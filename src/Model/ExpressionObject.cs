﻿using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionHelper.Model
{
    public class ExpressionObject
    {
        /// <summary>
        /// 对象别名
        /// </summary>
        public string Alias { get; set; } = string.Empty;

        /// <summary>
        /// 对象字段名
        /// </summary>
        public string Field { get; set; } = string.Empty;

        /// <summary>
        /// 有多个值的可能
        /// 例: 数组
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 如果传入的是对象可能会有这个内容
        /// 但是没想到这个能干嘛
        /// </summary>
        public string ValueName { get; set; } = string.Empty;

        /// <summary>
        /// 一元运算符
        /// </summary>
        public string Unary { get; set; } = string.Empty;
    }
}
