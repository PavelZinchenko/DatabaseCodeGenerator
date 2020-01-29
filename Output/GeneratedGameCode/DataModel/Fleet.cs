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
	public partial class Fleet
	{
		partial void OnDataDeserialized(FleetSerializable serializable, Database database);

		public static Fleet Create(FleetSerializable serializable, Database database)
		{
			return new Fleet(serializable, database);
		}

		private Fleet(FleetSerializable serializable, Database database)
		{
			Id = new ItemId<Fleet>(serializable.Id);
			database.AddFleet(serializable.Id, this);

			Factions = RequiredFactions.Create(serializable.Factions, database);
			LevelBonus = UnityEngine.Mathf.Clamp(serializable.LevelBonus, -100, 100);
			NoRandomShips = serializable.NoRandomShips;
			CombatTimeLimit = UnityEngine.Mathf.Clamp(serializable.CombatTimeLimit, 0, 999);
			LootCondition = serializable.LootCondition;
			ExpCondition = serializable.ExpCondition;
			SpecificShips = new ImmutableCollection<ShipBuild>(serializable.SpecificShips?.Select(item => database.GetShipBuild(new ItemId<ShipBuild>(item))));

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<Fleet> Id;

		public RequiredFactions Factions { get; private set; }
		public int LevelBonus { get; private set; }
		public bool NoRandomShips { get; private set; }
		public int CombatTimeLimit { get; private set; }
		public RewardCondition LootCondition { get; private set; }
		public RewardCondition ExpCondition { get; private set; }
		public ImmutableCollection<ShipBuild> SpecificShips { get; private set; }

		public static Fleet DefaultValue { get; private set; }
	}
}
