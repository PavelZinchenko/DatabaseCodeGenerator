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
	public partial class Component
	{
		partial void OnDataDeserialized(ComponentSerializable serializable, Database database);

		public static Component Create(ComponentSerializable serializable, Database database)
		{
			return new Component(serializable, database);
		}

		private Component(ComponentSerializable serializable, Database database)
		{
			Id = new ItemId<Component>(serializable.Id);
			database.AddComponent(serializable.Id, this);

			Name = serializable.Name;
			Description = serializable.Description;
			DisplayCategory = serializable.DisplayCategory;
			Availability = serializable.Availability;
			Stats = database.GetComponentStats(new ItemId<ComponentStats>(serializable.ComponentStatsId));
			Faction = database.GetFaction(new ItemId<Faction>(serializable.Faction));
			Level = UnityEngine.Mathf.Clamp(serializable.Level, 0, 500);
			Icon = new SpriteId(serializable.Icon, SpriteId.Type.Component);
			Color = new ColorData(serializable.Color);
			Layout = new Layout(serializable.Layout);
			_cellType = serializable.CellType;
			Device = database.GetDevice(new ItemId<Device>(serializable.DeviceId));
			Weapon = database.GetWeapon(new ItemId<Weapon>(serializable.WeaponId));
			Ammunition = database.GetAmmunition(new ItemId<Ammunition>(serializable.AmmunitionId));
			AmmunitionObsolete = database.GetAmmunitionObsolete(new ItemId<AmmunitionObsolete>(serializable.AmmunitionId));
			WeaponSlotType = serializable.WeaponSlotType;
			DroneBay = database.GetDroneBay(new ItemId<DroneBay>(serializable.DroneBayId));
			Drone = database.GetShipBuild(new ItemId<ShipBuild>(serializable.DroneId));
			PossibleModifications = new ImmutableCollection<ComponentMod>(serializable.PossibleModifications?.Select(item => database.GetComponentMod(new ItemId<ComponentMod>(item))));

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<Component> Id;

		public string Name { get; private set; }
		public string Description { get; private set; }
		public ComponentCategory DisplayCategory { get; private set; }
		public Availability Availability { get; private set; }
		public ComponentStats Stats { get; private set; }
		public Faction Faction { get; private set; }
		public int Level { get; private set; }
		public SpriteId Icon { get; private set; }
		public ColorData Color { get; private set; }
		public Layout Layout { get; private set; }
		private readonly string _cellType;
		public Device Device { get; private set; }
		public Weapon Weapon { get; private set; }
		public Ammunition Ammunition { get; private set; }
		public AmmunitionObsolete AmmunitionObsolete { get; private set; }
		public WeaponSlotType WeaponSlotType { get; private set; }
		public DroneBay DroneBay { get; private set; }
		public ShipBuild Drone { get; private set; }
		public ImmutableCollection<ComponentMod> PossibleModifications { get; private set; }

		public static Component DefaultValue { get; private set; }
	}
}
