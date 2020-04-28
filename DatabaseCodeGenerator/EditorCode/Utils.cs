using DatabaseCodeGenerator.Schema;

namespace DatabaseCodeGenerator.EditorCode
{
    public static class Utils
    {
        public static string SerializableClassName(string name) { return name + "Serializable"; }
        public static string DataClassName(XmlClassItem data) { return string.IsNullOrEmpty(data.alias) ? data.name : data.alias; }
        public static string ContentInterfaceName(XmlClassItem data) { return "I" + (string.IsNullOrEmpty(data.alias) ? data.name : data.alias) + "Content"; }
        public static string ObjectGetterName(string name) { return "Get" + name; }
        public static string ObjectIdGetterName(string name) { return "Get" + name + "Id"; }
        public static string ObjectListPropertyName(string name) { return name + "List"; }

        public const string SerializationMethodName = "Save";
        public const string StructSerializationMethodName = "Serialize";
        public const string DatabaseClassName = "Database";

        public const string ImageType = "ImageData";
        public const string AudioClipType = "AudioClipData";

        public const string RootNamespace = "EditorDatabase";
        public const string TypesNamespace = "Model";
        public const string EnumsNamespace = "Enums";
        public const string SerializableNamespace = "Serializable";
        public const string StorageNamespace = "Storage";
        public const string ClassesNamespace = "DataModel";
    }
}
