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
	public partial class WeaponData
	{
		public static WeaponData Create(WeaponSerializable serializable, Database database)
		{
			return new WeaponData(serializable, database);
		}

		private WeaponData(WeaponSerializable serializable, Database database)
		{
			Id = new ItemId<WeaponData>(serializable.Id);
			database.AddWeapon(serializable.Id, this);
			Stats = new WeaponStats(serializable, database);
		}

		public readonly ItemId<WeaponData> Id;
		public readonly WeaponStats Stats;
	}

	public partial struct WeaponStats 
	{
		partial void OnDataDeserialized(WeaponSerializable serializable, Database database);

		public WeaponStats(WeaponSerializable serializable, Database database)
		{
			WeaponClass = serializable.WeaponClass;
			FireRate = UnityEngine.Mathf.Clamp(serializable.FireRate, 0.001f, 100f);
			Spread = UnityEngine.Mathf.Clamp(serializable.Spread, 0f, 180f);
			Magazine = UnityEngine.Mathf.Clamp(serializable.Magazine, 0, 1000);
			ActivationType = serializable.ActivationType;
			ShotSound = new AudioClipId(serializable.ShotSound);
			ChargeSound = new AudioClipId(serializable.ChargeSound);
			ShotEffectPrefab = serializable.ShotEffectPrefab;
			ControlButtonIcon = serializable.ControlButtonIcon;

			OnDataDeserialized(serializable, database);
		}

		public WeaponClass WeaponClass;
		public float FireRate;
		public float Spread;
		public int Magazine;
		public ActivationType ActivationType;
		public AudioClipId ShotSound;
		public AudioClipId ChargeSound;
		public string ShotEffectPrefab;
		public string ControlButtonIcon;
	}
}
