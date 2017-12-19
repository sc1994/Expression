using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using ExpressionHelper.Helpers;
using ExpressionHelper.Model;

namespace ExpressionHelper
{
    public class HelperTool
    {
        private static readonly string[] ExpressionHelpers =
        {
            "BinaryExpression",
            "MemberExpression",
            "ParameterExpression",
            "ConstantExpression",
            "MethodCallExpression",
            "LambdaExpression",
            "UnaryExpression",
            "NewArrayExpression"
        };

        private static readonly Dictionary<string, IExpressionHelper> Ports = InitPorts();

        public static void AddWhere(Expression exp, ExpressionInfo arg)
        {
            if (exp != null)
            {
                GetPort(exp).AddWhere(exp, arg);
            }
        }

        /// <summary>
        /// 初始化接口实例
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, IExpressionHelper> InitPorts()
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

        /// <summary>
        /// 获取一个对应类型的接口实例
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        private static IExpressionHelper GetPort(Expression exp)
        {
            var type = SwitchExpression(exp);
            //Console.WriteLine(type);
            //Log(exp.ToString(), type);
            return Ports[type];
        }

        /// <summary>
        /// 获取表达的类型描述
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        private static string SwitchExpression(Expression exp)
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

        public static void Log(object body, string type)
        {
            var path = "D:\\Self\\Expression" + "\\log\\" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            var str = new StringBuilder();
            str.AppendLine("----------------------------------------------------------");
            str.AppendLine("时间:" + DateTime.Now);
            str.AppendLine("表达式类型:" + type);
            str.AppendLine("表达式Body:" + body);
            str.AppendLine("----------------------------------------------------------\r\n\r\n");
            try
            {
                Console.Write(str);
                File.AppendAllText(path, str.ToString(), Encoding.UTF8);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
