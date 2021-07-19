using System;
using System.Collections.Generic;
using System.Xml;

namespace TelCo.ColorCoder
{
class TradeRecord
{
	public string SourceCurrency { get; set; }

	public string DestinationCurrency { get; set; }

	public float Lots { get; set; }

	public decimal Price { get; set; }
}
}
