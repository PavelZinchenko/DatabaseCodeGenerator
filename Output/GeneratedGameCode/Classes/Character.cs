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
	public partial class CharacterData
	{
		partial void OnDataDeserialized(CharacterSerializable serializable, Database database);

		public static CharacterData Create(CharacterSerializable serializable, Database database)
		{
			return new CharacterData(serializable, database);
		}

		private CharacterData(CharacterSerializable serializable, Database database)
		{
			Id = new ItemId<CharacterData>(serializable.Id);
			database.AddCharacter(serializable.Id, this);

			Name = serializable.Name;
			AvatarIcon = new SpriteId(serializable.AvatarIcon);
			Faction = database.GetFaction(new ItemId<FactionData>(serializable.Faction));
			Inventory = database.GetLoot(new ItemId<LootData>(serializable.Inventory));
			Fleet = database.GetFleet(new ItemId<FleetData>(serializable.Fleet));
			Relations = UnityEngine.Mathf.Clamp(serializable.Relations, 0, 100);
			IsUnique = serializable.IsUnique;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<CharacterData> Id;

		public readonly string Name;
		public readonly SpriteId AvatarIcon;
		public readonly FactionData Faction;
		public readonly LootData Inventory;
		public readonly FleetData Fleet;
		public readonly int Relations;
		public readonly bool IsUnique;
	}
}
