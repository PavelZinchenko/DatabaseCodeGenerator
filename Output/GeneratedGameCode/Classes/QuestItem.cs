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
	public partial class QuestItemData
	{
		partial void OnDataDeserialized(QuestItemSerializable serializable, Database database);

		public static QuestItemData Create(QuestItemSerializable serializable, Database database)
		{
			return new QuestItemData(serializable, database);
		}

		private QuestItemData(QuestItemSerializable serializable, Database database)
		{
			Id = new ItemId<QuestItemData>(serializable.Id);
			database.AddQuestItem(serializable.Id, this);

			Name = serializable.Name;
			Description = serializable.Description;
			Icon = new SpriteId(serializable.Icon);
			Color = new Color(serializable.Color);
			Price = UnityEngine.Mathf.Clamp(serializable.Price, 0, 100000000);

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<QuestItemData> Id;

		public readonly string Name;
		public readonly string Description;
		public readonly SpriteId Icon;
		public readonly Color Color;
		public readonly int Price;
	}
}
