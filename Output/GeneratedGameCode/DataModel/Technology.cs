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
	public abstract partial class Technology
	{
		partial void OnDataDeserialized(TechnologySerializable serializable, Database database);

		public static Technology Create(TechnologySerializable serializable, Database database)
		{
			switch (serializable.Type)
		    {
				case TechType.Component:
					return new Technology_Component(serializable, database);
				case TechType.Ship:
					return new Technology_Ship(serializable, database);
				case TechType.Satellite:
					return new Technology_Satellite(serializable, database);
				default:
                    throw new DatabaseException("Technology: Invalid content type - " + serializable.Type);
			}
		}

		public abstract T Create<T>(ITechnologyFactory<T> factory);

		protected Technology(TechnologySerializable serializable, Database database)
		{
			Id = new ItemId<Technology>(serializable.Id);
			database.AddTechnology(serializable.Id, this);

			Type = serializable.Type;
			Price = UnityEngine.Mathf.Clamp(serializable.Price, 0, 1000);
			Hidden = serializable.Hidden;
			Special = serializable.Special;
			Dependencies = new ImmutableCollection<Technology>(serializable.Dependencies?.Select(item => database.GetTechnology(new ItemId<Technology>(item))));

			OnDataDeserialized(serializable, database);
		}

		public readonly ItemId<Technology> Id;

		public TechType Type { get; private set; }
		public int Price { get; private set; }
		public bool Hidden { get; private set; }
		public bool Special { get; private set; }
		public ImmutableCollection<Technology> Dependencies { get; private set; }

		public static Technology DefaultValue { get; private set; }
	}

	public interface ITechnologyFactory<T>
    {
	    T Create(Technology_Component content);
	    T Create(Technology_Ship content);
	    T Create(Technology_Satellite content);
    }

    public partial class Technology_Component : Technology
    {
		partial void OnDataDeserialized(TechnologySerializable serializable, Database database);

  		public Technology_Component(TechnologySerializable serializable, Database database)
            : base(serializable, database)
        {
			Component = database.GetComponent(new ItemId<Component>(serializable.ItemId));
			Faction = database.GetFaction(new ItemId<Faction>(serializable.Faction));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ITechnologyFactory<T> factory)
        {
            return factory.Create(this);
        }

		public Component Component { get; private set; }
		public Faction Faction { get; private set; }
    }
    public partial class Technology_Ship : Technology
    {
		partial void OnDataDeserialized(TechnologySerializable serializable, Database database);

  		public Technology_Ship(TechnologySerializable serializable, Database database)
            : base(serializable, database)
        {
			Ship = database.GetShip(new ItemId<Ship>(serializable.ItemId));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ITechnologyFactory<T> factory)
        {
            return factory.Create(this);
        }

		public Ship Ship { get; private set; }
    }
    public partial class Technology_Satellite : Technology
    {
		partial void OnDataDeserialized(TechnologySerializable serializable, Database database);

  		public Technology_Satellite(TechnologySerializable serializable, Database database)
            : base(serializable, database)
        {
			Satellite = database.GetSatellite(new ItemId<Satellite>(serializable.ItemId));
			Faction = database.GetFaction(new ItemId<Faction>(serializable.Faction));

            OnDataDeserialized(serializable, database);
        }

        public override T Create<T>(ITechnologyFactory<T> factory)
        {
            return factory.Create(this);
        }

		public Satellite Satellite { get; private set; }
		public Faction Faction { get; private set; }
    }

}

