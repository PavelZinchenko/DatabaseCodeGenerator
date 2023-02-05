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
	public partial class FrontierSettings
	{
		partial void OnDataDeserialized(FrontierSettingsSerializable serializable, Database.Loader loader);

		public static FrontierSettings Create(FrontierSettingsSerializable serializable, Database.Loader loader)
		{
			return new FrontierSettings(serializable, loader);
		}

		private FrontierSettings(FrontierSettingsSerializable serializable, Database.Loader loader)
		{
			CustomShipLevels = new ImmutableCollection<ShipToValue>(serializable.CustomShipLevels?.Select(item => ShipToValue.Create(item, loader)));
			ExplorationShips = new ImmutableCollection<Ship>(serializable.ExplorationShips?.Select(item => loader.GetShip(new ItemId<Ship>(item), true)));

			OnDataDeserialized(serializable, loader);
		}

		public ImmutableCollection<ShipToValue> CustomShipLevels { get; private set; }
		public ImmutableCollection<Ship> ExplorationShips { get; private set; }

		public static FrontierSettings DefaultValue { get; private set; }
	}
}
