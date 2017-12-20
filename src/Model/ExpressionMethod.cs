using System.Collections.Generic;

namespace ExpressionHelper.Model
{
	public class ExpressionMethod
	{
		public string Method { get; set; }

		public List<object> Parameters { get; set; } = new List<object>();
	}
}
