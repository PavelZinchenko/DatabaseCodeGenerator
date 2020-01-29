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
	public partial class ShipBuild
	{
		partial void OnDataDeserialized(ShipBuildSerializable serializable, Database database);

		public static ShipBuild Create(ShipBuildSerializable serializable, Database database)
		{
			return new ShipBuild(serializable, database);
		}

		private ShipBuild(ShipBuildSerializable serializable, Database database)
		{
			Id = new ItemId<ShipBuild>(serializable.Id);
			database.AddShipBuild(serializable.Id, this);

			Ship = database.GetShip(new ItemId<Ship>(serializable.ShipId));
			NotAvailableInGame = serializable.NotAvailableInGame;
			DifficultyClass = serializable.DifficultyClass;
			BuildFaction = database.GetFaction(new ItemId<Faction>(serializable.BuildFaction));
			Components = new ImmutableCollection<InstalledComponent>(serializable.Components?.Select(item => InstalledComponent.Create(item, database)));

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<ShipBuild> Id;

		public Ship Ship { get; private set; }
		public bool NotAvailableInGame { get; private set; }
		public DifficultyClass DifficultyClass { get; private set; }
		public Faction BuildFaction { get; private set; }
		public ImmutableCollection<InstalledComponent> Components { get; private set; }

		public static ShipBuild DefaultValue { get; private set; }
	}
}
