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
	public partial class AmmunitionObsolete
	{
		public static AmmunitionObsolete Create(AmmunitionObsoleteSerializable serializable, Database database)
		{
			return new AmmunitionObsolete(serializable, database);
		}

		private AmmunitionObsolete(AmmunitionObsoleteSerializable serializable, Database database)
		{
			Id = new ItemId<AmmunitionObsolete>(serializable.Id);
			database.AddAmmunitionObsolete(serializable.Id, this);
			Stats = new AmmunitionObsoleteStats(serializable, database);
		}

		public readonly ItemId<AmmunitionObsolete> Id;
		public readonly AmmunitionObsoleteStats Stats;

		public static AmmunitionObsolete DefaultValue { get; private set; }
	}

	public partial struct AmmunitionObsoleteStats 
	{
		partial void OnDataDeserialized(AmmunitionObsoleteSerializable serializable, Database database);

		public AmmunitionObsoleteStats(AmmunitionObsoleteSerializable serializable, Database database)
		{
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
			CoupledAmmunition = database.GetAmmunitionObsolete(new ItemId<AmmunitionObsolete>(serializable.CoupledAmmunitionId));
			Color = new ColorData(serializable.Color);
			FireSound = new AudioClipId(serializable.FireSound);
			HitSound = new AudioClipId(serializable.HitSound);
			HitEffectPrefab = new PrefabId(serializable.HitEffectPrefab, PrefabId.Type.Effect);
			BulletPrefab = new PrefabId(serializable.BulletPrefab, PrefabId.Type.Bullet);

			OnDataDeserialized(serializable, database);
		}

		public AmmunitionClassObsolete AmmunitionClass;
		public DamageType DamageType;
		public float Impulse;
		public float Recoil;
		public float Size;
		public UnityEngine.Vector2 InitialPosition;
		public float AreaOfEffect;
		public float Damage;
		public float Range;
		public float Velocity;
		public float LifeTime;
		public int HitPoints;
		public bool IgnoresShipVelocity;
		public float EnergyCost;
		public AmmunitionObsolete CoupledAmmunition;
		public ColorData Color;
		public AudioClipId FireSound;
		public AudioClipId HitSound;
		public PrefabId HitEffectPrefab;
		public PrefabId BulletPrefab;
	}
}
