//-------------------------------------------------------------------------------
//                                                                               
//    This code was automatically generated.                                     
//    Changes to this file may cause incorrect behavior and will be lost if      
//    the code is regenerated.                                                   
//                                                                               
//-------------------------------------------------------------------------------

using System.Collections.Generic;
using GameDatabase.Classes;
using GameDatabase.Storage;
using GameDatabase.Types;

namespace GameDatabase
{
	public partial interface IDatabase
	{
		GalaxySettingsData GalaxySettings { get; }
		ShipSettingsData ShipSettings { get; }

		IEnumerable<AmmunitionObsoleteData> AmmunitionObsoleteList { get; }
		IEnumerable<ComponentData> ComponentList { get; }
		IEnumerable<ComponentModData> ComponentModList { get; }
		IEnumerable<ComponentStatsData> ComponentStatsList { get; }
		IEnumerable<DeviceData> DeviceList { get; }
		IEnumerable<DroneBayData> DroneBayList { get; }
		IEnumerable<FactionData> FactionList { get; }
		IEnumerable<SatelliteData> SatelliteList { get; }
		IEnumerable<SatelliteBuildData> SatelliteBuildList { get; }
		IEnumerable<ShipData> ShipList { get; }
		IEnumerable<ShipBuildData> ShipBuildList { get; }
		IEnumerable<TechnologyData> TechnologyList { get; }
		IEnumerable<CharacterData> CharacterList { get; }
		IEnumerable<FleetData> FleetList { get; }
		IEnumerable<LootData> LootList { get; }
		IEnumerable<QuestData> QuestList { get; }
		IEnumerable<QuestItemData> QuestItemList { get; }
		IEnumerable<AmmunitionData> AmmunitionList { get; }
		IEnumerable<BulletPrefabData> BulletPrefabList { get; }
		IEnumerable<VisualEffectData> VisualEffectList { get; }
		IEnumerable<WeaponData> WeaponList { get; }

		AmmunitionObsoleteData GetAmmunitionObsolete(ItemId<AmmunitionObsoleteData> id);
		ComponentData GetComponent(ItemId<ComponentData> id);
		ComponentModData GetComponentMod(ItemId<ComponentModData> id);
		ComponentStatsData GetComponentStats(ItemId<ComponentStatsData> id);
		DeviceData GetDevice(ItemId<DeviceData> id);
		DroneBayData GetDroneBay(ItemId<DroneBayData> id);
		FactionData GetFaction(ItemId<FactionData> id);
		SatelliteData GetSatellite(ItemId<SatelliteData> id);
		SatelliteBuildData GetSatelliteBuild(ItemId<SatelliteBuildData> id);
		ShipData GetShip(ItemId<ShipData> id);
		ShipBuildData GetShipBuild(ItemId<ShipBuildData> id);
		TechnologyData GetTechnology(ItemId<TechnologyData> id);
		CharacterData GetCharacter(ItemId<CharacterData> id);
		FleetData GetFleet(ItemId<FleetData> id);
		LootData GetLoot(ItemId<LootData> id);
		QuestData GetQuest(ItemId<QuestData> id);
		QuestItemData GetQuestItem(ItemId<QuestItemData> id);
		AmmunitionData GetAmmunition(ItemId<AmmunitionData> id);
		BulletPrefabData GetBulletPrefab(ItemId<BulletPrefabData> id);
		VisualEffectData GetVisualEffect(ItemId<VisualEffectData> id);
		WeaponData GetWeapon(ItemId<WeaponData> id);

        Image GetImage(string name);
        AudioClip GetAudioClip(string name);
        string GetLocalization(string language);
	}

    public partial class Database : IDatabase
    {
        partial void OnDataLoaded();

