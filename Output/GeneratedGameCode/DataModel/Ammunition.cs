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
	public partial class Ammunition
	{
		partial void OnDataDeserialized(AmmunitionSerializable serializable, Database database);

		public static Ammunition Create(AmmunitionSerializable serializable, Database database)
		{
			return new Ammunition(serializable, database);
		}

		private Ammunition(AmmunitionSerializable serializable, Database database)
		{
			Id = new ItemId<Ammunition>(serializable.Id);
			database.AddAmmunition(serializable.Id, this);

			Body = BulletBody.Create(serializable.Body, database);
			Triggers = new ImmutableCollection<BulletTrigger>(serializable.Triggers?.Select(item => BulletTrigger.Create(item, database)));
			ImpactType = serializable.ImpactType;
			Effects = new ImmutableCollection<ImpactEffect>(serializable.Effects?.Select(item => ImpactEffect.Create(item, database)));

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<Ammunition> Id;

		public BulletBody Body { get; private set; }
		public ImmutableCollection<BulletTrigger> Triggers { get; private set; }
		public BulletImpactType ImpactType { get; private set; }
		public ImmutableCollection<ImpactEffect> Effects { get; private set; }

		public static Ammunition DefaultValue { get; private set; }
	}
}
