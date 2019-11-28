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
	public partial class BulletPrefabData
	{
		partial void OnDataDeserialized(BulletPrefabSerializable serializable, Database database);

		public static BulletPrefabData Create(BulletPrefabSerializable serializable, Database database)
		{
			return new BulletPrefabData(serializable, database);
		}

		private BulletPrefabData(BulletPrefabSerializable serializable, Database database)
		{
			Id = new ItemId<BulletPrefabData>(serializable.Id);
			database.AddBulletPrefab(serializable.Id, this);

			Shape = serializable.Shape;
			Image = new SpriteId(serializable.Image);
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0.01f, 100f);
			Margins = UnityEngine.Mathf.Clamp(serializable.Margins, 0f, 1f);
			MainColor = new Color(serializable.MainColor);
			MainColorMode = serializable.MainColorMode;
			SecondColor = new Color(serializable.SecondColor);
			SecondColorMode = serializable.SecondColorMode;

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<BulletPrefabData> Id;

		public readonly BulletShape Shape;
		public readonly SpriteId Image;
		public readonly float Size;
		public readonly float Margins;
		public readonly Color MainColor;
		public readonly ColorMode MainColorMode;
		public readonly Color SecondColor;
		public readonly ColorMode SecondColorMode;
	}
}
