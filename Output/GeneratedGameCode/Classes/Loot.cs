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
	public partial class LootData
	{
		partial void OnDataDeserialized(LootSerializable serializable, Database database);

		public static LootData Create(LootSerializable serializable, Database database)
		{
			return new LootData(serializable, database);
		}

		private LootData(LootSerializable serializable, Database database)
		{
			Id = new ItemId<LootData>(serializable.Id);
			database.AddLoot(serializable.Id, this);

			Loot = LootContentData.Create(serializable.Loot, database);

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<LootData> Id;

		public readonly LootContentData Loot;
	}
}
