using System;
using System.Collections.Generic;
using System.Xml;

namespace TelCo.ColorCoder
{
class Program
{
	public static void Test(csvfile)
	{

	   TradeProcessor _tradeProcessor = new TradeProcessor();
	   List<string>() lines=_tradeProcessor.ReadCSV(new System.IO.StreamReader(csvfile).BaseStream);
	   var trades = new List<TradeRecord>();
           trades=TransformLinesToTradeRecord(lines);
           XmlWriter xml_wite= new XmlWriter();
           xml_wite.WriteToXML(trades);

	}

	static void Main(string[] args)
	{
	   csv_file="TradeRecords.csv";
	   
	   Test(csv_file);
	}
}
}
