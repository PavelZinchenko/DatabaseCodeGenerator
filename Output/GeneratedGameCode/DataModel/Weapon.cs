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
	public partial class Weapon
	{
		public static Weapon Create(WeaponSerializable serializable, Database database)
		{
			return new Weapon(serializable, database);
		}

		private Weapon(WeaponSerializable serializable, Database database)
		{
			Id = new ItemId<Weapon>(serializable.Id);
			database.AddWeapon(serializable.Id, this);
			Stats = new WeaponStats(serializable, database);
		}

		public readonly ItemId<Weapon> Id;
		public readonly WeaponStats Stats;

		public static Weapon DefaultValue { get; private set; }
	}

	public partial struct WeaponStats 
	{
		partial void OnDataDeserialized(WeaponSerializable serializable, Database database);

		public WeaponStats(WeaponSerializable serializable, Database database)
		{
			WeaponClass = serializable.WeaponClass;
			FireRate = UnityEngine.Mathf.Clamp(serializable.FireRate, 0f, 100f);
			Spread = UnityEngine.Mathf.Clamp(serializable.Spread, 0f, 180f);
			Magazine = UnityEngine.Mathf.Clamp(serializable.Magazine, 0, 1000);
			ActivationType = serializable.ActivationType;
			ShotSound = new AudioClipId(serializable.ShotSound);
			ChargeSound = new AudioClipId(serializable.ChargeSound);
			ShotEffectPrefab = new PrefabId(serializable.ShotEffectPrefab, PrefabId.Type.Effect);
			ControlButtonIcon = new SpriteId(serializable.ControlButtonIcon, SpriteId.Type.ActionButton);

			OnDataDeserialized(serializable, database);
		}

		public WeaponClass WeaponClass;
		public float FireRate;
		public float Spread;
		public int Magazine;
		public ActivationType ActivationType;
		public AudioClipId ShotSound;
		public AudioClipId ChargeSound;
		public PrefabId ShotEffectPrefab;
		public SpriteId ControlButtonIcon;
	}
}
