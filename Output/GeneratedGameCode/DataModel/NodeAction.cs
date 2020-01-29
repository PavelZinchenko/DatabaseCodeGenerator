//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System.Linq;
using GameDatabase.Enums;
using GameDatabase.Serializable;
using GameDatabase.Model;

namespace GameDatabase.DataModel
{
	public partial class NodeAction
	{
		partial void OnDataDeserialized(NodeActionSerializable serializable, Database database);

		public static NodeAction Create(NodeActionSerializable serializable, Database database)
		{
			return new NodeAction(serializable, database);
		}

		private NodeAction(NodeActionSerializable serializable, Database database)
		{
			TargetNode = UnityEngine.Mathf.Clamp(serializable.TargetNode, 1, 1000);
			Requirement = Requirement.Create(serializable.Requirement, database);
			ButtonText = serializable.ButtonText;

			OnDataDeserialized(serializable, database);
		}

		public int TargetNode { get; private set; }
		public Requirement Requirement { get; private set; }
		public string ButtonText { get; private set; }

		public static NodeAction DefaultValue { get; private set; }
	}
}
