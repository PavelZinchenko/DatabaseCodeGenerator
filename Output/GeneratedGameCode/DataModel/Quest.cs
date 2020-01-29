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
	public partial class QuestModel
	{
		partial void OnDataDeserialized(QuestSerializable serializable, Database database);

		public static QuestModel Create(QuestSerializable serializable, Database database)
		{
			return new QuestModel(serializable, database);
		}

		private QuestModel(QuestSerializable serializable, Database database)
		{
			Id = new ItemId<QuestModel>(serializable.Id);
			database.AddQuest(serializable.Id, this);

			Name = serializable.Name;
			QuestType = serializable.QuestType;
			StartCondition = serializable.StartCondition;
			Weight = UnityEngine.Mathf.Clamp(serializable.Weight, 0f, 1000f);
			Requirement = Requirement.Create(serializable.Requirement, database);
			Level = UnityEngine.Mathf.Clamp(serializable.Level, 0, 1000);
			Nodes = new ImmutableCollection<Node>(serializable.Nodes?.Select(item => Node.Create(item, database)));

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<QuestModel> Id;

		public string Name { get; private set; }
		public QuestType QuestType { get; private set; }
		public StartCondition StartCondition { get; private set; }
		public float Weight { get; private set; }
		public Requirement Requirement { get; private set; }
		public int Level { get; private set; }
		public ImmutableCollection<Node> Nodes { get; private set; }

		public static QuestModel DefaultValue { get; private set; }
	}
}
