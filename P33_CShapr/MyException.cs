using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P33_CShapr
{

	[Serializable]
	public class MyAppException : Exception
	{
		
		public MyAppException() {}
		public MyAppException(string message) : base(message) { }
		public MyAppException(string message, Exception inner) : base(message, inner) { }
		protected MyAppException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
