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
	public partial class QuestData
	{
		partial void OnDataDeserialized(QuestSerializable serializable, Database database);

		public static QuestData Create(QuestSerializable serializable, Database database)
		{
			return new QuestData(serializable, database);
		}

		private QuestData(QuestSerializable serializable, Database database)
		{
			Id = new ItemId<QuestData>(serializable.Id);
			database.AddQuest(serializable.Id, this);

			Name = serializable.Name;
			QuestType = serializable.QuestType;
			StartCondition = serializable.StartCondition;
			Weight = UnityEngine.Mathf.Clamp(serializable.Weight, 0f, 1000f);
			Requirement = RequirementData.Create(serializable.Requirement, database);
			Level = UnityEngine.Mathf.Clamp(serializable.Level, 0, 1000);
			Nodes = serializable.Nodes?.Select(item => NodeData.Create(item, database)).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<QuestData> Id;

		public readonly string Name;
		public readonly QuestType QuestType;
		public readonly StartCondition StartCondition;
		public readonly float Weight;
		public readonly RequirementData Requirement;
		public readonly int Level;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<NodeData> Nodes;
	}
}
