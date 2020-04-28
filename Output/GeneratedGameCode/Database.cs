//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using GameDatabase.DataModel;
using GameDatabase.Storage;
using GameDatabase.Model;

namespace GameDatabase
{
	public partial interface IDatabase
	{
		DatabaseSettings DatabaseSettings { get; }
		GalaxySettings GalaxySettings { get; }
		ShipSettings ShipSettings { get; }

		IEnumerable<AmmunitionObsolete> AmmunitionObsoleteList { get; }
		IEnumerable<Component> ComponentList { get; }
		IEnumerable<ComponentMod> ComponentModList { get; }
		IEnumerable<ComponentStats> ComponentStatsList { get; }
		IEnumerable<Device> DeviceList { get; }
		IEnumerable<DroneBay> DroneBayList { get; }
		IEnumerable<Faction> FactionList { get; }
		IEnumerable<Satellite> SatelliteList { get; }
		IEnumerable<SatelliteBuild> SatelliteBuildList { get; }
		IEnumerable<Ship> ShipList { get; }
		IEnumerable<ShipBuild> ShipBuildList { get; }
		IEnumerable<Skill> SkillList { get; }
		IEnumerable<Technology> TechnologyList { get; }
		IEnumerable<Character> CharacterList { get; }
		IEnumerable<Fleet> FleetList { get; }
		IEnumerable<LootModel> LootList { get; }
		IEnumerable<QuestModel> QuestList { get; }
		IEnumerable<QuestItem> QuestItemList { get; }
		IEnumerable<Ammunition> AmmunitionList { get; }
		IEnumerable<BulletPrefab> BulletPrefabList { get; }
		IEnumerable<VisualEffect> VisualEffectList { get; }
		IEnumerable<Weapon> WeaponList { get; }

		AmmunitionObsolete GetAmmunitionObsolete(ItemId<AmmunitionObsolete> id);
		Component GetComponent(ItemId<Component> id);
		ComponentMod GetComponentMod(ItemId<ComponentMod> id);
		ComponentStats GetComponentStats(ItemId<ComponentStats> id);
		Device GetDevice(ItemId<Device> id);
		DroneBay GetDroneBay(ItemId<DroneBay> id);
		Faction GetFaction(ItemId<Faction> id);
		Satellite GetSatellite(ItemId<Satellite> id);
		SatelliteBuild GetSatelliteBuild(ItemId<SatelliteBuild> id);
		Ship GetShip(ItemId<Ship> id);
		ShipBuild GetShipBuild(ItemId<ShipBuild> id);
		Skill GetSkill(ItemId<Skill> id);
		Technology GetTechnology(ItemId<Technology> id);
		Character GetCharacter(ItemId<Character> id);
		Fleet GetFleet(ItemId<Fleet> id);
		LootModel GetLoot(ItemId<LootModel> id);
		QuestModel GetQuest(ItemId<QuestModel> id);
		QuestItem GetQuestItem(ItemId<QuestItem> id);
		Ammunition GetAmmunition(ItemId<Ammunition> id);
		BulletPrefab GetBulletPrefab(ItemId<BulletPrefab> id);
		VisualEffect GetVisualEffect(ItemId<VisualEffect> id);
		Weapon GetWeapon(ItemId<Weapon> id);

        ImageData GetImage(string name);
        AudioClipData GetAudioClip(string name);
        string GetLocalization(string language);
	}

    public partial class Database : IDatabase
    {
        partial void OnDataLoaded();
        partial void OnDataInitialized();

		public DatabaseSettings DatabaseSettings { get; private set; }
		public GalaxySettings GalaxySettings { get; private set; }
		public ShipSettings ShipSettings { get; private set; }

