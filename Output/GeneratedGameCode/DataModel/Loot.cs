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
	public partial class LootModel
	{
		partial void OnDataDeserialized(LootSerializable serializable, Database database);

		public static LootModel Create(LootSerializable serializable, Database database)
		{
			return new LootModel(serializable, database);
		}

		private LootModel(LootSerializable serializable, Database database)
		{
			Id = new ItemId<LootModel>(serializable.Id);
			database.AddLoot(serializable.Id, this);

			Loot = LootContent.Create(serializable.Loot, database);

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<LootModel> Id;

		public LootContent Loot { get; private set; }

		public static LootModel DefaultValue { get; private set; }
	}
}
