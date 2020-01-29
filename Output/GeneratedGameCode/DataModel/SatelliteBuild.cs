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
	public partial class SatelliteBuild
	{
		partial void OnDataDeserialized(SatelliteBuildSerializable serializable, Database database);

		public static SatelliteBuild Create(SatelliteBuildSerializable serializable, Database database)
		{
			return new SatelliteBuild(serializable, database);
		}

		private SatelliteBuild(SatelliteBuildSerializable serializable, Database database)
		{
			Id = new ItemId<SatelliteBuild>(serializable.Id);
			database.AddSatelliteBuild(serializable.Id, this);

			Satellite = database.GetSatellite(new ItemId<Satellite>(serializable.SatelliteId));
			NotAvailableInGame = serializable.NotAvailableInGame;
			DifficultyClass = serializable.DifficultyClass;
			Components = new ImmutableCollection<InstalledComponent>(serializable.Components?.Select(item => InstalledComponent.Create(item, database)));

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<SatelliteBuild> Id;

		public Satellite Satellite { get; private set; }
		public bool NotAvailableInGame { get; private set; }
		public DifficultyClass DifficultyClass { get; private set; }
		public ImmutableCollection<InstalledComponent> Components { get; private set; }

		public static SatelliteBuild DefaultValue { get; private set; }
	}
}