		public IEnumerable<AmmunitionObsolete> AmmunitionObsoleteList => _ammunitionObsoleteMap.Values;
		public IEnumerable<Component> ComponentList => _componentMap.Values;
		public IEnumerable<ComponentMod> ComponentModList => _componentModMap.Values;
		public IEnumerable<ComponentStats> ComponentStatsList => _componentStatsMap.Values;
		public IEnumerable<Device> DeviceList => _deviceMap.Values;
		public IEnumerable<DroneBay> DroneBayList => _droneBayMap.Values;
		public IEnumerable<Faction> FactionList => _factionMap.Values;
		public IEnumerable<Satellite> SatelliteList => _satelliteMap.Values;
		public IEnumerable<SatelliteBuild> SatelliteBuildList => _satelliteBuildMap.Values;
		public IEnumerable<Ship> ShipList => _shipMap.Values;
		public IEnumerable<ShipBuild> ShipBuildList => _shipBuildMap.Values;
		public IEnumerable<Skill> SkillList => _skillMap.Values;
		public IEnumerable<Technology> TechnologyList => _technologyMap.Values;
		public IEnumerable<Character> CharacterList => _characterMap.Values;
		public IEnumerable<Fleet> FleetList => _fleetMap.Values;
		public IEnumerable<LootModel> LootList => _lootMap.Values;
		public IEnumerable<QuestModel> QuestList => _questMap.Values;
		public IEnumerable<QuestItem> QuestItemList => _questItemMap.Values;
		public IEnumerable<Ammunition> AmmunitionList => _ammunitionMap.Values;
		public IEnumerable<BulletPrefab> BulletPrefabList => _bulletPrefabMap.Values;
		public IEnumerable<VisualEffect> VisualEffectList => _visualEffectMap.Values;
		public IEnumerable<Weapon> WeaponList => _weaponMap.Values;

		public AmmunitionObsolete GetAmmunitionObsolete(ItemId<AmmunitionObsolete> id) { return (_ammunitionObsoleteMap.TryGetValue(id.Value, out var item)) ? item : AmmunitionObsolete.DefaultValue; }
		public Component GetComponent(ItemId<Component> id) { return (_componentMap.TryGetValue(id.Value, out var item)) ? item : Component.DefaultValue; }
		public ComponentMod GetComponentMod(ItemId<ComponentMod> id) { return (_componentModMap.TryGetValue(id.Value, out var item)) ? item : ComponentMod.DefaultValue; }
		public ComponentStats GetComponentStats(ItemId<ComponentStats> id) { return (_componentStatsMap.TryGetValue(id.Value, out var item)) ? item : ComponentStats.DefaultValue; }
		public Device GetDevice(ItemId<Device> id) { return (_deviceMap.TryGetValue(id.Value, out var item)) ? item : Device.DefaultValue; }
		public DroneBay GetDroneBay(ItemId<DroneBay> id) { return (_droneBayMap.TryGetValue(id.Value, out var item)) ? item : DroneBay.DefaultValue; }
		public Faction GetFaction(ItemId<Faction> id) { return (_factionMap.TryGetValue(id.Value, out var item)) ? item : Faction.DefaultValue; }
		public Satellite GetSatellite(ItemId<Satellite> id) { return (_satelliteMap.TryGetValue(id.Value, out var item)) ? item : Satellite.DefaultValue; }
		public SatelliteBuild GetSatelliteBuild(ItemId<SatelliteBuild> id) { return (_satelliteBuildMap.TryGetValue(id.Value, out var item)) ? item : SatelliteBuild.DefaultValue; }
		public Ship GetShip(ItemId<Ship> id) { return (_shipMap.TryGetValue(id.Value, out var item)) ? item : Ship.DefaultValue; }
		public ShipBuild GetShipBuild(ItemId<ShipBuild> id) { return (_shipBuildMap.TryGetValue(id.Value, out var item)) ? item : ShipBuild.DefaultValue; }
		public Skill GetSkill(ItemId<Skill> id) { return (_skillMap.TryGetValue(id.Value, out var item)) ? item : Skill.DefaultValue; }
		public Technology GetTechnology(ItemId<Technology> id) { return (_technologyMap.TryGetValue(id.Value, out var item)) ? item : Technology.DefaultValue; }
		public Character GetCharacter(ItemId<Character> id) { return (_characterMap.TryGetValue(id.Value, out var item)) ? item : Character.DefaultValue; }
		public Fleet GetFleet(ItemId<Fleet> id) { return (_fleetMap.TryGetValue(id.Value, out var item)) ? item : Fleet.DefaultValue; }
		public LootModel GetLoot(ItemId<LootModel> id) { return (_lootMap.TryGetValue(id.Value, out var item)) ? item : LootModel.DefaultValue; }
		public QuestModel GetQuest(ItemId<QuestModel> id) { return (_questMap.TryGetValue(id.Value, out var item)) ? item : QuestModel.DefaultValue; }
		public QuestItem GetQuestItem(ItemId<QuestItem> id) { return (_questItemMap.TryGetValue(id.Value, out var item)) ? item : QuestItem.DefaultValue; }
		public Ammunition GetAmmunition(ItemId<Ammunition> id) { return (_ammunitionMap.TryGetValue(id.Value, out var item)) ? item : Ammunition.DefaultValue; }
		public BulletPrefab GetBulletPrefab(ItemId<BulletPrefab> id) { return (_bulletPrefabMap.TryGetValue(id.Value, out var item)) ? item : BulletPrefab.DefaultValue; }
		public VisualEffect GetVisualEffect(ItemId<VisualEffect> id) { return (_visualEffectMap.TryGetValue(id.Value, out var item)) ? item : VisualEffect.DefaultValue; }
		public Weapon GetWeapon(ItemId<Weapon> id) { return (_weaponMap.TryGetValue(id.Value, out var item)) ? item : Weapon.DefaultValue; }

