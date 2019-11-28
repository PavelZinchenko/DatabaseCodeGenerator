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
	public partial class LootItemData
	{
		partial void OnDataDeserialized(LootItemSerializable serializable, Database database);

		public static LootItemData Create(LootItemSerializable serializable, Database database)
		{
			return new LootItemData(serializable, database);
		}

		private LootItemData(LootItemSerializable serializable, Database database)
		{
			Weight = UnityEngine.Mathf.Clamp(serializable.Weight, -2.147484E+09f, 2.147484E+09f);
			Loot = LootContentData.Create(serializable.Loot, database);

			OnDataDeserialized(serializable, database);
		}

		public readonly float Weight;
		public readonly LootContentData Loot;
	}
}
