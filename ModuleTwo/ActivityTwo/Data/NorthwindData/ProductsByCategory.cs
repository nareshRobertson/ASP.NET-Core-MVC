using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ActivityTwo {
	[Serializable]
	public partial class ProductsByCategory {
		[XmlAttribute("category")]
		public string CategoryName {
			get; set;
		}
		[XmlAttribute("name")]
		public string ProductName {
			get; set;
		}
		public string QuantityPerUnit {
			get; set;
		}
		public short? UnitsInStock {
			get; set;
		}
		[XmlAttribute("discontinued")]
		public bool Discontinued {
			get; set;
		}
	}
}
