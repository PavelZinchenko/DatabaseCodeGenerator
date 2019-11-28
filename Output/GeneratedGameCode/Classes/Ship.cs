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
	public partial class ShipData
	{
		public static ShipData Create(ShipSerializable serializable, Database database)
		{
			return new ShipData(serializable, database);
		}

		private ShipData(ShipSerializable serializable, Database database)
		{
			Id = new ItemId<ShipData>(serializable.Id);
			database.AddShip(serializable.Id, this);
			Stats = new ShipStats(serializable, database);
		}

		public readonly ItemId<ShipData> Id;
		public readonly ShipStats Stats;
	}

	public partial struct ShipStats 
	{
		partial void OnDataDeserialized(ShipSerializable serializable, Database database);

		public ShipStats(ShipSerializable serializable, Database database)
		{
			ShipCategory = serializable.ShipCategory;
			Name = serializable.Name;
			Faction = database.GetFaction(new ItemId<FactionData>(serializable.Faction));
			SizeClass = serializable.SizeClass;
			IconImage = new SpriteId(serializable.IconImage);
			IconScale = UnityEngine.Mathf.Clamp(serializable.IconScale, 0.1f, 100f);
			ModelImage = new SpriteId(serializable.ModelImage);
			ModelScale = UnityEngine.Mathf.Clamp(serializable.ModelScale, 0.1f, 100f);
			EnginePosition = serializable.EnginePosition;
			EngineColor = new Color(serializable.EngineColor);
			EngineSize = UnityEngine.Mathf.Clamp(serializable.EngineSize, 0f, 1f);
			Engines = serializable.Engines?.Select(item => EngineData.Create(item, database)).ToList().AsReadOnly();
			EnergyResistance = UnityEngine.Mathf.Clamp(serializable.EnergyResistance, 0f, 100f);
			KineticResistance = UnityEngine.Mathf.Clamp(serializable.KineticResistance, 0f, 100f);
			HeatResistance = UnityEngine.Mathf.Clamp(serializable.HeatResistance, 0f, 100f);
			Regeneration = serializable.Regeneration;
			BaseWeightModifier = UnityEngine.Mathf.Clamp(serializable.BaseWeightModifier, -0.9f, 100f);
			BuiltinDevices = serializable.BuiltinDevices?.Select(item => database.GetDevice(new ItemId<DeviceData>(item))).ToList().AsReadOnly();
			Layout = new Layout(serializable.Layout);
			Barrels = serializable.Barrels?.Select(item => BarrelData.Create(item, database)).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public ShipCategory ShipCategory;
		public string Name;
		public FactionData Faction;
		public SizeClass SizeClass;
		public SpriteId IconImage;
		public float IconScale;
		public SpriteId ModelImage;
		public float ModelScale;
		public Vector2 EnginePosition;
		public Color EngineColor;
		public float EngineSize;
		public System.Collections.ObjectModel.ReadOnlyCollection<EngineData> Engines;
		public float EnergyResistance;
		public float KineticResistance;
		public float HeatResistance;
		public bool Regeneration;
		public float BaseWeightModifier;
		public System.Collections.ObjectModel.ReadOnlyCollection<DeviceData> BuiltinDevices;
		public Layout Layout;
		public System.Collections.ObjectModel.ReadOnlyCollection<BarrelData> Barrels;
	}
}
