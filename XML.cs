using System;  
using System.Xml;  
namespace ReadingXML2 {  
    class Class1 {  
        static void Main(string[] args) {  
		    XmlWriterSettings settings = new XmlWriterSettings();
		    settings.Indent = true;
		    XmlWriter writer = XmlWriter.Create("Kutubxonalar.xml", settings);
		    writer.WriteStartDocument();
		    writer.WriteComment("Bu yerda FISh,Tug'ilgan yili,O'qigan kitobi,Viloyati mavjud");
		    writer.WriteStartElement("Talaba");
		    writer.WriteAttributeString("Id", "001");
		    writer.WriteAttributeString("Ismi", "Nafisa");
		    writer.WriteAttributeString("Familiyasi", "Abdunazarova");
		    writer.WriteAttributeString("Sharifi", "Ro'zinazar qizi");
		    writer.WriteElementString("Tugilgan_kuni", "16.11.2000");
		    writer.WriteStartElement("Tugilgan_joyi");
		    writer.WriteElementString("Viloyati", "Toshkent");
		    writer.WriteElementString("Tumani", "Bo'ka");
			writer.WriteEndElement();
		    writer.WriteElementString("Uqigan_kitobi", "Tinchlik romani");
		    writer.WriteEndDocument();
		    writer.Flush();
		    writer.Close(); 
        }  
    }  
}   