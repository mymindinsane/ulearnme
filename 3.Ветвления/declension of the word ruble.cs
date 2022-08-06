using System;

namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
			
			if ((count % 10 == 0) ||(count %10 >= 5) || ((count% 100>=10) && (count%100 <=20)))
				return "рублей";
			else if (count % 10 == 1)
				return "рубль";
			else
				return "рубля";


		}
	}
}

