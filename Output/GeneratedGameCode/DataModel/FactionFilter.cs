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
	public partial class RequiredFactions
	{
		partial void OnDataDeserialized(FactionFilterSerializable serializable, Database database);

		public static RequiredFactions Create(FactionFilterSerializable serializable, Database database)
		{
			return new RequiredFactions(serializable, database);
		}

		private RequiredFactions(FactionFilterSerializable serializable, Database database)
		{
			Type = serializable.Type;
			List = new ImmutableCollection<Faction>(serializable.List?.Select(item => database.GetFaction(new ItemId<Faction>(item))));

			OnDataDeserialized(serializable, database);
		}

		public FactionFilterType Type { get; private set; }
		public ImmutableCollection<Faction> List { get; private set; }

		public static RequiredFactions DefaultValue { get; private set; }
	}
}
