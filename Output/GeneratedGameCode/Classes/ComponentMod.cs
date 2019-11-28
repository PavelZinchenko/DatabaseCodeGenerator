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
	public partial class ComponentModData
	{
		partial void OnDataDeserialized(ComponentModSerializable serializable, Database database);

		public static ComponentModData Create(ComponentModSerializable serializable, Database database)
		{
			return new ComponentModData(serializable, database);
		}

		private ComponentModData(ComponentModSerializable serializable, Database database)
		{
			Id = new ItemId<ComponentModData>(serializable.Id);
			database.AddComponentMod(serializable.Id, this);

			Type = serializable.Type;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<ComponentModData> Id;

		public readonly ComponentModType Type;
	}
}
