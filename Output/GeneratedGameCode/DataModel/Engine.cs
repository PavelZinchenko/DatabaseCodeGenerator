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
	public partial class Engine
	{
		partial void OnDataDeserialized(EngineSerializable serializable, Database database);

		public static Engine Create(EngineSerializable serializable, Database database)
		{
			return new Engine(serializable, database);
		}

		private Engine(EngineSerializable serializable, Database database)
		{
			Position = serializable.Position;
			Size = UnityEngine.Mathf.Clamp(serializable.Size, 0f, 1f);

			OnDataDeserialized(serializable, database);
		}

		public UnityEngine.Vector2 Position { get; private set; }
		public float Size { get; private set; }

		public static Engine DefaultValue { get; private set; }
	}
}
