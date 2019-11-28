namespace DatabaseCodeGenerator.GameCode
{
    public static class Utils
    {
        public static string SerializableClassName(string name) { return name + "Serializable"; }
        public static string DataClassName(string name) { return name + "Data"; }
        public static string ObjectGetterName(string name) { return "Get" + name; }
        public static string ObjectSetterName(string name) { return "Add" + name; }
        public static string ObjectListPropertyName(string name) { return name + "List"; }

        public const string FactoryMethodName = "Create";
        public const string DatabaseClassName = "Database";

        public const string RootNamespace = "GameDatabase";
        public const string TypesNamespace = "Types";
        public const string EnumsNamespace = "Enums";
        public const string SerializableNamespace = "Serializable";
        public const string StorageNamespace = "Storage";
        public const string ClassesNamespace = "Classes";
    }
}
