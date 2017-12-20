using System.Collections.Generic;

namespace ExpressionHelper.Model
{
	public class ExpressionMethod
	{
		public string Method { get; set; }

		public List<string> Parameters { get; set; } = new List<string>();
	}
}
