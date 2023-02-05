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
	public partial class Ship
	{
		partial void OnDataDeserialized(ShipSerializable serializable, Database.Loader loader);

		public static Ship Create(ShipSerializable serializable, Database.Loader loader)
		{
			return new Ship(serializable, loader);
		}

		private Ship(ShipSerializable serializable, Database.Loader loader)
		{
			Id = new ItemId<Ship>(serializable.Id);
			loader.AddShip(serializable.Id, this);

			ShipType = serializable.ShipType;
			WayToGetShip = serializable.WayToGetShip;
			SizeClass = serializable.SizeClass;
			Name = serializable.Name;
			Faction = loader.GetFaction(new ItemId<Faction>(serializable.Faction));
			IconImage = new SpriteId(serializable.IconImage, SpriteId.Type.ShipIcon);
			IconScale = UnityEngine.Mathf.Clamp(serializable.IconScale, 0.1f, 100f);
			ModelImage = new SpriteId(serializable.ModelImage, SpriteId.Type.Ship);
			ModelScale = UnityEngine.Mathf.Clamp(serializable.ModelScale, 0.1f, 100f);
			EngineColor = new ColorData(serializable.EngineColor);
			Engines = new ImmutableCollection<Engine>(serializable.Engines?.Select(item => Engine.Create(item, loader)));
			Layout = new Layout(serializable.Layout);
			Barrels = new ImmutableCollection<Barrel>(serializable.Barrels?.Select(item => Barrel.Create(item, loader)));
			Features = ShipFeatures.Create(serializable.Features, loader);

			OnDataDeserialized(serializable, loader);
		}

		public readonly ItemId<Ship> Id;

		public ShipType ShipType { get; private set; }
		public WayToGetShip WayToGetShip { get; private set; }
		public SizeClass SizeClass { get; private set; }
		public string Name { get; private set; }
		public Faction Faction { get; private set; }
		public SpriteId IconImage { get; private set; }
		public float IconScale { get; private set; }
		public SpriteId ModelImage { get; private set; }
		public float ModelScale { get; private set; }
		public ColorData EngineColor { get; private set; }
		public ImmutableCollection<Engine> Engines { get; private set; }
		public Layout Layout { get; private set; }
		public ImmutableCollection<Barrel> Barrels { get; private set; }
		public ShipFeatures Features { get; private set; }

		public static Ship DefaultValue { get; private set; }
	}
}
