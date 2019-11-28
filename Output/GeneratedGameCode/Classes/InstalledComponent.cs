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
	public partial class InstalledComponentData
	{
		partial void OnDataDeserialized(InstalledComponentSerializable serializable, Database database);

		public static InstalledComponentData Create(InstalledComponentSerializable serializable, Database database)
		{
			return new InstalledComponentData(serializable, database);
		}

		private InstalledComponentData(InstalledComponentSerializable serializable, Database database)
		{
			ComponentId = database.GetComponent(new ItemId<ComponentData>(serializable.ComponentId));
			Modification = serializable.Modification;
			Quality = serializable.Quality;
			Locked = serializable.Locked;
			X = UnityEngine.Mathf.Clamp(serializable.X, -128, 127);
			Y = UnityEngine.Mathf.Clamp(serializable.Y, -128, 127);
			BarrelId = UnityEngine.Mathf.Clamp(serializable.BarrelId, 0, 32);
			Behaviour = UnityEngine.Mathf.Clamp(serializable.Behaviour, 0, 10);
			KeyBinding = UnityEngine.Mathf.Clamp(serializable.KeyBinding, -10, 10);

			OnDataDeserialized(serializable, database);
		}

		public readonly ComponentData ComponentId;
		public readonly ComponentModType Modification;
		public readonly ModificationQuality Quality;
		public readonly bool Locked;
		public readonly int X;
		public readonly int Y;
		public readonly int BarrelId;
		public readonly int Behaviour;
		public readonly int KeyBinding;
	}
}
