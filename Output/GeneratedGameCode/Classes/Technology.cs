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
	public abstract partial class TechnologyData
	{
		partial void OnDataDeserialized(TechnologySerializable serializable, Database database);

		public static TechnologyData Create(TechnologySerializable serializable, Database database)
		{
			switch (serializable.Type)
		    {
				case TechType.Component:
					return new TechnologyData_Component(serializable, database);
				case TechType.Satellite:
					return new TechnologyData_Satellite(serializable, database);
				case TechType.Ship:
					return new TechnologyData_Ship(serializable, database);
				default:
                    throw new DatabaseException("Technology: Invalid content type - " + serializable.Type);
			}
		}

		public abstract T Create<T>(ITechnologyDataFactory<T> factory);

		protected TechnologyData(TechnologySerializable serializable, Database database)
		{
			Id = new ItemId<TechnologyData>(serializable.Id);
			database.AddTechnology(serializable.Id, this);

			Type = serializable.Type;
			Price = UnityEngine.Mathf.Clamp(serializable.Price, 0, 1000);
			Hidden = serializable.Hidden;
			Special = serializable.Special;
			Dependencies = serializable.Dependencies?.Select(item => database.GetTechnology(new ItemId<TechnologyData>(item))).ToList().AsReadOnly();

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<TechnologyData> Id;

		public readonly TechType Type;
		public readonly int Price;
		public readonly bool Hidden;
		public readonly bool Special;
		public readonly System.Collections.ObjectModel.ReadOnlyCollection<TechnologyData> Dependencies;
	}

	public interface ITechnologyDataFactory<T>
    {
	    T Create(TechnologyData_Component content);
	    T Create(TechnologyData_Satellite content);
	    T Create(TechnologyData_Ship content);
    }

    public partial class TechnologyData_Component : TechnologyData
    {
		partial void OnDataDeserialized(TechnologySerializable serializable, Database database);

  		public TechnologyData_Component(TechnologySerializable serializable, Database database)
            : base(serializable, database)
        {
			Component = database.GetComponent(new ItemId<ComponentData>(serializable.Component));
			Faction = database.GetFaction(new ItemId<FactionData>(serializable.Faction));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ITechnologyDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly ComponentData Component;
		public readonly FactionData Faction;
    }
    public partial class TechnologyData_Satellite : TechnologyData
    {
		partial void OnDataDeserialized(TechnologySerializable serializable, Database database);

  		public TechnologyData_Satellite(TechnologySerializable serializable, Database database)
            : base(serializable, database)
        {
			Satellite = database.GetSatellite(new ItemId<SatelliteData>(serializable.Satellite));
			Faction = database.GetFaction(new ItemId<FactionData>(serializable.Faction));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ITechnologyDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly SatelliteData Satellite;
		public readonly FactionData Faction;
    }
    public partial class TechnologyData_Ship : TechnologyData
    {
		partial void OnDataDeserialized(TechnologySerializable serializable, Database database);

  		public TechnologyData_Ship(TechnologySerializable serializable, Database database)
            : base(serializable, database)
        {
			Ship = database.GetShip(new ItemId<ShipData>(serializable.Ship));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ITechnologyDataFactory<T> factory)
        {
            return factory.Create(this);
        }

		public readonly ShipData Ship;
    }

}

