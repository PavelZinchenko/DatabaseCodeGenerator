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
	public partial class FactionData
	{
		partial void OnDataDeserialized(FactionSerializable serializable, Database database);

		public static FactionData Create(FactionSerializable serializable, Database database)
		{
			return new FactionData(serializable, database);
		}

		private FactionData(FactionSerializable serializable, Database database)
		{
			Id = new ItemId<FactionData>(serializable.Id);
			database.AddFaction(serializable.Id, this);

			Type = serializable.Type;
			Color = new Color(serializable.Color);
			HomeStarDistance = UnityEngine.Mathf.Clamp(serializable.HomeStarDistance, 0, 1000);
			WanderingShipsDistance = UnityEngine.Mathf.Clamp(serializable.WanderingShipsDistance, 0, 1000);
			Hidden = serializable.Hidden;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<FactionData> Id;

		public readonly string Type;
		public readonly Color Color;
		public readonly int HomeStarDistance;
		public readonly int WanderingShipsDistance;
		public readonly bool Hidden;
	}
}
