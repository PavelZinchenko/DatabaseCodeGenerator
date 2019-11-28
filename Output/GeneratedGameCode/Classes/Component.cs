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
	public partial class ComponentData
	{
		partial void OnDataDeserialized(ComponentSerializable serializable, Database database);

		public static ComponentData Create(ComponentSerializable serializable, Database database)
		{
			return new ComponentData(serializable, database);
		}

		private ComponentData(ComponentSerializable serializable, Database database)
		{
			Id = new ItemId<ComponentData>(serializable.Id);
			database.AddComponent(serializable.Id, this);

			Name = serializable.Name;
			Description = serializable.Description;
			DisplayCategory = serializable.DisplayCategory;
			Availability = serializable.Availability;
			ComponentStats = database.GetComponentStats(new ItemId<ComponentStatsData>(serializable.ComponentStatsId));
			Faction = database.GetFaction(new ItemId<FactionData>(serializable.Faction));
			Level = UnityEngine.Mathf.Clamp(serializable.Level, 0, 500);
			Icon = new SpriteId(serializable.Icon);
			Color = new Color(serializable.Color);
			Layout = new Layout(serializable.Layout);
			CellType = serializable.CellType;
			Device = database.GetDevice(new ItemId<DeviceData>(serializable.DeviceId));
			Weapon = database.GetWeapon(new ItemId<WeaponData>(serializable.WeaponId));
			Ammunition = database.GetAmmunition(new ItemId<AmmunitionData>(serializable.AmmunitionId));
			AmmunitionObsolete = database.GetAmmunitionObsolete(new ItemId<AmmunitionObsoleteData>(serializable.AmmunitionId));
			WeaponSlotType = serializable.WeaponSlotType;
			DroneBay = database.GetDroneBay(new ItemId<DroneBayData>(serializable.DroneBayId));
			ShipBuild = database.GetShipBuild(new ItemId<ShipBuildData>(serializable.DroneId));
			PossibleModifications = serializable.PossibleModifications?.Select(item => database.GetComponentMod(new ItemId<ComponentModData>(item))).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<ComponentData> Id;

		public readonly string Name;
		public readonly string Description;
		public readonly ComponentCategory DisplayCategory;
		public readonly Availability Availability;
		public readonly ComponentStatsData ComponentStats;
		public readonly FactionData Faction;
		public readonly int Level;
		public readonly SpriteId Icon;
		public readonly Color Color;
		public readonly Layout Layout;
		public readonly string CellType;
		public readonly DeviceData Device;
		public readonly WeaponData Weapon;
		public readonly AmmunitionData Ammunition;
		public readonly AmmunitionObsoleteData AmmunitionObsolete;
		public readonly string WeaponSlotType;
		public readonly DroneBayData DroneBay;
		public readonly ShipBuildData ShipBuild;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<ComponentModData> PossibleModifications;
	}
}
