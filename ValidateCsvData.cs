using System;
using System.Collections.Generic;
using System.Xml;

namespace TelCo.ColorCoder
{
class ValidateCsvData
{
	public static bool IsFieldLengthValid(int len)
	{
		if(len==3)
		{
			return true;
		}

		return false;
	}
	
	public static bool IsCurrencyValid(int curr1, int curr2)
	{
		if(curr1.Length == 6 && curr2.Length ==6)
		{
			return true;
		}
		
		return false;
	}

	public static bool IsAmountValid(int tradeAmount)
	{
		if(int.TryParse(fields[1], out tradeAmount))
		{
			return true;
		}
		
		return false;
	}

	public static bool IsTradePriceValid(decimal tradePrice)
	{
		if (decimal.TryParse(fields[2], out tradePrice))
		{
			return true;
		}
		
		return false;

	}
	

}
}
