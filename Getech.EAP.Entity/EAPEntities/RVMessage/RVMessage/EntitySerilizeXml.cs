using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.RVMessage.RVMessage
{
    public static class EntitySerilizeXml
    {
        public static string SerializeOnlyDataLayer<R>(R t)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(t.GetType());

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                XmlWriterSettings settings = new XmlWriterSettings
                {
                    Indent = false,
                    NewLineChars = "\r\n",
                    Encoding = Encoding.UTF8,
                    OmitXmlDeclaration = true
                };
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, t, ns);
                    writer.Close();
                    stream.Position = 0;
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }
        public static string XmlSerializeMessage<R>(R obj, string dataLayer) where R : new()
        {
            var msg = XmlSerialize(obj);
            msg = msg.Replace("<BODY />", dataLayer);
            return msg;
        }
        public static string XmlSerialize(object o)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializeInternal(stream, o, Encoding.UTF8);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        private static void XmlSerializeInternal(Stream stream, object o, Encoding encoding)
        {
            if (o == null)
            {
                throw new ArgumentNullException("o");
            }
            if (encoding == null)
            {
                throw new ArgumentNullException("encoding");
            }
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = false;
            settings.NewLineChars = "\r\n";
            settings.Encoding = encoding;
            settings.IndentChars = "    ";
            using (XmlWriter writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, o, ns);
                writer.Close();
            }
        }
        public static T Deserialize<T>(string s) where T : class
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(s);

            if (typeof(T) == typeof(Header))
            {
                var header = doc.SelectSingleNode("MESSAGE").SelectSingleNode("HEADER");
                return ConvertNode<T>(header);
            }
            else if (typeof(T) == typeof(Return))
            {
                var ret = doc.SelectSingleNode("MESSAGE").SelectSingleNode("RETURN");
                return ConvertNode<T>(ret);
            }
            else
            {
                var body = doc.SelectSingleNode("MESSAGE").SelectSingleNode("BODY");
                return ConvertNode<T>(body);
            }
        }
        public static T TimeOutDeserialize<T>(string s) where T : class
        {
            XmlDocument xd = new XmlDocument();
            xd.LoadXml(s);
            if (typeof(T) == typeof(Header))
            {
                var header = xd.SelectSingleNode("Message").SelectSingleNode("Header");
                return ConvertNode<T>(header);
            }
            else if (typeof(T) == typeof(Return))
            {
                var ret = xd.SelectSingleNode("Message").SelectSingleNode("RETURN");
                return ConvertNode<T>(ret);
            }
            else
            {
                var body = xd.SelectSingleNode("Message").SelectSingleNode("BODY");
                return ConvertNode<T>(body);
            }
        }
        private static T ConvertNode<T>(XmlNode node) where T : class
        {
            MemoryStream stm = new MemoryStream();
            StreamWriter stw = new StreamWriter(stm);
            stw.Write(node.OuterXml);
            stw.Flush();
            stm.Position = 0;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            T result = (ser.Deserialize(stm) as T);
            return result;
        }
        /// <summary> 
        /// 反序列化Header和Return
        /// </summary> 
        public static void DeserializeHeaderAndReturn(string s, out Header header, out Return ret)
        {
            XmlDocument xd = new XmlDocument();
            Return ss = null;
            xd.LoadXml(s);
            var temp = xd.SelectSingleNode("MESSAGE").SelectSingleNode("HEADER");
            header = ConvertNode<Header>(temp);
            var temp2 = xd.SelectSingleNode("MESSAGE").SelectSingleNode("RETURN");
            if (temp2 != null)
            {
                ss = ConvertNode<Return>(temp2);
            }
            ret = ss;
        }

        //获得header 和return
        public static void DeserializeHeaderAndReturn2(XElement message, out Header header, out Return ret)
        {
            header = new Header();
            header.MESSAGENAME = message.Element("HEADER").Element("MESSAGENAME").Value.ToString();
            header.TRANSACTIONID = message.Element("HEADER").Element("TRANSACTIONID").Value.ToString();
            header.REPLYSUBJECTNAME = message.Element("HEADER").Element("REPLYSUBJECTNAME").Value.ToString();
            header.EVENTUSER = message.Element("HEADER").Element("EVENTUSER").Value.ToString();
            header.EVENTCOMMENT = message.Element("HEADER").Element("EVENTCOMMENT").Value.ToString();
            header.LANGUAGE = message.Element("HEADER").Element("LANGUAGE").Value.ToString();
            header.TERMINAL = message.Element("HEADER").Element("TERMINAL").Value.ToString();
            ret = new Return();
            ret.RETURNCODE = message.Element("RETURN").Element("RETURNCODE").Value.ToString();
            ret.RETURNMESSAGE = message.Element("RETURN").Element("RETURNMESSAGE").Value.ToString();
        }

        public static void DeserializeTimeOutHeaderAndReturn(string s, out Header header, out Return ret)
        {
            XmlDocument xd = new XmlDocument();
            Return ss = null;
            xd.LoadXml(s);
            var temp = xd.SelectSingleNode("Message").SelectSingleNode("Header");
            header = ConvertNode<Header>(temp);
            var temp2 = xd.SelectSingleNode("Message").SelectSingleNode("RETUN");
            if (temp2 != null)
            {
                ss = ConvertNode<Return>(temp2);
            }
            ret = ss;

        }
   
    }
}
