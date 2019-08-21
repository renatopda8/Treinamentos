using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    public class GeradorDeXml<T>
    {
        public string GeraXml(T toSerialize)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, toSerialize);
            return stringWriter.ToString();
        }
    }
}