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
using GameDatabase.Types;

namespace GameDatabase.Classes
{
	public partial class NodeActionData
	{
		partial void OnDataDeserialized(NodeActionSerializable serializable, Database database);

		public static NodeActionData Create(NodeActionSerializable serializable, Database database)
		{
			return new NodeActionData(serializable, database);
		}

		private NodeActionData(NodeActionSerializable serializable, Database database)
		{
			TargetNode = UnityEngine.Mathf.Clamp(serializable.TargetNode, 1, 1000);
			Requirement = RequirementData.Create(serializable.Requirement, database);
			ButtonText = serializable.ButtonText;

			OnDataDeserialized(serializable, database);
		}

		public readonly int TargetNode;
		public readonly RequirementData Requirement;
		public readonly string ButtonText;
	}
}
