using DatabaseCodeGenerator.Schema;

namespace DatabaseCodeGenerator.GameCode
{
    public static class Utils
    {
        public static string SerializableClassName(string name) { return name + "Serializable"; }
        public static string DataClassName(XmlClassItem data) { return string.IsNullOrEmpty(data.alias) ? data.name : data.alias; }
        public static string ObjectGetterName(string name) { return "Get" + name; }
        public static string ObjectSetterName(string name) { return "Add" + name; }
        public static string ObjectListPropertyName(string name) { return name + "List"; }

        public const string FactoryMethodName = "Create";
        public const string DatabaseClassName = "Database";

        public const string ImageType = "IImageData";
        public const string AudioClipType = "IAudioClipData";
        public const string EmptyImage = "ImageData.Empty";
        public const string EmptyAudioClip = "AudioClipData.Empty";
        public const string VectorType = "UnityEngine.Vector2";

        public const string RootNamespace = "GameDatabase";
        public const string TypesNamespace = "Model";
        public const string EnumsNamespace = "Enums";
        public const string SerializableNamespace = "Serializable";
        public const string StorageNamespace = "Storage";
        public const string ClassesNamespace = "DataModel";
    }
}
