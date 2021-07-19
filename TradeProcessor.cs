using System;
using System.Collections.Generic;
using System.Xml;

namespace TelCo.ColorCoder
{

	public class TradeProcessor
	{
		public List<string> ReadCSV(System.IO.Stream stream)
		{
			var lines = new List<string>();
            		using (var reader = new System.IO.StreamReader(stream))
            		{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
				    lines.Add(line);
				}
           		}
			return lines
		}


		public static void TransformLinesToTradeRecord(List<string> lines)
		{
			var lineCount = 1;
			var trades = new List<TradeRecord>();
			foreach (var line in lines)
		    	{
				var fields = line.Split(new char[] { ',' });
				var sourceCurrencyCode = fields[0].Substring(0, 3);
		        	var destinationCurrencyCode = fields[3].Substring(3, 3);
				
				if(ValidateCsvData.IsFieldLengthValid(fields.Length) && ValidateCsvData.IsCurrencyValid() && IsAmountValid()&& IsTradePriceValid())
				{
					var trade = new TradeRecord
					{
					    SourceCurrency = sourceCurrencyCode,
					    DestinationCurrency = destinationCurrencyCode,
					    Lots = tradeAmount / LotSize,
					    Price = tradePrice
					   trades.Add(trade);
					};
	
				}
				
				else
				{
					ConsoleLogger.AddToLog(fields)
				}
				lineCount++;
				
				
			}
					
		
		}

		
	}

}
