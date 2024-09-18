using System.Xml.Serialization;

namespace TestWASConnection;

[XmlRoot(ElementName="origin")]
public class Origin { 

	[XmlAttribute(AttributeName="tid")] 
	public int Tid { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="destination")]
public class Destination { 

	[XmlAttribute(AttributeName="index")] 
	public int Index { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public int Id { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="destination-list")]
public class Destinationlist { 

	[XmlElement(ElementName="destination")] 
	public List<Destination> Destination { get; set; } 

	[XmlAttribute(AttributeName="count")] 
	public int Count { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="order")]
public class Order { 

	[XmlElement(ElementName="key")] 
	public string Key { get; set; } 

	[XmlElement(ElementName="origin")] 
	public Origin Origin { get; set; } 

	[XmlElement(ElementName="receive-tad")] 
	public string Receivetad { get; set; } 

	[XmlElement(ElementName="operation-id")] 
	public string Operationid { get; set; } 

	[XmlElement(ElementName="level")] 
	public int Level { get; set; } 

	[XmlElement(ElementName="name")] 
	public string Name { get; set; } 

	[XmlElement(ElementName="operation-name")] 
	public string Operationname { get; set; } 

	[XmlElement(ElementName="caller")] 
	public string Caller { get; set; } 

	[XmlElement(ElementName="location")] 
	public string Location { get; set; } 

	[XmlElement(ElementName="info")] 
	public string Info { get; set; } 

	[XmlElement(ElementName="program")] 
	public string Program { get; set; } 

	[XmlElement(ElementName="status")] 
	public string Status { get; set; } 

	[XmlElement(ElementName="watch-out-tad")] 
	public string Watchouttad { get; set; }

	[XmlElement(ElementName = "finished-tad")]
	public string Finishedtad { get; set; }

	[XmlElement(ElementName="destination-list")] 
	public Destinationlist Destinationlist { get; set; } 

	[XmlAttribute(AttributeName="index")] 
	public int Index { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="order-list")]
public class Orderlist { 

	[XmlElement(ElementName="order")] 
	public List<Order> Order { get; set; } 

	[XmlAttribute(AttributeName="count")] 
	public int Count { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}

[XmlRoot(ElementName="pdu")]
public class Pdu { 

	[XmlElement(ElementName="order-list")] 
	public Orderlist Orderlist { get; set; } 

	[XmlAttribute(AttributeName="xsi")] 
	public string Xsi { get; set; } 

	[XmlAttribute(AttributeName="xsd")] 
	public string Xsd { get; set; } 

	[XmlText] 
	public string Text { get; set; } 
}