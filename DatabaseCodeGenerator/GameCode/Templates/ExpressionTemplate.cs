﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 17.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace DatabaseCodeGenerator.GameCode.Templates
{
    using Schema;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public partial class ExpressionTemplate : ExpressionTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 1 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//-------------------------------------------------------------------------------"));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 2 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//                                                                               "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 3 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    This code was automatically generated.                                     "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 4 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    Changes to this file may cause incorrect behavior and will be lost if      "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 5 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//    the code is regenerated.                                                   "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 6 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//                                                                               "));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 7 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\GeneratedCodeWarning.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture("//-------------------------------------------------------------------------------"));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System.Collections.Generic;\r\nusing ");
            
            #line 6 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 6 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.EnumsNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 7 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 7 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.TypesNamespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing CodeWriter.ExpressionParser;\r\n");
            
            #line 9 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"

	var returnType = GetFuncReturnType(ExpressionData);

            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 13 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.RootNamespace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 13 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ExpressionsNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\tpublic class ");
            
            #line 15 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ExpressionClassName(ExpressionData)));
            
            #line default
            #line hidden
            this.Write(" : IFunction<");
            
            #line 15 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.VariantType));
            
            #line default
            #line hidden
            this.Write(">\r\n\t{\r\n");
            
            #line 17 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"

		PushIndent("\t\t");

		for(int i = 0; i < ExpressionData.items.Count; ++i)
			WriteLine($"public string ParamName{i+1} {{ get; set; }} = \"{ExpressionData.items[i].name}\";");

		PopIndent();

            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic int ArgumentCount => ");
            
            #line 26 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ExpressionData.items.Count));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n\t\tprivate Expression<");
            
            #line 28 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.VariantType));
            
            #line default
            #line hidden
            this.Write("> Expression\r\n\t\t{\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\tif (_expression == null)\r\n\t\t\t\t{\r\n\t\t\t\t\tvar bu" +
                    "ilder = new ExpressionBuilder(_variableResolver);\r\n");
            
            #line 35 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"

					PushIndent("\t\t\t\t\t");
			
					for (int i = 0; i < ExpressionData.items.Count; i++)
						WriteLine($"builder.AddParameter(ParamName{i+1}, {Utils.GetterName(ExpressionData.items[i].name)});");

					PopIndent();

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t_expression = builder.Build(_expressionText).Invoke;\r\n\t\t\t\t}\r\n\r\n\t\t\t\treturn _e" +
                    "xpression;\r\n\t\t\t}\r\n\t\t}\r\n\r\n\r\n\t\tpublic ");
            
            #line 51 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.ExpressionClassName(ExpressionData)));
            
            #line default
            #line hidden
            this.Write("(string data, ");
            
            #line 51 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" minvalue, ");
            
            #line 51 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" maxvalue, IVariableResolver variableResolver)\r\n\t\t{\r\n\t\t\t_expressionText = data;\r\n" +
                    "\t\t\t_minvalue = minvalue;\r\n\t\t\t_maxvalue = maxvalue;\r\n\t\t\t_variableResolver = varia" +
                    "bleResolver;\r\n\t\t}\r\n\r\n\t\tpublic ");
            
            #line 59 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" Evaluate(");
            
            #line 59 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFuncParamList(ExpressionData)));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n");
            
            #line 61 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"

			PushIndent("\t\t\t");

			foreach(var item in ExpressionData.items)
				WriteLine($"{Utils.PrivateMemberName(item.name)} = {item.name};");

			PopIndent();

            
            #line default
            #line hidden
            this.Write("\t\t\treturn ClampResult(");
            
            #line 69 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(VariantToType("Expression.Invoke()", returnType)));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n\r\n\t\tprivate ");
            
            #line 72 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" ClampResult(");
            
            #line 72 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" value)\r\n\t\t{\r\n\t\t\tif (value < _minvalue) return _minvalue;\r\n\t\t\tif (value > _maxval" +
                    "ue) return _maxvalue;\r\n\t\t\treturn value;\r\n\t\t}\r\n\r\n");
            
            #line 79 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"

		PushIndent("\t\t");

		foreach(var item in ExpressionData.items)
			WriteLine($"private {Utils.VariantType} {Utils.GetterName(item.name)}() => {Utils.PrivateMemberName(item.name)};");

		PopIndent();

            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic Expression<");
            
            #line 88 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.VariantType));
            
            #line default
            #line hidden
            this.Write("> Invoke(List<Expression<");
            
            #line 88 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.VariantType));
            
            #line default
            #line hidden
            this.Write(">> arguments)\r\n\t\t{\r\n\t\t\tif (arguments.Count != ArgumentCount) \r\n\t\t\t\tthrow new Syst" +
                    "em.ArgumentException();\r\n\r\n\t\t\treturn () =>\r\n\t\t\t{\r\n");
            
            #line 95 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"

				PushIndent("\t\t\t\t");

				for (int i = 0; i < ExpressionData.items.Count; i++)
				{
					var item = ExpressionData.items[i];
					WriteLine($"{Utils.PrivateMemberName(item.name)} = " + VariantToType($"arguments[{i}].Invoke()", GetFuncParamType(item, Schema)) + ";");
				}

				PopIndent();

            
            #line default
            #line hidden
            this.Write("\t\t\t\treturn ClampResult(");
            
            #line 106 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(VariantToType("Expression.Invoke()", returnType)));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\t};\r\n\t\t}\r\n\r\n\t\tprivate IVariableResolver _variableResolver;\r\n\t\tprivate Expre" +
                    "ssion<");
            
            #line 111 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.VariantType));
            
            #line default
            #line hidden
            this.Write("> _expression;\r\n\t\tprivate string _expressionText;\r\n\t\tprivate ");
            
            #line 113 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" _minvalue;\r\n\t\tprivate ");
            
            #line 114 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(returnType));
            
            #line default
            #line hidden
            this.Write(" _maxvalue;\r\n\r\n");
            
            #line 116 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"

		foreach(var item in ExpressionData.items)
		{

            
            #line default
            #line hidden
            this.Write("\t\tprivate ");
            
            #line 120 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFuncParamType(item, Schema)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 120 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utils.PrivateMemberName(item.name)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 121 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\ExpressionTemplate.tt"

		}

            
            #line default
            #line hidden
            this.Write("\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 2 "D:\Projects\event-horizon-main\Assets\Modules\Database\.CodeGenerator\DatabaseCodeGenerator\GameCode\Templates\FuncParams.tt"


private bool HasExpression(XmlClassItem objectData)
{
	foreach(var member in objectData.members)
		if (member.type == Constants.TypeFormula) 
			return true;
	return false;
}

private string GetFuncParamType(XmlExpressionParam member, DatabaseSchema schema)
{
	if (member.type == Constants.TypeInt)
	{
		return Constants.TypeInt;
	}
	else if (member.type == Constants.TypeFloat)
	{
		return Constants.TypeFloat;
	}
	else if (member.type == Constants.TypeBool)
	{
		return Constants.TypeBool;
	}
	else if (member.type == Constants.TypeFormula)
	{
		if (!schema.HasExpression(member.typeid))
			throw new InvalidSchemaException("Unknown expression type in class member " + member.name);

		var expression = schema.GetExpression(member.typeid);
		return Utils.ExpressionClassName(expression);
	}
	else if (member.type == Constants.TypeEnum)
	{
		if (!schema.HasEnum(member.typeid))
			throw new InvalidSchemaException("Unknown enum type in class member " + member.name);

		return member.typeid;
	}
	else
	{
		throw new InvalidSchemaException("Invalid expression param type - " + member.type);
	}
}

private string GetFuncReturnType(XmlExpressionItem expression)
{
	if (expression.result == Constants.TypeFloat)
		return Constants.TypeFloat;
	else
		return Constants.TypeInt;
}

private string VariantToType(string name, string type)
{
	if (type == Constants.TypeFloat)
		return name + ".AsFloat";
	else
		return name + ".AsInt";
}

private void WriteVariableResolverResolve(XmlClassMember member)
{
	if (member.options.Contains(Constants.OptionObsolete)) return;
    var memberName = !string.IsNullOrEmpty(member.alias) ? member.alias : member.name;
	switch (member.type)
	{
		case Constants.TypeInt:
		case Constants.TypeFloat:
		case Constants.TypeBool:
			WriteLine($"if (name == \"{memberName}\") return {Utils.GetterName(memberName)};");
			break;
		case Constants.TypeEnum:
			// TODO
			break;
	}
}

private void WriteVariableResolverResolveFunction(XmlClassMember member)
{
	if (member.options.Contains(Constants.OptionObsolete)) return;
    var memberName = !string.IsNullOrEmpty(member.alias) ? member.alias : member.name;
	switch (member.type)
	{
		case Constants.TypeFormula:
			WriteLine($"if (name == \"{memberName}\") return _context.{Utils.PrivateMemberName(memberName)};");
			break;
	}
}

private void WriteVariableResolverGetter(XmlClassMember member)
{
	if (member.options.Contains(Constants.OptionObsolete)) return;

    var memberName = !string.IsNullOrEmpty(member.alias) ? member.alias : member.name;
	switch (member.type)
	{
		case Constants.TypeInt:
		case Constants.TypeFloat:
		case Constants.TypeBool:
			WriteLine($"private {Utils.VariantType} {Utils.GetterName(memberName)}() => _context.{memberName};");
			break;
		case Constants.TypeEnum:
			// TODO
			break;
	}
}

private string GetFuncParamList(XmlExpressionItem expression, string paramNames = null)
{
	var paramNamesArray = paramNames?.Split(new char[] { ',', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

	bool first = true;

	var sb = new System.Text.StringBuilder();

	for (int i = 0; i < expression.items.Count; ++i)
	{
		var item = expression.items[i];
		if (!first) sb.Append(", ");
		first = false;
		var name = paramNamesArray != null && paramNamesArray.Length > i ? paramNamesArray[i] : item.name;
		sb.Append($"{GetFuncParamType(item, Schema)} {name}");
	}

	return sb.ToString();
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "17.0.0.0")]
    public class ExpressionTemplateBase
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
        protected System.Text.StringBuilder GenerationEnvironment
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