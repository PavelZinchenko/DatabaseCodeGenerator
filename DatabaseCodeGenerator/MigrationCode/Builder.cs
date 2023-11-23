using System;
using DatabaseCodeGenerator.MigrationCode.Templates;
using DatabaseCodeGenerator.Schema;
using DatabaseCodeGenerator.Utils;

namespace DatabaseCodeGenerator.MigrationCode
{
    public class Builder
    {
        public Builder(CodeWriter codeWriter, VersionList versionList, string schemaRootFolder, string contextNamespace)
        {
            _codeWriter = codeWriter;
            _versionList = versionList;
            _schemaRootFolder = schemaRootFolder;
            _contextNamespace = contextNamespace;
        }

        public void Build()
        {
            _codeWriter.DeleteGeneratedFiles();

            GenerateCommonCode();

            foreach (var version in _versionList.Items)
            {
                GenerateSchemaCode(DatabaseSchema.Load(_schemaRootFolder, version));
            }
        }

        private void GenerateCommonCode()
        {
            _codeWriter.Write(string.Empty, "DatabaseException", new DatabaseExceptionTemplate().TransformText());
            _codeWriter.Write(string.Empty, Utils.DatabaseUpgraderClassName,
                new DatabaseUpgraderTemplate(_versionList, _contextNamespace).TransformText());
        }

        private void GenerateSchemaCode(DatabaseSchema schema)
        {
            var rootNamespace = schema.Version.ToNamespace();
            _codeWriter.Write(CombineNameSpace(rootNamespace, Utils.SerializableNamespace), "SerializableItem", 
                new SerializableItemTemplate(schema).TransformText());
            _codeWriter.Write(CombineNameSpace(rootNamespace, Utils.StorageNamespace), "DatabaseContent", 
                new DatabaseContentTemplate(schema, _contextNamespace).TransformText());

            foreach (var item in schema.Enums)
                GenerateEnum(schema, item, rootNamespace);

            foreach (var item in schema.Objects)
                GenerateSerializableClass(schema, item, ObjectType.Class, rootNamespace);

            foreach (var item in schema.Structs)
                GenerateSerializableClass(schema, item, ObjectType.Struct, rootNamespace);

            foreach (var item in schema.Configurations)
                GenerateSerializableClass(schema, item, ObjectType.Configuration, rootNamespace);
        }

        private void GenerateEnum(DatabaseSchema schema, XmlEnumItem item, string ns)
        {
            var template = new EnumTemplate(item, schema);
            var data = template.TransformText();

            _codeWriter.Write(CombineNameSpace(ns, Utils.EnumsNamespace), item.name, data);
        }

        private void GenerateSerializableClass(DatabaseSchema schema, XmlClassItem item, ObjectType type, string ns)
        {
            var template = new SerializableTemplate(item, schema, type, _contextNamespace);
            var data = template.TransformText();

            _codeWriter.Write(CombineNameSpace(ns, Utils.SerializableNamespace), item.name, data);
        }

        private static string CombineNameSpace(string first, string second) 
        {
            if (string.IsNullOrEmpty(first))
                return second;
            if (string.IsNullOrEmpty(second))
                return first;
            return first + "." + second;
        }

        private readonly CodeWriter _codeWriter;
        private readonly VersionList _versionList;
        private readonly string _schemaRootFolder;
        private readonly string _contextNamespace;
    }
}