        public ImageData GetImage(string name) { return _images.TryGetValue(name, out var image) ? image : ImageData.Empty; }
        public AudioClipData GetAudioClip(string name) { return _audioClips.TryGetValue(name, out var audioClip) ? audioClip : AudioClipData.Empty; }
        public string GetLocalization(string language) { return _localizations.TryGetValue(language, out var data) ? data : null; }

        private void Clear()
        {
			_ammunitionObsoleteMap.Clear();
			_componentMap.Clear();
			_componentModMap.Clear();
			_componentStatsMap.Clear();
			_deviceMap.Clear();
			_droneBayMap.Clear();
			_factionMap.Clear();
			_satelliteMap.Clear();
			_satelliteBuildMap.Clear();
			_shipMap.Clear();
			_shipBuildMap.Clear();
			_skillMap.Clear();
			_technologyMap.Clear();
			_characterMap.Clear();
			_fleetMap.Clear();
			_lootMap.Clear();
			_questMap.Clear();
			_questItemMap.Clear();
			_ammunitionMap.Clear();
			_bulletPrefabMap.Clear();
			_visualEffectMap.Clear();
			_weaponMap.Clear();

			DatabaseSettings = null;
			GalaxySettings = null;
			ShipSettings = null;

			_images.Clear();
			_audioClips.Clear();
			_localizations.Clear();
        }

		private readonly Dictionary<int, AmmunitionObsolete> _ammunitionObsoleteMap = new Dictionary<int, AmmunitionObsolete>();
		private readonly Dictionary<int, Component> _componentMap = new Dictionary<int, Component>();
		private readonly Dictionary<int, ComponentMod> _componentModMap = new Dictionary<int, ComponentMod>();
		private readonly Dictionary<int, ComponentStats> _componentStatsMap = new Dictionary<int, ComponentStats>();
		private readonly Dictionary<int, Device> _deviceMap = new Dictionary<int, Device>();
		private readonly Dictionary<int, DroneBay> _droneBayMap = new Dictionary<int, DroneBay>();
		private readonly Dictionary<int, Faction> _factionMap = new Dictionary<int, Faction>();
		private readonly Dictionary<int, Satellite> _satelliteMap = new Dictionary<int, Satellite>();
		private readonly Dictionary<int, SatelliteBuild> _satelliteBuildMap = new Dictionary<int, SatelliteBuild>();
		private readonly Dictionary<int, Ship> _shipMap = new Dictionary<int, Ship>();
		private readonly Dictionary<int, ShipBuild> _shipBuildMap = new Dictionary<int, ShipBuild>();
		private readonly Dictionary<int, Skill> _skillMap = new Dictionary<int, Skill>();
		private readonly Dictionary<int, Technology> _technologyMap = new Dictionary<int, Technology>();
		private readonly Dictionary<int, Character> _characterMap = new Dictionary<int, Character>();
		private readonly Dictionary<int, Fleet> _fleetMap = new Dictionary<int, Fleet>();
		private readonly Dictionary<int, LootModel> _lootMap = new Dictionary<int, LootModel>();
		private readonly Dictionary<int, QuestModel> _questMap = new Dictionary<int, QuestModel>();
		private readonly Dictionary<int, QuestItem> _questItemMap = new Dictionary<int, QuestItem>();
		private readonly Dictionary<int, Ammunition> _ammunitionMap = new Dictionary<int, Ammunition>();
		private readonly Dictionary<int, BulletPrefab> _bulletPrefabMap = new Dictionary<int, BulletPrefab>();
		private readonly Dictionary<int, VisualEffect> _visualEffectMap = new Dictionary<int, VisualEffect>();
		private readonly Dictionary<int, Weapon> _weaponMap = new Dictionary<int, Weapon>();
	
