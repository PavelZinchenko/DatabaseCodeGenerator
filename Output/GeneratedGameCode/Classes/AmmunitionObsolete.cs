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
	public partial class AmmunitionObsoleteData
	{
		partial void OnDataDeserialized(AmmunitionObsoleteSerializable serializable, Database database);

		public static AmmunitionObsoleteData Create(AmmunitionObsoleteSerializable serializable, Database database)
		{
			return new AmmunitionObsoleteData(serializable, database);
		}

		private AmmunitionObsoleteData(AmmunitionObsoleteSerializable serializable, Database database)
		{
			Id = new ItemId<AmmunitionObsoleteData>(serializable.Id);
			database.AddAmmunitionObsolete(serializable.Id, this);

			AmmunitionClass = serializable.AmmunitionClass;
			DamageType = serializable.DamageType;
			Impulse = UnityEngine.Mathf.Clamp(serializable.Impulse, 0f, 10f);
			Recoil = UnityEngine.Mathf.Clamp(serializable.Recoil, 0f, 10f);
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0f, 1000f);
			InitialPosition = serializable.InitialPosition;
			AreaOfEffect = UnityEngine.Mathf.Clamp(serializable.AreaOfEffect, 0f, 1000f);
			Damage = UnityEngine.Mathf.Clamp(serializable.Damage, 0f, 1000f);
			Range = UnityEngine.Mathf.Clamp(serializable.Range, 0f, 1000f);
			Velocity = UnityEngine.Mathf.Clamp(serializable.Velocity, 0f, 1000f);
			LifeTime = UnityEngine.Mathf.Clamp(serializable.LifeTime, 0f, 1000f);
			HitPoints = UnityEngine.Mathf.Clamp(serializable.HitPoints, 0, 1000);
			IgnoresShipVelocity = serializable.IgnoresShipVelocity;
			EnergyCost = UnityEngine.Mathf.Clamp(serializable.EnergyCost, 0f, 1000f);
			CoupledAmmunitionId = database.GetAmmunitionObsolete(new ItemId<AmmunitionObsoleteData>(serializable.CoupledAmmunitionId));
			Color = new Color(serializable.Color);
			FireSound = new AudioClipId(serializable.FireSound);
			HitEffectPrefab = serializable.HitEffectPrefab;
			BulletPrefab = serializable.BulletPrefab;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<AmmunitionObsoleteData> Id;

		public readonly AmmunitionClassObsolete AmmunitionClass;
		public readonly DamageType DamageType;
		public readonly float Impulse;
		public readonly float Recoil;
		public readonly float Size;
		public readonly Vector2 InitialPosition;
		public readonly float AreaOfEffect;
		public readonly float Damage;
		public readonly float Range;
		public readonly float Velocity;
		public readonly float LifeTime;
		public readonly int HitPoints;
		public readonly bool IgnoresShipVelocity;
		public readonly float EnergyCost;
		public readonly AmmunitionObsoleteData CoupledAmmunitionId;
		public readonly Color Color;
		public readonly AudioClipId FireSound;
		public readonly string HitEffectPrefab;
		public readonly string BulletPrefab;
	}
}
