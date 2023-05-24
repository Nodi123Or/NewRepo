using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample.Service
{
	public static class MiddleStringFinder
	{
		public static string getMiddle(string inputText)
		{
			if (0 >= inputText.Length || 1000 <= inputText.Length)
			{
				throw new Exception("Input string is out of the alowed scope  0 < str < 1000 !!");
			}

			if (inputText.Length % 2 == 0)
			{
				return inputText.Substring((inputText.Length / 2) - 1, 2);
			}
			else
			{
				return inputText.Substring((inputText.Length / 2), 1);
			}
		}
	}
}
