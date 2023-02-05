//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System.Linq;
using EditorDatabase.Enums;
using EditorDatabase.Serializable;
using EditorDatabase.Model;

namespace EditorDatabase.DataModel
{
	public partial class ShipFeatures
	{
		partial void OnDataDeserialized(ShipFeaturesSerializable serializable, Database database);
		partial void OnDataSerialized(ref ShipFeaturesSerializable serializable);

		public ShipFeatures() {}

		public ShipFeatures(ShipFeaturesSerializable serializable, Database database)
		{
			EnergyResistance = new NumericValue<float>(serializable.EnergyResistance, -100f, 100f);
			KineticResistance = new NumericValue<float>(serializable.KineticResistance, -100f, 100f);
			HeatResistance = new NumericValue<float>(serializable.HeatResistance, -100f, 100f);
			WeightBonus = new NumericValue<float>(serializable.WeightBonus, -1f, 10f);
			VelocityBonus = new NumericValue<float>(serializable.VelocityBonus, -1f, 10f);
			TurnRateBonus = new NumericValue<float>(serializable.TurnRateBonus, -1f, 10f);
			ArmorBonus = new NumericValue<float>(serializable.ArmorBonus, -1f, 10f);
			ShieldBonus = new NumericValue<float>(serializable.ShieldBonus, -1f, 10f);
			EnergyBonus = new NumericValue<float>(serializable.EnergyBonus, -1f, 10f);
			Regeneration = serializable.Regeneration;
			BuiltinDevices = serializable.BuiltinDevices?.Select(id => new Wrapper<Device> { Item = database.GetDeviceId(id) }).ToArray();
			OnDataDeserialized(serializable, database);
		}

		public ShipFeaturesSerializable Serialize()
		{
			var serializable = new ShipFeaturesSerializable();
			serializable.EnergyResistance = EnergyResistance.Value;
			serializable.KineticResistance = KineticResistance.Value;
			serializable.HeatResistance = HeatResistance.Value;
			serializable.WeightBonus = WeightBonus.Value;
			serializable.VelocityBonus = VelocityBonus.Value;
			serializable.TurnRateBonus = TurnRateBonus.Value;
			serializable.ArmorBonus = ArmorBonus.Value;
			serializable.ShieldBonus = ShieldBonus.Value;
			serializable.EnergyBonus = EnergyBonus.Value;
			serializable.Regeneration = Regeneration;
			if (BuiltinDevices == null || BuiltinDevices.Length == 0)
			    serializable.BuiltinDevices = null;
			else
			    serializable.BuiltinDevices = BuiltinDevices.Select(wrapper => wrapper.Item.Value).ToArray();
			OnDataSerialized(ref serializable);
			return serializable;
		}

		public NumericValue<float> EnergyResistance = new NumericValue<float>(0, -100f, 100f);
		public NumericValue<float> KineticResistance = new NumericValue<float>(0, -100f, 100f);
		public NumericValue<float> HeatResistance = new NumericValue<float>(0, -100f, 100f);
		public NumericValue<float> WeightBonus = new NumericValue<float>(0, -1f, 10f);
		public NumericValue<float> VelocityBonus = new NumericValue<float>(0, -1f, 10f);
		public NumericValue<float> TurnRateBonus = new NumericValue<float>(0, -1f, 10f);
		public NumericValue<float> ArmorBonus = new NumericValue<float>(0, -1f, 10f);
		public NumericValue<float> ShieldBonus = new NumericValue<float>(0, -1f, 10f);
		public NumericValue<float> EnergyBonus = new NumericValue<float>(0, -1f, 10f);
		public bool Regeneration;
		public Wrapper<Device>[] BuiltinDevices;

		public static ShipFeatures DefaultValue { get; private set; }
	}
}
