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
	public partial class QuestItem
	{
		partial void OnDataDeserialized(QuestItemSerializable serializable, Database database);

		public static QuestItem Create(QuestItemSerializable serializable, Database database)
		{
			return new QuestItem(serializable, database);
		}

		private QuestItem(QuestItemSerializable serializable, Database database)
		{
			Id = new ItemId<QuestItem>(serializable.Id);
			database.AddQuestItem(serializable.Id, this);

			Name = serializable.Name;
			Description = serializable.Description;
			Icon = new SpriteId(serializable.Icon, SpriteId.Type.ArtifactIcon);
			Color = new ColorData(serializable.Color);
			Price = UnityEngine.Mathf.Clamp(serializable.Price, 0, 100000000);

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<QuestItem> Id;

		public string Name { get; private set; }
		public string Description { get; private set; }
		public SpriteId Icon { get; private set; }
		public ColorData Color { get; private set; }
		public int Price { get; private set; }

		public static QuestItem DefaultValue { get; private set; }
	}
}
