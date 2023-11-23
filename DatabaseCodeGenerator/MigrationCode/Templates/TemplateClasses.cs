using DatabaseCodeGenerator.Schema;

namespace DatabaseCodeGenerator.MigrationCode.Templates
{
    public enum ObjectType
    {
        Struct,
        Class,
        Configuration,
    }

    public partial class SerializableItemTemplate
    {
        public SerializableItemTemplate(DatabaseSchema schema) 
        {
            Schema = schema; 
        }

        protected DatabaseSchema Schema { get; }
    }

    public partial class EnumTemplate
    {
        public EnumTemplate(XmlEnumItem enumData, DatabaseSchema schema) 
        {
            EnumData = enumData; 
            Schema = schema; 
        }

        protected XmlEnumItem EnumData { get; }
        protected DatabaseSchema Schema { get; }
    }

    public partial class SerializableTemplate
    {
        public SerializableTemplate(XmlClassItem objectData, DatabaseSchema schema, ObjectType type, string contextNamespace) 
        {
            ObjectData = objectData; 
            Schema = schema; ObjectType = type; 
            ContextNamespace = contextNamespace; 
        }

        protected XmlClassItem ObjectData { get; }
        protected DatabaseSchema Schema { get; }
        protected ObjectType ObjectType { get; }
        protected string ContextNamespace { get; }
    }

    public partial class DatabaseContentTemplate
    {
        public DatabaseContentTemplate(DatabaseSchema schema, string contextNamespace) 
        {
            Schema = schema; 
            ContextNamespace = contextNamespace; 
        }

        protected DatabaseSchema Schema { get; }
        protected string ContextNamespace { get; }
    }

    public partial class DatabaseUpgraderTemplate
    {
        public DatabaseUpgraderTemplate(VersionList versionList, string contextNamespace)
        {
            VersionList = versionList;
            ContextNamespace = contextNamespace;
        }

        protected VersionList VersionList { get; }
        protected string ContextNamespace { get; }
    }
}
