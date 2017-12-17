using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ExpressionHelper.Helpers;

namespace ExpressionHelper
{
    class HelperTool
    {
        private static readonly string[] ExpressionHelpers = { "BinaryExpression" };

        private static readonly Dictionary<string, IExpressionHelper> Ports = InitPorts();

        public static Dictionary<string, IExpressionHelper> InitPorts()
        {
            var ports = new Dictionary<string, IExpressionHelper>();
            var nameSpace = typeof(HelperTool).Namespace;
            foreach (var exp in ExpressionHelpers)
            {
                var type = Type.GetType($"{nameSpace}.Helpers.{exp}Helper");
                ports.Add(exp, (IExpressionHelper)Activator.CreateInstance(type ?? throw new InvalidOperationException()));
            }
            return ports;
        }

        public static IExpressionHelper GetPort(string expType)
        {
            return Ports[expType];
        }

        public static string SwitchExpression(Expression exp)
        {
            switch (exp)
            {
                case BinaryExpression _:
                    return "BinaryExpression";
                case BlockExpression _:
                    return "BlockExpression";
                case ConditionalExpression _:
                    return "ConditionalExpression";
                case ConstantExpression _:
                    return "ConstantExpression";
                case DebugInfoExpression _:
                    return "DebugInfoExpression";
                case DefaultExpression _:
                    return "DefaultExpression";
                case DynamicExpression _:
                    return "DynamicExpression";
                case GotoExpression _:
                    return "GotoExpression";
                case IndexExpression _:
                    return "IndexExpression";
                case InvocationExpression _:
                    return "InvocationExpression";
                case LabelExpression _:
                    return "LabelExpression";
                case LambdaExpression _:
                    return "LambdaExpression";
                case ListInitExpression _:
                    return "ListInitExpression";
                case LoopExpression _:
                    return "LoopExpression";
                case MemberExpression _:
                    return "MemberExpression";
                case MemberInitExpression _:
                    return "MemberInitExpression";
                case MethodCallExpression _:
                    return "MethodCallExpression";
                case NewArrayExpression _:
                    return "NewArrayExpression";
                case NewExpression _:
                    return "NewExpression";
                case ParameterExpression _:
                    return "ParameterExpression";
                case RuntimeVariablesExpression _:
                    return "RuntimeVariablesExpression";
                case SwitchExpression _:
                    return "SwitchExpression";
                case TryExpression _:
                    return "TryExpression";
                case TypeBinaryExpression _:
                    return "TypeBinaryExpression";
                case UnaryExpression _:
                    return "UnaryExpression";
                default:
                    throw new Exception(nameof(exp));
            }
            
        }
    }
}
