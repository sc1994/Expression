﻿using System.Collections.Generic;

namespace ExpressionHelper.Model
{
    public class ExpressionInfo
    {
        public List<string> Exps { get; } = new List<string>();

        public void Add(string value)
        {
            //if (value.Length >= 2)
            //{
            Exps.Add(value);
            //}
        }
    }
}
