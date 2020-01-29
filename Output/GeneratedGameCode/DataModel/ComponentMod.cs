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
	public partial class ComponentMod
	{
		partial void OnDataDeserialized(ComponentModSerializable serializable, Database database);

		public static ComponentMod Create(ComponentModSerializable serializable, Database database)
		{
			return new ComponentMod(serializable, database);
		}

		private ComponentMod(ComponentModSerializable serializable, Database database)
		{
			Id = new ItemId<ComponentMod>(serializable.Id);
			database.AddComponentMod(serializable.Id, this);

			Type = serializable.Type;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<ComponentMod> Id;

		public ComponentModType Type { get; private set; }

		public static ComponentMod DefaultValue { get; private set; }
	}
}
