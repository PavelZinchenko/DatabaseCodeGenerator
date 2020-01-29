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
	public partial class Character
	{
		partial void OnDataDeserialized(CharacterSerializable serializable, Database database);

		public static Character Create(CharacterSerializable serializable, Database database)
		{
			return new Character(serializable, database);
		}

		private Character(CharacterSerializable serializable, Database database)
		{
			Id = new ItemId<Character>(serializable.Id);
			database.AddCharacter(serializable.Id, this);

			Name = serializable.Name;
			AvatarIcon = new SpriteId(serializable.AvatarIcon, SpriteId.Type.AvatarIcon);
			Faction = database.GetFaction(new ItemId<Faction>(serializable.Faction));
			Inventory = database.GetLoot(new ItemId<LootModel>(serializable.Inventory));
			Fleet = database.GetFleet(new ItemId<Fleet>(serializable.Fleet));
			Relations = UnityEngine.Mathf.Clamp(serializable.Relations, 0, 100);
			IsUnique = serializable.IsUnique;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<Character> Id;

		public string Name { get; private set; }
		public SpriteId AvatarIcon { get; private set; }
		public Faction Faction { get; private set; }
		public LootModel Inventory { get; private set; }
		public Fleet Fleet { get; private set; }
		public int Relations { get; private set; }
		public bool IsUnique { get; private set; }

		public static Character DefaultValue { get; private set; }
	}
}
