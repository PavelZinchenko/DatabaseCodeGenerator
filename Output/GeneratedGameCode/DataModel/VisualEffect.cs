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
	public partial class VisualEffect
	{
		partial void OnDataDeserialized(VisualEffectSerializable serializable, Database database);

		public static VisualEffect Create(VisualEffectSerializable serializable, Database database)
		{
			return new VisualEffect(serializable, database);
		}

		private VisualEffect(VisualEffectSerializable serializable, Database database)
		{
			Id = new ItemId<VisualEffect>(serializable.Id);
			database.AddVisualEffect(serializable.Id, this);

			Elements = new ImmutableCollection<VisualEffectElement>(serializable.Elements?.Select(item => VisualEffectElement.Create(item, database)));

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<VisualEffect> Id;

		public ImmutableCollection<VisualEffectElement> Elements { get; private set; }

		public static VisualEffect DefaultValue { get; private set; }
	}
}
