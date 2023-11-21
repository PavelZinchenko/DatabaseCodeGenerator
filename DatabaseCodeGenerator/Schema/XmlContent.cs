using System.Collections.Generic;
using System.Xml.Serialization;

namespace DatabaseCodeGenerator.Schema
{
    [XmlRoot("data")]
    public class XmlTypeInfo
    {
        [XmlAttribute]
        public string type = string.Empty;
        [XmlAttribute]
        public string name = string.Empty;
        [XmlText]
        public string value = string.Empty;
    }

    public class XmlKeyValuePair
    {
        [XmlAttribute]
        public string name = string.Empty;
        [XmlText]
        public string value = string.Empty;
    }

    [XmlRoot("data")]
    public class XmlEnumItem
    {
        [XmlAttribute]
        public string name = string.Empty;
        [XmlElement("item")]
        public List<XmlKeyValuePair> items = new List<XmlKeyValuePair>();
    }

    public class XmlClassMember
    {
        [XmlAttribute]
        public string name = string.Empty;
        [XmlAttribute]
        public string type = string.Empty;
        [XmlAttribute]
        public string typeid = string.Empty;
        [XmlAttribute]
        public string minvalue = string.Empty;
        [XmlAttribute]
        public string maxvalue = string.Empty;
        [XmlAttribute]
        public string @default = string.Empty;
        [XmlAttribute]
        public string alias = string.Empty;
        [XmlAttribute("case")]
        public string caseValue = string.Empty;
        [XmlAttribute]
        public string options = string.Empty;
    }

    [XmlRoot("data")]
    public class XmlClassItem
    {
        [XmlAttribute]
        public string name = string.Empty;
        [XmlAttribute]
        public string alias = string.Empty;
        [XmlAttribute]
        public string typeid = string.Empty;
        [XmlAttribute("switch")]
        public string switchEnum = string.Empty;
        [XmlAttribute("options")]
        public string options = string.Empty;
        [XmlElement("member")]
        public List<XmlClassMember> members = new List<XmlClassMember>();
    }
}