        protected void Load(IDataStorage storage, IJsonSerializer serializer)
        {
            Clear();
            _storage = storage;
            _content = new DatabaseContent(_storage, serializer);

            foreach (var item in _content.AmmunitionObsoleteList)
                GetAmmunitionObsolete(new ItemId<AmmunitionObsoleteData>(item.Id));
            foreach (var item in _content.ComponentList)
                GetComponent(new ItemId<ComponentData>(item.Id));
            foreach (var item in _content.ComponentModList)
                GetComponentMod(new ItemId<ComponentModData>(item.Id));
            foreach (var item in _content.ComponentStatsList)
                GetComponentStats(new ItemId<ComponentStatsData>(item.Id));
            foreach (var item in _content.DeviceList)
                GetDevice(new ItemId<DeviceData>(item.Id));
            foreach (var item in _content.DroneBayList)
                GetDroneBay(new ItemId<DroneBayData>(item.Id));
            foreach (var item in _content.FactionList)
                GetFaction(new ItemId<FactionData>(item.Id));
            foreach (var item in _content.SatelliteList)
                GetSatellite(new ItemId<SatelliteData>(item.Id));
            foreach (var item in _content.SatelliteBuildList)
                GetSatelliteBuild(new ItemId<SatelliteBuildData>(item.Id));
            foreach (var item in _content.ShipList)
                GetShip(new ItemId<ShipData>(item.Id));
            foreach (var item in _content.ShipBuildList)
                GetShipBuild(new ItemId<ShipBuildData>(item.Id));
            foreach (var item in _content.TechnologyList)
                GetTechnology(new ItemId<TechnologyData>(item.Id));
            foreach (var item in _content.CharacterList)
                GetCharacter(new ItemId<CharacterData>(item.Id));
            foreach (var item in _content.FleetList)
                GetFleet(new ItemId<FleetData>(item.Id));
            foreach (var item in _content.LootList)
                GetLoot(new ItemId<LootData>(item.Id));
            foreach (var item in _content.QuestList)
                GetQuest(new ItemId<QuestData>(item.Id));
            foreach (var item in _content.QuestItemList)
                GetQuestItem(new ItemId<QuestItemData>(item.Id));
            foreach (var item in _content.AmmunitionList)
                GetAmmunition(new ItemId<AmmunitionData>(item.Id));
            foreach (var item in _content.BulletPrefabList)
                GetBulletPrefab(new ItemId<BulletPrefabData>(item.Id));
            foreach (var item in _content.VisualEffectList)
                GetVisualEffect(new ItemId<VisualEffectData>(item.Id));
            foreach (var item in _content.WeaponList)
                GetWeapon(new ItemId<WeaponData>(item.Id));

			GalaxySettings = GalaxySettingsData.Create(_content.GalaxySettings, this);
			ShipSettings = ShipSettingsData.Create(_content.ShipSettings, this);

            OnDataLoaded();
        }

		public GalaxySettingsData GalaxySettings { get; private set; }
		public ShipSettingsData ShipSettings { get; private set; }

		public IEnumerable<AmmunitionObsoleteData> AmmunitionObsoleteList => _ammunitionObsoleteMap.Values;
		public IEnumerable<ComponentData> ComponentList => _componentMap.Values;
		public IEnumerable<ComponentModData> ComponentModList => _componentModMap.Values;
		public IEnumerable<ComponentStatsData> ComponentStatsList => _componentStatsMap.Values;
		public IEnumerable<DeviceData> DeviceList => _deviceMap.Values;
		public IEnumerable<DroneBayData> DroneBayList => _droneBayMap.Values;
		public IEnumerable<FactionData> FactionList => _factionMap.Values;
		public IEnumerable<SatelliteData> SatelliteList => _satelliteMap.Values;
		public IEnumerable<SatelliteBuildData> SatelliteBuildList => _satelliteBuildMap.Values;
		public IEnumerable<ShipData> ShipList => _shipMap.Values;
		public IEnumerable<ShipBuildData> ShipBuildList => _shipBuildMap.Values;
		public IEnumerable<TechnologyData> TechnologyList => _technologyMap.Values;
		public IEnumerable<CharacterData> CharacterList => _characterMap.Values;
		public IEnumerable<FleetData> FleetList => _fleetMap.Values;
		public IEnumerable<LootData> LootList => _lootMap.Values;
		public IEnumerable<QuestData> QuestList => _questMap.Values;
		public IEnumerable<QuestItemData> QuestItemList => _questItemMap.Values;
		public IEnumerable<AmmunitionData> AmmunitionList => _ammunitionMap.Values;
		public IEnumerable<BulletPrefabData> BulletPrefabList => _bulletPrefabMap.Values;
		public IEnumerable<VisualEffectData> VisualEffectList => _visualEffectMap.Values;
		public IEnumerable<WeaponData> WeaponList => _weaponMap.Values;

