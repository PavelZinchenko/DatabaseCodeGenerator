//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using GameDatabase.Enums;
using GameDatabase.Types;

namespace GameDatabase.Serializable
{
	[Serializable]
	public class QuestSerializable : SerializableItem
	{
		public string Name;
		public QuestType QuestType;
		public StartCondition StartCondition;
		public float Weight;
		public RequirementSerializable Requirement;
		public int Level;
		public NodeSerializable[] Nodes;
	}
}
