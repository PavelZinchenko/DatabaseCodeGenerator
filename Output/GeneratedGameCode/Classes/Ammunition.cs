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
	public partial class AmmunitionData
	{
		partial void OnDataDeserialized(AmmunitionSerializable serializable, Database database);

		public static AmmunitionData Create(AmmunitionSerializable serializable, Database database)
		{
			return new AmmunitionData(serializable, database);
		}

		private AmmunitionData(AmmunitionSerializable serializable, Database database)
		{
			Id = new ItemId<AmmunitionData>(serializable.Id);
			database.AddAmmunition(serializable.Id, this);

			Body = BulletBodyData.Create(serializable.Body, database);
			Triggers = serializable.Triggers?.Select(item => BulletTriggerData.Create(item, database)).ToList().AsReadOnly();
			ImpactType = serializable.ImpactType;
			Effects = serializable.Effects?.Select(item => ImpactEffectData.Create(item, database)).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<AmmunitionData> Id;

		public readonly BulletBodyData Body;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<BulletTriggerData> Triggers;
		public readonly BulletImpactType ImpactType;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<ImpactEffectData> Effects;
	}
}
