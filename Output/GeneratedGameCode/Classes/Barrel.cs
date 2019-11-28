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
	public partial class BarrelData
	{
		partial void OnDataDeserialized(BarrelSerializable serializable, Database database);

		public static BarrelData Create(BarrelSerializable serializable, Database database)
		{
			return new BarrelData(serializable, database);
		}

		private BarrelData(BarrelSerializable serializable, Database database)
		{
			Position = serializable.Position;
			Rotation = UnityEngine.Mathf.Clamp(serializable.Rotation, -360f, 360f);
			Offset = UnityEngine.Mathf.Clamp(serializable.Offset, 0f, 1f);
			PlatformType = serializable.PlatformType;
			WeaponClass = serializable.WeaponClass;
			Image = new SpriteId(serializable.Image);
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0f, 10f);

			OnDataDeserialized(serializable, database);
		}

		public readonly Vector2 Position;
		public readonly float Rotation;
		public readonly float Offset;
		public readonly PlatformType PlatformType;
		public readonly string WeaponClass;
		public readonly SpriteId Image;
		public readonly float Size;
	}
}
