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
	public partial class GalaxySettings
	{
		partial void OnDataDeserialized(GalaxySettingsSerializable serializable, Database database);

		public static GalaxySettings Create(GalaxySettingsSerializable serializable, Database database)
		{
			return new GalaxySettings(serializable, database);
		}

		private GalaxySettings(GalaxySettingsSerializable serializable, Database database)
		{
			AbandonedStarbaseFaction = database.GetFaction(new ItemId<Faction>(serializable.AbandonedStarbaseFaction));
			StartingShipBuilds = new ImmutableCollection<ShipBuild>(serializable.StartingShipBuilds?.Select(item => database.GetShipBuild(new ItemId<ShipBuild>(item))));

			OnDataDeserialized(serializable, database);
		}

		public Faction AbandonedStarbaseFaction { get; private set; }
		public ImmutableCollection<ShipBuild> StartingShipBuilds { get; private set; }

		public static GalaxySettings DefaultValue { get; private set; }
	}
}
