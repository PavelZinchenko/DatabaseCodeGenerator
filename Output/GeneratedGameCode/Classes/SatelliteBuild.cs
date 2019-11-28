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
	public partial class SatelliteBuildData
	{
		partial void OnDataDeserialized(SatelliteBuildSerializable serializable, Database database);

		public static SatelliteBuildData Create(SatelliteBuildSerializable serializable, Database database)
		{
			return new SatelliteBuildData(serializable, database);
		}

		private SatelliteBuildData(SatelliteBuildSerializable serializable, Database database)
		{
			Id = new ItemId<SatelliteBuildData>(serializable.Id);
			database.AddSatelliteBuild(serializable.Id, this);

			SatelliteId = database.GetSatellite(new ItemId<SatelliteData>(serializable.SatelliteId));
			NotAvailableInGame = serializable.NotAvailableInGame;
			DifficultyClass = serializable.DifficultyClass;
			Components = serializable.Components?.Select(item => InstalledComponentData.Create(item, database)).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<SatelliteBuildData> Id;

		public readonly SatelliteData SatelliteId;
		public readonly bool NotAvailableInGame;
		public readonly DifficultyClass DifficultyClass;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<InstalledComponentData> Components;
	}
}
