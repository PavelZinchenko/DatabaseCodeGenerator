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
	public partial class FactionFilterData
	{
		partial void OnDataDeserialized(FactionFilterSerializable serializable, Database database);

		public static FactionFilterData Create(FactionFilterSerializable serializable, Database database)
		{
			return new FactionFilterData(serializable, database);
		}

		private FactionFilterData(FactionFilterSerializable serializable, Database database)
		{
			Type = serializable.Type;
			List = serializable.List?.Select(item => database.GetFaction(new ItemId<FactionData>(item))).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly FactionFilterType Type;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<FactionData> List;
	}
}
