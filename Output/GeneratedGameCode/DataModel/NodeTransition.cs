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
	public partial class NodeTransition
	{
		partial void OnDataDeserialized(NodeTransitionSerializable serializable, Database database);

		public static NodeTransition Create(NodeTransitionSerializable serializable, Database database)
		{
			return new NodeTransition(serializable, database);
		}

		private NodeTransition(NodeTransitionSerializable serializable, Database database)
		{
			TargetNode = UnityEngine.Mathf.Clamp(serializable.TargetNode, 1, 1000);
			Requirement = Requirement.Create(serializable.Requirement, database);
			Weight = UnityEngine.Mathf.Clamp(serializable.Weight, 0f, 1000f);

			OnDataDeserialized(serializable, database);
		}

		public int TargetNode { get; private set; }
		public Requirement Requirement { get; private set; }
		public float Weight { get; private set; }

		public static NodeTransition DefaultValue { get; private set; }
	}
}
