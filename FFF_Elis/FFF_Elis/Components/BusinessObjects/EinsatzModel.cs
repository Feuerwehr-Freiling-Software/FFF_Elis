using System.Xml.Serialization;

namespace FFF_Elis.Components.BusinessObjects;

[XmlRoot(ElementName="einsatztyp")]
public class Einsatztyp { 

	[XmlAttribute(AttributeName="id")] 
	public string? Id { get; set; } 

	[XmlText] 
	public string? Text { get; set; } 
}

[XmlRoot(ElementName="einsatzsubtyp")]
public class Einsatzsubtyp { 

	[XmlAttribute(AttributeName="id")] 
	public string? Id { get; set; } 

	[XmlText] 
	public string? Text { get; set; } 
}

[XmlRoot(ElementName="adresse")]
public class Adresse { 

	[XmlElement(ElementName="default")] 
	public string? Default { get; set; } 

	[XmlElement(ElementName="earea")] 
	public string? Earea { get; set; } 

	[XmlElement(ElementName="emun")] 
	public string? Emun { get; set; } 

	[XmlElement(ElementName="efeanme")] 
	public object? Efeanme { get; set; } 

	[XmlElement(ElementName="estnum")] 
	public object? Estnum { get; set; } 

	[XmlElement(ElementName="ecompl")] 
	public string? Ecompl { get; set; } 
}

[XmlRoot(ElementName="bezirk")]
public class Bezirk { 

	[XmlAttribute(AttributeName="id")] 
	public string? Id { get; set; } 

	[XmlText] 
	public string? Text { get; set; } 
}

[XmlRoot(ElementName="einheit")]
public class Einheit { 

	[XmlAttribute(AttributeName="id")] 
	public string? Id { get; set; } 

	[XmlText] 
	public string? Text { get; set; } 
}

[XmlRoot(ElementName="einheiten")]
public class Einheiten { 

	[XmlElement(ElementName="einheit")] 
	public List<Einheit> Einheit { get; set; } 
}

[XmlRoot(ElementName="einsatz")]
public class Einsatz { 

	[XmlElement(ElementName="num1")] 
	public string? Num1 { get; set; } 

	[XmlElement(ElementName="startzeit")] 
	public string? Startzeit { get; set; } 

	[XmlElement(ElementName="inzeit")] 
	public object? Inzeit { get; set; } 

	[XmlElement(ElementName="status")] 
	public string? Status { get; set; } 

	[XmlElement(ElementName="lng")] 
	public double Lng { get; set; } 

	[XmlElement(ElementName="lat")] 
	public double Lat { get; set; } 

	[XmlElement(ElementName="alarmstufe")] 
	public int Alarmstufe { get; set; } 

	[XmlElement(ElementName="einsatzart")] 
	public string? Einsatzart { get; set; } 

	[XmlElement(ElementName="einsatzorg")] 
	public string? Einsatzorg { get; set; } 

	[XmlElement(ElementName="einsatztyp")] 
	public Einsatztyp Einsatztyp { get; set; } 

	[XmlElement(ElementName="einsatzsubtyp")] 
	public Einsatzsubtyp Einsatzsubtyp { get; set; } 

	[XmlElement(ElementName="alarmtext")] 
	public string? Alarmtext { get; set; } 

	[XmlElement(ElementName="adresse")] 
	public Adresse Adresse { get; set; } 

	[XmlElement(ElementName="bezirk")] 
	public Bezirk Bezirk { get; set; } 

	[XmlElement(ElementName="einheiten")] 
	public Einheiten Einheiten { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public string? Id { get; set; } 

	[XmlText] 
	public string? Text { get; set; } 
}

[XmlRoot(ElementName="einsaetze")]
public class Einsaetze { 

	[XmlElement(ElementName="einsatz")] 
	public List<Einsatz> Einsatz { get; set; } 
}

[XmlRoot(ElementName="usedat")]
public class Usedat { 

	[XmlElement(ElementName="startzeit")] 
	public string? Startzeit { get; set; } 

	[XmlElement(ElementName="inzeit")] 
	public object? Inzeit { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public string? Id { get; set; } 

	[XmlText] 
	public string? Text { get; set; } 
}

[XmlRoot(ElementName="resource")]
public class Resource { 

	[XmlElement(ElementName="usedat")] 
	public List<Usedat>? Usedat { get; set; } 

	[XmlAttribute(AttributeName="name")] 
	public string? Name { get; set; } 

	[XmlAttribute(AttributeName="id")] 
	public int Id { get; set; } 

	[XmlText] 
	public string? Text { get; set; } 

	[XmlElement(ElementName="bezirk")] 
	public Bezirk Bezirk { get; set; } 

	[XmlElement(ElementName="www")] 
	public string? Www { get; set; } 

	[XmlElement(ElementName="lng")] 
	public string Lng { get; set; } 

	[XmlElement(ElementName="lat")] 
	public string Lat { get; set; } 
}

[XmlRoot(ElementName="resources")]
public class Resources { 

	[XmlElement(ElementName="resource")] 
	public List<Resource> Resource { get; set; } 
}

[XmlRoot(ElementName="webext2")]
public class Webext2 { 

	[XmlElement(ElementName="scope")] 
	public string? Scope { get; set; } 

	[XmlElement(ElementName="pubDate")] 
	public string? PubDate { get; set; } 

	[XmlElement(ElementName="einsaetze")] 
	public Einsaetze Einsaetze { get; set; } 

	[XmlElement(ElementName="resources")] 
	public Resources Resources { get; set; } 

	[XmlAttribute(AttributeName="version")] 
	public string? Version { get; set; } 

	[XmlText] 
	public string? Text { get; set; } 
}