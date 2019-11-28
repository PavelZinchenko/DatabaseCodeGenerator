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
	public partial class VisualEffectData
	{
		partial void OnDataDeserialized(VisualEffectSerializable serializable, Database database);

		public static VisualEffectData Create(VisualEffectSerializable serializable, Database database)
		{
			return new VisualEffectData(serializable, database);
		}

		private VisualEffectData(VisualEffectSerializable serializable, Database database)
		{
			Id = new ItemId<VisualEffectData>(serializable.Id);
			database.AddVisualEffect(serializable.Id, this);

			Elements = serializable.Elements?.Select(item => VisualEffectElementData.Create(item, database)).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<VisualEffectData> Id;

		public readonly System.Collections.ObjectModel.ReadOnlyCollection<VisualEffectElementData> Elements;
	}
}
