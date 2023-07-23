using System.Xml.Serialization;

namespace DesignPatterns2.Adapter; 

public class XmlGenerator {

    public string GenerateXml(object o) {
        XmlSerializer serializer = new XmlSerializer(o.GetType());
        StringWriter writer = new StringWriter();
        serializer.Serialize(writer, o);
        return writer.ToString();
    }
}