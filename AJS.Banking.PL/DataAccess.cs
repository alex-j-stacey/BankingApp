using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AJS.Banking.PL
{
    public static class DataAccess
    {
        // properties
        public static string XMLFilePath { get; set; } = "";

        public static void SaveToXML(Type type, object obj)
        {
            if (XMLFilePath == "") throw new Exception("XMLFilePath not set.");

            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
                writer.Close();
            }
        }

        public static object? LoadFromXML(Type type)
        {
            if (XMLFilePath == "") throw new Exception("XMLFilePath not set.");

            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                object? obj = serializer.Deserialize(reader);
                reader.Close();
                return obj;
            }
        }

    }
