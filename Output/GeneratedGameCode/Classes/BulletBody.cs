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
	public partial class BulletBodyData
	{
		partial void OnDataDeserialized(BulletBodySerializable serializable, Database database);

		public static BulletBodyData Create(BulletBodySerializable serializable, Database database)
		{
			return new BulletBodyData(serializable, database);
		}

		private BulletBodyData(BulletBodySerializable serializable, Database database)
		{
			Type = serializable.Type;
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0f, 1000f);
			Velocity = UnityEngine.Mathf.Clamp(serializable.Velocity, 0f, 1000f);
			Range = UnityEngine.Mathf.Clamp(serializable.Range, 0f, 1000f);
			Lifetime = UnityEngine.Mathf.Clamp(serializable.Lifetime, 0f, 1000f);
			Weight = UnityEngine.Mathf.Clamp(serializable.Weight, 0f, 1000f);
			HitPoints = UnityEngine.Mathf.Clamp(serializable.HitPoints, 0, 1000);
			Color = new Color(serializable.Color);
			BulletPrefab = database.GetBulletPrefab(new ItemId<BulletPrefabData>(serializable.BulletPrefab));
			EnergyCost = UnityEngine.Mathf.Clamp(serializable.EnergyCost, 0f, 1000f);
			CanBeDisarmed = serializable.CanBeDisarmed;
			FriendlyFire = serializable.FriendlyFire;

			OnDataDeserialized(serializable, database);
		}

		public readonly BulletType Type;
		public readonly float Size;
		public readonly float Velocity;
		public readonly float Range;
		public readonly float Lifetime;
		public readonly float Weight;
		public readonly int HitPoints;
		public readonly Color Color;
		public readonly BulletPrefabData BulletPrefab;
		public readonly float EnergyCost;
		public readonly bool CanBeDisarmed;
		public readonly bool FriendlyFire;
	}
}
