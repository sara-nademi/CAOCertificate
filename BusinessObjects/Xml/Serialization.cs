namespace CAOCertificate.BusinessObjects.Xml
{
    public class Serialization
    {
        public static string Serialize<T>(T @object)
        {
            string xml;

            var serializer = new System.Xml.Serialization.XmlSerializer(typeof (T));
            var stream = new System.IO.MemoryStream();

            serializer.Serialize(stream, @object);

            byte[] buffer = stream.ToArray();

            xml = System.Text.Encoding.UTF8.GetString(buffer, 0, buffer.Length);

            return xml;
        }

        public static T Deserialize<T>(string xml)
        {
            var serialization = new System.Xml.Serialization.XmlSerializer(typeof (T));
            var stream = new System.IO.MemoryStream();

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(xml);

            stream.Write(buffer, 0, buffer.Length);
            stream.Seek(0, System.IO.SeekOrigin.Begin);

            T @object = (T) serialization.Deserialize(stream);

            return @object;
        }
    }
}