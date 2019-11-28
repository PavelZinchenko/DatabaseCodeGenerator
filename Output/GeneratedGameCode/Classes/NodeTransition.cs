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
	public partial class NodeTransitionData
	{
		partial void OnDataDeserialized(NodeTransitionSerializable serializable, Database database);

		public static NodeTransitionData Create(NodeTransitionSerializable serializable, Database database)
		{
			return new NodeTransitionData(serializable, database);
		}

		private NodeTransitionData(NodeTransitionSerializable serializable, Database database)
		{
			TargetNode = UnityEngine.Mathf.Clamp(serializable.TargetNode, 1, 1000);
			Requirement = RequirementData.Create(serializable.Requirement, database);
			Weight = UnityEngine.Mathf.Clamp(serializable.Weight, 0f, 1000f);

			OnDataDeserialized(serializable, database);
		}

		public readonly int TargetNode;
		public readonly RequirementData Requirement;
		public readonly float Weight;
	}
}
