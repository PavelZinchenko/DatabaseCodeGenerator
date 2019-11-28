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
	public partial class ShipBuildData
	{
		partial void OnDataDeserialized(ShipBuildSerializable serializable, Database database);

		public static ShipBuildData Create(ShipBuildSerializable serializable, Database database)
		{
			return new ShipBuildData(serializable, database);
		}

		private ShipBuildData(ShipBuildSerializable serializable, Database database)
		{
			Id = new ItemId<ShipBuildData>(serializable.Id);
			database.AddShipBuild(serializable.Id, this);

			ShipId = database.GetShip(new ItemId<ShipData>(serializable.ShipId));
			NotAvailableInGame = serializable.NotAvailableInGame;
			DifficultyClass = serializable.DifficultyClass;
			BuildFaction = database.GetFaction(new ItemId<FactionData>(serializable.BuildFaction));
			Components = serializable.Components?.Select(item => InstalledComponentData.Create(item, database)).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<ShipBuildData> Id;

		public readonly ShipData ShipId;
		public readonly bool NotAvailableInGame;
		public readonly DifficultyClass DifficultyClass;
		public readonly FactionData BuildFaction;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<InstalledComponentData> Components;
	}
}
