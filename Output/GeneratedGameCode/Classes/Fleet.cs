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
	public partial class FleetData
	{
		partial void OnDataDeserialized(FleetSerializable serializable, Database database);

		public static FleetData Create(FleetSerializable serializable, Database database)
		{
			return new FleetData(serializable, database);
		}

		private FleetData(FleetSerializable serializable, Database database)
		{
			Id = new ItemId<FleetData>(serializable.Id);
			database.AddFleet(serializable.Id, this);

			Factions = FactionFilterData.Create(serializable.Factions, database);
			LevelBonus = UnityEngine.Mathf.Clamp(serializable.LevelBonus, -100, 100);
			NoRandomShips = serializable.NoRandomShips;
			CombatTimeLimit = UnityEngine.Mathf.Clamp(serializable.CombatTimeLimit, 0, 999);
			LootCondition = serializable.LootCondition;
			ExpCondition = serializable.ExpCondition;
			SpecificShips = serializable.SpecificShips?.Select(item => database.GetShipBuild(new ItemId<ShipBuildData>(item))).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<FleetData> Id;

		public readonly FactionFilterData Factions;
		public readonly int LevelBonus;
		public readonly bool NoRandomShips;
		public readonly int CombatTimeLimit;
		public readonly RewardCondition LootCondition;
		public readonly RewardCondition ExpCondition;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<ShipBuildData> SpecificShips;
	}
}
