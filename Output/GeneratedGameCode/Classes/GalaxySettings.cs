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
	public partial class GalaxySettingsData
	{
		partial void OnDataDeserialized(GalaxySettingsSerializable serializable, Database database);

		public static GalaxySettingsData Create(GalaxySettingsSerializable serializable, Database database)
		{
			return new GalaxySettingsData(serializable, database);
		}

		private GalaxySettingsData(GalaxySettingsSerializable serializable, Database database)
		{
			AbandonedStarbaseFaction = database.GetFaction(new ItemId<FactionData>(serializable.AbandonedStarbaseFaction));
			StartingShipBuilds = serializable.StartingShipBuilds?.Select(item => database.GetShipBuild(new ItemId<ShipBuildData>(item))).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly FactionData AbandonedStarbaseFaction;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<ShipBuildData> StartingShipBuilds;
	}
}
