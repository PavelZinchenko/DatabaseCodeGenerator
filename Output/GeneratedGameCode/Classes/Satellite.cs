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
	public partial class SatelliteData
	{
		partial void OnDataDeserialized(SatelliteSerializable serializable, Database database);

		public static SatelliteData Create(SatelliteSerializable serializable, Database database)
		{
			return new SatelliteData(serializable, database);
		}

		private SatelliteData(SatelliteSerializable serializable, Database database)
		{
			Id = new ItemId<SatelliteData>(serializable.Id);
			database.AddSatellite(serializable.Id, this);

			Name = serializable.Name;
			ModelImage = new SpriteId(serializable.ModelImage);
			ModelScale = UnityEngine.Mathf.Clamp(serializable.ModelScale, 0.1f, 100f);
			SizeClass = serializable.SizeClass;
			Layout = new Layout(serializable.Layout);
			Barrels = serializable.Barrels?.Select(item => BarrelData.Create(item, database)).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<SatelliteData> Id;

		public readonly string Name;
		public readonly SpriteId ModelImage;
		public readonly float ModelScale;
		public readonly SizeClass SizeClass;
		public readonly Layout Layout;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<BarrelData> Barrels;
	}
}