		public AmmunitionObsoleteData GetAmmunitionObsolete(ItemId<AmmunitionObsoleteData> id) 
		{
            if (_ammunitionObsoleteMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetAmmunitionObsolete(id.Value);
            return serializable == null ? null : AmmunitionObsoleteData.Create(serializable, this);
		}
		public ComponentData GetComponent(ItemId<ComponentData> id) 
		{
            if (_componentMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetComponent(id.Value);
            return serializable == null ? null : ComponentData.Create(serializable, this);
		}
		public ComponentModData GetComponentMod(ItemId<ComponentModData> id) 
		{
            if (_componentModMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetComponentMod(id.Value);
            return serializable == null ? null : ComponentModData.Create(serializable, this);
		}
		public ComponentStatsData GetComponentStats(ItemId<ComponentStatsData> id) 
		{
            if (_componentStatsMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetComponentStats(id.Value);
            return serializable == null ? null : ComponentStatsData.Create(serializable, this);
		}
		public DeviceData GetDevice(ItemId<DeviceData> id) 
		{
            if (_deviceMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetDevice(id.Value);
            return serializable == null ? null : DeviceData.Create(serializable, this);
		}
		public DroneBayData GetDroneBay(ItemId<DroneBayData> id) 
		{
            if (_droneBayMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetDroneBay(id.Value);
            return serializable == null ? null : DroneBayData.Create(serializable, this);
		}
		public FactionData GetFaction(ItemId<FactionData> id) 
		{
            if (_factionMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetFaction(id.Value);
            return serializable == null ? null : FactionData.Create(serializable, this);
		}
		public SatelliteData GetSatellite(ItemId<SatelliteData> id) 
		{
            if (_satelliteMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetSatellite(id.Value);
            return serializable == null ? null : SatelliteData.Create(serializable, this);
		}
		public SatelliteBuildData GetSatelliteBuild(ItemId<SatelliteBuildData> id) 
		{
            if (_satelliteBuildMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetSatelliteBuild(id.Value);
            return serializable == null ? null : SatelliteBuildData.Create(serializable, this);
		}
		public ShipData GetShip(ItemId<ShipData> id) 
		{
            if (_shipMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetShip(id.Value);
            return serializable == null ? null : ShipData.Create(serializable, this);
		}
		public ShipBuildData GetShipBuild(ItemId<ShipBuildData> id) 
		{
            if (_shipBuildMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetShipBuild(id.Value);
            return serializable == null ? null : ShipBuildData.Create(serializable, this);
		}
		public TechnologyData GetTechnology(ItemId<TechnologyData> id) 
		{
            if (_technologyMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetTechnology(id.Value);
            return serializable == null ? null : TechnologyData.Create(serializable, this);
		}
		public CharacterData GetCharacter(ItemId<CharacterData> id) 
		{
            if (_characterMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetCharacter(id.Value);
            return serializable == null ? null : CharacterData.Create(serializable, this);
		}
		public FleetData GetFleet(ItemId<FleetData> id) 
		{
            if (_fleetMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetFleet(id.Value);
            return serializable == null ? null : FleetData.Create(serializable, this);
		}
		public LootData GetLoot(ItemId<LootData> id) 
		{
            if (_lootMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetLoot(id.Value);
            return serializable == null ? null : LootData.Create(serializable, this);
		}
		public QuestData GetQuest(ItemId<QuestData> id) 
		{
            if (_questMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetQuest(id.Value);
            return serializable == null ? null : QuestData.Create(serializable, this);
		}
		public QuestItemData GetQuestItem(ItemId<QuestItemData> id) 
		{
            if (_questItemMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetQuestItem(id.Value);
            return serializable == null ? null : QuestItemData.Create(serializable, this);
		}
		public AmmunitionData GetAmmunition(ItemId<AmmunitionData> id) 
		{
            if (_ammunitionMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetAmmunition(id.Value);
            return serializable == null ? null : AmmunitionData.Create(serializable, this);
		}
		public BulletPrefabData GetBulletPrefab(ItemId<BulletPrefabData> id) 
		{
            if (_bulletPrefabMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetBulletPrefab(id.Value);
            return serializable == null ? null : BulletPrefabData.Create(serializable, this);
		}
		public VisualEffectData GetVisualEffect(ItemId<VisualEffectData> id) 
		{
            if (_visualEffectMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetVisualEffect(id.Value);
            return serializable == null ? null : VisualEffectData.Create(serializable, this);
		}
		public WeaponData GetWeapon(ItemId<WeaponData> id) 
		{
            if (_weaponMap.TryGetValue(id.Value, out var item)) return item;
            var serializable = _content?.GetWeapon(id.Value);
            return serializable == null ? null : WeaponData.Create(serializable, this);
		}

		public void AddAmmunitionObsolete(int id, AmmunitionObsoleteData item) { _ammunitionObsoleteMap.Add(id, item); }
		public void AddComponent(int id, ComponentData item) { _componentMap.Add(id, item); }
		public void AddComponentMod(int id, ComponentModData item) { _componentModMap.Add(id, item); }
		public void AddComponentStats(int id, ComponentStatsData item) { _componentStatsMap.Add(id, item); }
		public void AddDevice(int id, DeviceData item) { _deviceMap.Add(id, item); }
		public void AddDroneBay(int id, DroneBayData item) { _droneBayMap.Add(id, item); }
		public void AddFaction(int id, FactionData item) { _factionMap.Add(id, item); }
		public void AddSatellite(int id, SatelliteData item) { _satelliteMap.Add(id, item); }
		public void AddSatelliteBuild(int id, SatelliteBuildData item) { _satelliteBuildMap.Add(id, item); }
		public void AddShip(int id, ShipData item) { _shipMap.Add(id, item); }
		public void AddShipBuild(int id, ShipBuildData item) { _shipBuildMap.Add(id, item); }
		public void AddTechnology(int id, TechnologyData item) { _technologyMap.Add(id, item); }
		public void AddCharacter(int id, CharacterData item) { _characterMap.Add(id, item); }
		public void AddFleet(int id, FleetData item) { _fleetMap.Add(id, item); }
		public void AddLoot(int id, LootData item) { _lootMap.Add(id, item); }
		public void AddQuest(int id, QuestData item) { _questMap.Add(id, item); }
		public void AddQuestItem(int id, QuestItemData item) { _questItemMap.Add(id, item); }
		public void AddAmmunition(int id, AmmunitionData item) { _ammunitionMap.Add(id, item); }
		public void AddBulletPrefab(int id, BulletPrefabData item) { _bulletPrefabMap.Add(id, item); }
		public void AddVisualEffect(int id, VisualEffectData item) { _visualEffectMap.Add(id, item); }
		public void AddWeapon(int id, WeaponData item) { _weaponMap.Add(id, item); }

        public Image GetImage(string name) { return _content?.GetImage(name) ?? Image.Empty; }
        public AudioClip GetAudioClip(string name) { return _content?.GetAudioClip(name) ?? AudioClip.Empty; }
        public string GetLocalization(string language) { return _content?.GetLocalization(language); }

        private void Clear()
        {
            _content = null;
            _storage = null;

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

			GalaxySettings = null;
			ShipSettings = null;
        }

		private readonly Dictionary<int, AmmunitionObsoleteData> _ammunitionObsoleteMap = new Dictionary<int, AmmunitionObsoleteData>();
		private readonly Dictionary<int, ComponentData> _componentMap = new Dictionary<int, ComponentData>();
		private readonly Dictionary<int, ComponentModData> _componentModMap = new Dictionary<int, ComponentModData>();
		private readonly Dictionary<int, ComponentStatsData> _componentStatsMap = new Dictionary<int, ComponentStatsData>();
		private readonly Dictionary<int, DeviceData> _deviceMap = new Dictionary<int, DeviceData>();
		private readonly Dictionary<int, DroneBayData> _droneBayMap = new Dictionary<int, DroneBayData>();
		private readonly Dictionary<int, FactionData> _factionMap = new Dictionary<int, FactionData>();
		private readonly Dictionary<int, SatelliteData> _satelliteMap = new Dictionary<int, SatelliteData>();
		private readonly Dictionary<int, SatelliteBuildData> _satelliteBuildMap = new Dictionary<int, SatelliteBuildData>();
		private readonly Dictionary<int, ShipData> _shipMap = new Dictionary<int, ShipData>();
		private readonly Dictionary<int, ShipBuildData> _shipBuildMap = new Dictionary<int, ShipBuildData>();
		private readonly Dictionary<int, TechnologyData> _technologyMap = new Dictionary<int, TechnologyData>();
		private readonly Dictionary<int, CharacterData> _characterMap = new Dictionary<int, CharacterData>();
		private readonly Dictionary<int, FleetData> _fleetMap = new Dictionary<int, FleetData>();
		private readonly Dictionary<int, LootData> _lootMap = new Dictionary<int, LootData>();
		private readonly Dictionary<int, QuestData> _questMap = new Dictionary<int, QuestData>();
		private readonly Dictionary<int, QuestItemData> _questItemMap = new Dictionary<int, QuestItemData>();
		private readonly Dictionary<int, AmmunitionData> _ammunitionMap = new Dictionary<int, AmmunitionData>();
		private readonly Dictionary<int, BulletPrefabData> _bulletPrefabMap = new Dictionary<int, BulletPrefabData>();
		private readonly Dictionary<int, VisualEffectData> _visualEffectMap = new Dictionary<int, VisualEffectData>();
		private readonly Dictionary<int, WeaponData> _weaponMap = new Dictionary<int, WeaponData>();

        private DatabaseContent _content;
        private IDataStorage _storage;
	}
}