        private readonly Dictionary<string, ImageData> _images = new Dictionary<string, ImageData>(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<string, AudioClipData> _audioClips = new Dictionary<string, AudioClipData>(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<string, string> _localizations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

		public class Loader
        {
            public Loader(Database database)
            {
                _database = database;
            }

			public ImmutableCollection<DatabaseContent> Contents;

			public void Load()
            {
                for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var content = Contents[i];

					foreach (var item in content.AmmunitionObsoleteList)
						GetAmmunitionObsolete(new ItemId<AmmunitionObsolete>(item.Id));
					foreach (var item in content.ComponentList)
						GetComponent(new ItemId<Component>(item.Id));
					foreach (var item in content.ComponentModList)
						GetComponentMod(new ItemId<ComponentMod>(item.Id));
					foreach (var item in content.ComponentStatsList)
						GetComponentStats(new ItemId<ComponentStats>(item.Id));
					foreach (var item in content.DeviceList)
						GetDevice(new ItemId<Device>(item.Id));
					foreach (var item in content.DroneBayList)
						GetDroneBay(new ItemId<DroneBay>(item.Id));
					foreach (var item in content.FactionList)
						GetFaction(new ItemId<Faction>(item.Id));
					foreach (var item in content.SatelliteList)
						GetSatellite(new ItemId<Satellite>(item.Id));
					foreach (var item in content.SatelliteBuildList)
						GetSatelliteBuild(new ItemId<SatelliteBuild>(item.Id));
					foreach (var item in content.ShipList)
						GetShip(new ItemId<Ship>(item.Id));
					foreach (var item in content.ShipBuildList)
						GetShipBuild(new ItemId<ShipBuild>(item.Id));
					foreach (var item in content.SkillList)
						GetSkill(new ItemId<Skill>(item.Id));
					foreach (var item in content.TechnologyList)
						GetTechnology(new ItemId<Technology>(item.Id));
					foreach (var item in content.CharacterList)
						GetCharacter(new ItemId<Character>(item.Id));
					foreach (var item in content.FleetList)
						GetFleet(new ItemId<Fleet>(item.Id));
					foreach (var item in content.LootList)
						GetLoot(new ItemId<LootModel>(item.Id));
					foreach (var item in content.QuestList)
						GetQuest(new ItemId<QuestModel>(item.Id));
					foreach (var item in content.QuestItemList)
						GetQuestItem(new ItemId<QuestItem>(item.Id));
					foreach (var item in content.AmmunitionList)
						GetAmmunition(new ItemId<Ammunition>(item.Id));
					foreach (var item in content.BulletPrefabList)
						GetBulletPrefab(new ItemId<BulletPrefab>(item.Id));
					foreach (var item in content.VisualEffectList)
						GetVisualEffect(new ItemId<VisualEffect>(item.Id));
					foreach (var item in content.WeaponList)
						GetWeapon(new ItemId<Weapon>(item.Id));

                    foreach (var item in content.Images)
                        if (!_database._images.ContainsKey(item.Key))
                            _database._images.Add(item.Key, item.Value);

                    foreach (var item in content.AudioClips)
                        if (!_database._audioClips.ContainsKey(item.Key))
                            _database._audioClips.Add(item.Key, item.Value);

                    foreach (var item in content.Localizations)
                        if (!_database._localizations.ContainsKey(item.Key))
                            _database._localizations.Add(item.Key, item.Value);

					if (_database.DatabaseSettings == null && content.DatabaseSettings != null) _database.DatabaseSettings = DatabaseSettings.Create(content.DatabaseSettings, this);
					if (_database.GalaxySettings == null && content.GalaxySettings != null) _database.GalaxySettings = GalaxySettings.Create(content.GalaxySettings, this);
					if (_database.ShipSettings == null && content.ShipSettings != null) _database.ShipSettings = ShipSettings.Create(content.ShipSettings, this);
				}

				if (_database.DatabaseSettings == null) _database.DatabaseSettings = DatabaseSettings.Create(
					new Serializable.DatabaseSettingsSerializable { ItemType = Enums.ItemType.DatabaseSettings }, this);
				if (_database.GalaxySettings == null) _database.GalaxySettings = GalaxySettings.Create(
					new Serializable.GalaxySettingsSerializable { ItemType = Enums.ItemType.GalaxySettings }, this);
				if (_database.ShipSettings == null) _database.ShipSettings = ShipSettings.Create(
					new Serializable.ShipSettingsSerializable { ItemType = Enums.ItemType.ShipSettings }, this);
			}

			public AmmunitionObsolete GetAmmunitionObsolete(ItemId<AmmunitionObsolete> id)
			{
				if (_database._ammunitionObsoleteMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetAmmunitionObsolete(id.Value);
                    if (serializable != null) return AmmunitionObsolete.Create(serializable, this);
                }

                return AmmunitionObsolete.DefaultValue;
			}
			public Component GetComponent(ItemId<Component> id)
			{
				if (_database._componentMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetComponent(id.Value);
                    if (serializable != null) return Component.Create(serializable, this);
                }

                return Component.DefaultValue;
			}
			public ComponentMod GetComponentMod(ItemId<ComponentMod> id)
			{
				if (_database._componentModMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetComponentMod(id.Value);
                    if (serializable != null) return ComponentMod.Create(serializable, this);
                }

                return ComponentMod.DefaultValue;
			}
			public ComponentStats GetComponentStats(ItemId<ComponentStats> id)
			{
				if (_database._componentStatsMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetComponentStats(id.Value);
                    if (serializable != null) return ComponentStats.Create(serializable, this);
                }

                return ComponentStats.DefaultValue;
			}
			public Device GetDevice(ItemId<Device> id)
			{
				if (_database._deviceMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetDevice(id.Value);
                    if (serializable != null) return Device.Create(serializable, this);
                }

                return Device.DefaultValue;
			}
			public DroneBay GetDroneBay(ItemId<DroneBay> id)
			{
				if (_database._droneBayMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetDroneBay(id.Value);
                    if (serializable != null) return DroneBay.Create(serializable, this);
                }

                return DroneBay.DefaultValue;
			}
			public Faction GetFaction(ItemId<Faction> id)
			{
				if (_database._factionMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetFaction(id.Value);
                    if (serializable != null) return Faction.Create(serializable, this);
                }

                return Faction.DefaultValue;
			}
			public Satellite GetSatellite(ItemId<Satellite> id)
			{
				if (_database._satelliteMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetSatellite(id.Value);
                    if (serializable != null) return Satellite.Create(serializable, this);
                }

                return Satellite.DefaultValue;
			}
			public SatelliteBuild GetSatelliteBuild(ItemId<SatelliteBuild> id)
			{
				if (_database._satelliteBuildMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetSatelliteBuild(id.Value);
                    if (serializable != null) return SatelliteBuild.Create(serializable, this);
                }

                return SatelliteBuild.DefaultValue;
			}
			public Ship GetShip(ItemId<Ship> id)
			{
				if (_database._shipMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetShip(id.Value);
                    if (serializable != null) return Ship.Create(serializable, this);
                }

                return Ship.DefaultValue;
			}
			public ShipBuild GetShipBuild(ItemId<ShipBuild> id)
			{
				if (_database._shipBuildMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetShipBuild(id.Value);
                    if (serializable != null) return ShipBuild.Create(serializable, this);
                }

                return ShipBuild.DefaultValue;
			}
			public Skill GetSkill(ItemId<Skill> id)
			{
				if (_database._skillMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetSkill(id.Value);
                    if (serializable != null) return Skill.Create(serializable, this);
                }

                return Skill.DefaultValue;
			}
			public Technology GetTechnology(ItemId<Technology> id)
			{
				if (_database._technologyMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetTechnology(id.Value);
                    if (serializable != null) return Technology.Create(serializable, this);
                }

                return Technology.DefaultValue;
			}
			public Character GetCharacter(ItemId<Character> id)
			{
				if (_database._characterMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetCharacter(id.Value);
                    if (serializable != null) return Character.Create(serializable, this);
                }

                return Character.DefaultValue;
			}
			public Fleet GetFleet(ItemId<Fleet> id)
			{
				if (_database._fleetMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetFleet(id.Value);
                    if (serializable != null) return Fleet.Create(serializable, this);
                }

                return Fleet.DefaultValue;
			}
			public LootModel GetLoot(ItemId<LootModel> id)
			{
				if (_database._lootMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetLoot(id.Value);
                    if (serializable != null) return LootModel.Create(serializable, this);
                }

                return LootModel.DefaultValue;
			}
			public QuestModel GetQuest(ItemId<QuestModel> id)
			{
				if (_database._questMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetQuest(id.Value);
                    if (serializable != null) return QuestModel.Create(serializable, this);
                }

                return QuestModel.DefaultValue;
			}
			public QuestItem GetQuestItem(ItemId<QuestItem> id)
			{
				if (_database._questItemMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetQuestItem(id.Value);
                    if (serializable != null) return QuestItem.Create(serializable, this);
                }

                return QuestItem.DefaultValue;
			}
			public Ammunition GetAmmunition(ItemId<Ammunition> id)
			{
				if (_database._ammunitionMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetAmmunition(id.Value);
                    if (serializable != null) return Ammunition.Create(serializable, this);
                }

                return Ammunition.DefaultValue;
			}
			public BulletPrefab GetBulletPrefab(ItemId<BulletPrefab> id)
			{
				if (_database._bulletPrefabMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetBulletPrefab(id.Value);
                    if (serializable != null) return BulletPrefab.Create(serializable, this);
                }

                return BulletPrefab.DefaultValue;
			}
			public VisualEffect GetVisualEffect(ItemId<VisualEffect> id)
			{
				if (_database._visualEffectMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetVisualEffect(id.Value);
                    if (serializable != null) return VisualEffect.Create(serializable, this);
                }

                return VisualEffect.DefaultValue;
			}
			public Weapon GetWeapon(ItemId<Weapon> id)
			{
				if (_database._weaponMap.TryGetValue(id.Value, out var item)) return item;
				for (var i = Contents.Count - 1; i >= 0; --i)
                {
                    var serializable = Contents[i].GetWeapon(id.Value);
                    if (serializable != null) return Weapon.Create(serializable, this);
                }

                return Weapon.DefaultValue;
			}


			public void AddAmmunitionObsolete(int id, AmmunitionObsolete item) { _database._ammunitionObsoleteMap.Add(id, item); }
			public void AddComponent(int id, Component item) { _database._componentMap.Add(id, item); }
			public void AddComponentMod(int id, ComponentMod item) { _database._componentModMap.Add(id, item); }
			public void AddComponentStats(int id, ComponentStats item) { _database._componentStatsMap.Add(id, item); }
			public void AddDevice(int id, Device item) { _database._deviceMap.Add(id, item); }
			public void AddDroneBay(int id, DroneBay item) { _database._droneBayMap.Add(id, item); }
			public void AddFaction(int id, Faction item) { _database._factionMap.Add(id, item); }
			public void AddSatellite(int id, Satellite item) { _database._satelliteMap.Add(id, item); }
			public void AddSatelliteBuild(int id, SatelliteBuild item) { _database._satelliteBuildMap.Add(id, item); }
			public void AddShip(int id, Ship item) { _database._shipMap.Add(id, item); }
			public void AddShipBuild(int id, ShipBuild item) { _database._shipBuildMap.Add(id, item); }
			public void AddSkill(int id, Skill item) { _database._skillMap.Add(id, item); }
			public void AddTechnology(int id, Technology item) { _database._technologyMap.Add(id, item); }
			public void AddCharacter(int id, Character item) { _database._characterMap.Add(id, item); }
			public void AddFleet(int id, Fleet item) { _database._fleetMap.Add(id, item); }
			public void AddLoot(int id, LootModel item) { _database._lootMap.Add(id, item); }
			public void AddQuest(int id, QuestModel item) { _database._questMap.Add(id, item); }
			public void AddQuestItem(int id, QuestItem item) { _database._questItemMap.Add(id, item); }
			public void AddAmmunition(int id, Ammunition item) { _database._ammunitionMap.Add(id, item); }
			public void AddBulletPrefab(int id, BulletPrefab item) { _database._bulletPrefabMap.Add(id, item); }
			public void AddVisualEffect(int id, VisualEffect item) { _database._visualEffectMap.Add(id, item); }
			public void AddWeapon(int id, Weapon item) { _database._weaponMap.Add(id, item); }

			private readonly Database _database;
		}
	}
}

