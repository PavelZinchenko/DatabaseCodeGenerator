﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace DatabaseCodeGenerator.MigrationCode.Templates
{
    using Schema;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class DatabaseContentTemplate : DatabaseContentTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 1 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//-------------------------------------------------------------------------------"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 2 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//                                                                               "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 3 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    This code was automatically generated.                                     "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 4 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    Changes to this file may cause incorrect behavior and will be lost if      "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 5 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    the code is regenerated.                                                   "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 6 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//                                                                               "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 7 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//-------------------------------------------------------------------------------"));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.Collections.Generic;\r\nusing ");
            
            #line 7 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Context.Namespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 7 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.StorageNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 8 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Context.Namespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 8 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.TypesNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 9 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 9 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Schema.Version.ToNamespace()));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 9 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.EnumsNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 10 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 10 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Schema.Version.ToNamespace()));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 10 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\nnamespace ");
            
            #line 12 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 12 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Schema.Version.ToNamespace()));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 12 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.StorageNamespace));
            
            #line default
            #line hidden
            this.Write(@"
{
    public class DatabaseContent : IContentLoader
    {
        public DatabaseContent(IJsonSerializer jsonSerializer, IDataStorage storage)
        {
            _serializer = jsonSerializer;
            storage?.LoadContent(this);
        }

        public int VersionMajor 
        {
            get => ");
            
            #line 24 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DatabaseSettings));
            
            #line default
            #line hidden
            this.Write(" != null ? ");
            
            #line 24 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DatabaseSettings));
            
            #line default
            #line hidden
            this.Write(".DatabaseVersion : ");
            
            #line 24 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Schema.Version.Major));
            
            #line default
            #line hidden
            this.Write(";\r\n            set => Create");
            
            #line 25 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DatabaseSettings));
            
            #line default
            #line hidden
            this.Write("().");
            
            #line 25 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.VersionMajor));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n        }\r\n\r\n        public int VersionMinor\r\n        {\r\n            g" +
                    "et => ");
            
            #line 30 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DatabaseSettings));
            
            #line default
            #line hidden
            this.Write(" != null ? ");
            
            #line 30 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DatabaseSettings));
            
            #line default
            #line hidden
            this.Write(".DatabaseVersionMinor : 0;\r\n            set => Create");
            
            #line 31 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.DatabaseSettings));
            
            #line default
            #line hidden
            this.Write("().");
            
            #line 31 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.VersionMinor));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n        }\r\n\r\n        public void LoadJson(string name, string content)" +
                    "\r\n        {\r\n            var item = _serializer.FromJson<SerializableItem>(conte" +
                    "nt);\r\n            var type = item.ItemType;\r\n\r\n");
            
            #line 39 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

			var first = true;
			foreach (var item in Schema.Objects)
            {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 44 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(first ? "if" : "else if"));
            
            #line default
            #line hidden
            this.Write(" (type == ");
            
            #line 44 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Constants.ItemTypeEnum + "." + item.name));
            
            #line default
            #line hidden
            this.Write(")\r\n            {\r\n                var data = _serializer.FromJson<");
            
            #line 46 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(item.name)));
            
            #line default
            #line hidden
            this.Write(">(content);\r\n                data.FileName = name;\r\n                ");
            
            #line 48 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ObjectListPropertyName(item.name)));
            
            #line default
            #line hidden
            this.Write(".Add(data);\r\n            }\r\n");
            
            #line 50 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

				first = false;
            }

			foreach (var item in Schema.Configurations)
            {

            
            #line default
            #line hidden
            this.Write("            ");
            
            #line 57 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(first ? "if" : "else if"));
            
            #line default
            #line hidden
            this.Write(" (type == ");
            
            #line 57 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Constants.ItemTypeEnum + "." + item.name));
            
            #line default
            #line hidden
            this.Write(")\r\n            {\r\n                var data = _serializer.FromJson<");
            
            #line 59 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(item.name)));
            
            #line default
            #line hidden
            this.Write(">(content);\r\n                data.FileName = name;\r\n                ");
            
            #line 61 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.name));
            
            #line default
            #line hidden
            this.Write(" = data;\r\n            }\r\n");
            
            #line 63 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

				first = false;
            }
			if (!first)
            {

            
            #line default
            #line hidden
            this.Write("            else\r\n            {\r\n                throw new DatabaseException(\"Unk" +
                    "nown file type - \" + type + \"(\" + name + \")\");\r\n            }\r\n");
            
            #line 73 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

			}

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n        public void Export(IContentLoader contentLoader)\r\n        {\r" +
                    "\n");
            
            #line 80 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

		    foreach (var item in Schema.Objects)
            {

            
            #line default
            #line hidden
            this.Write("            foreach (var item in ");
            
            #line 84 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ObjectListPropertyName(item.name)));
            
            #line default
            #line hidden
            this.Write(")\r\n                contentLoader.LoadJson(item.FileName, _serializer.ToJson(item)" +
                    ");\r\n");
            
            #line 86 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

            }

		    foreach (var item in Schema.Configurations)
            {

            
            #line default
            #line hidden
            this.Write("            if (");
            
            #line 92 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.name));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n                contentLoader.LoadJson(");
            
            #line 93 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.name));
            
            #line default
            #line hidden
            this.Write(".FileName, _serializer.ToJson(");
            
            #line 93 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.name));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 94 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

            }

            
            #line default
            #line hidden
            this.Write(@"            foreach (var item in _images)
                contentLoader.LoadImage(item.Key, item.Value);
            foreach (var item in _audioClips)
                contentLoader.LoadAudioClip(item.Key, item.Value);
            foreach (var item in _localizations)
                contentLoader.LoadLocalization(item.Key, item.Value);
        }

		public void LoadLocalization(string name, string data)
        {
            _localizations.Add(name, data);
        }

        public void LoadImage(string name, ");
            
            #line 110 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ImageType));
            
            #line default
            #line hidden
            this.Write(" image)\r\n        {\r\n            _images.Add(name, image);\r\n        }\r\n\r\n        p" +
                    "ublic void LoadAudioClip(string name, ");
            
            #line 115 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.AudioClipType));
            
            #line default
            #line hidden
            this.Write(" audioClip)\r\n        {\r\n            _audioClips.Add(name, audioClip);\r\n        }\r" +
                    "\n\r\n");
            
            #line 120 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

		foreach (var item in Schema.Configurations)
        {

            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 124 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(item.name) + " " + item.name));
            
            #line default
            #line hidden
            this.Write(" { get; private set; }\r\n");
            
            #line 125 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 129 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

		foreach (var item in Schema.Configurations)
        {

            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 133 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture($"{Utils.SerializableClassName(item.name)} Create{item.name}() => {item.name} ?? ({item.name} = new {Utils.SerializableClassName(item.name)}());"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 134 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 138 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

		foreach (var item in Schema.Objects)
        {

            
            #line default
            #line hidden
            this.Write("\t\tpublic List<");
            
            #line 142 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(item.name)));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 142 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ObjectListPropertyName(item.name)));
            
            #line default
            #line hidden
            this.Write(" { get; } = new List<");
            
            #line 142 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.SerializableClassName(item.name)));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 143 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n        public IEnumerable<KeyValuePair<string, ");
            
            #line 147 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ImageType));
            
            #line default
            #line hidden
            this.Write(">> Images => _images;\r\n        public IEnumerable<KeyValuePair<string, ");
            
            #line 148 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.AudioClipType));
            
            #line default
            #line hidden
            this.Write(">> AudioClips => _audioClips;\r\n        public IEnumerable<KeyValuePair<string, st" +
                    "ring>> Localizations => _localizations;\r\n\r\n        private readonly IJsonSeriali" +
                    "zer _serializer;\r\n\r\n        private readonly Dictionary<string, ");
            
            #line 153 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ImageType));
            
            #line default
            #line hidden
            this.Write("> _images = new Dictionary<string, ");
            
            #line 153 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ImageType));
            
            #line default
            #line hidden
            this.Write(">(StringComparer.OrdinalIgnoreCase);\r\n        private readonly Dictionary<string," +
                    " ");
            
            #line 154 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.AudioClipType));
            
            #line default
            #line hidden
            this.Write("> _audioClips = new Dictionary<string, ");
            
            #line 154 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\MigrationCode\Templates\DatabaseContentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.AudioClipType));
            
            #line default
            #line hidden
            this.Write(">(StringComparer.OrdinalIgnoreCase);\r\n        private readonly Dictionary<string," +
                    " string> _localizations = new Dictionary<string, string>(StringComparer.OrdinalI" +
                    "gnoreCase);\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class DatabaseContentTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        public System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
