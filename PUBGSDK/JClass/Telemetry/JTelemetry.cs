// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using PUBGSDK.JClass.Telemetry;
//
//    var jTelemetry = JTelemetry.FromJson(jsonString);

using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PUBGSDK.JClass.Telemetry
{
    public partial class JTelemetry
    {
        [JsonProperty("MatchId", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchId { get; set; }

        [JsonProperty("PingQuality", NullValueHandling = NullValueHandling.Ignore)]
        public string PingQuality { get; set; }

        [JsonProperty("_V")] public long V { get; set; }

        [JsonProperty("_D")] public DateTimeOffset D { get; set; }

        [JsonProperty("_T")] public T T { get; set; }

        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Result { get; set; }

        [JsonProperty("errorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorMessage? ErrorMessage { get; set; }

        [JsonProperty("accountId", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public Common Common { get; set; }

        [JsonProperty("character", NullValueHandling = NullValueHandling.Ignore)]
        public Attacker Character { get; set; }

        [JsonProperty("attackId", NullValueHandling = NullValueHandling.Ignore)]
        public long? AttackId { get; set; }

        [JsonProperty("attacker", NullValueHandling = NullValueHandling.Ignore)]
        public Attacker Attacker { get; set; }

        [JsonProperty("attackType", NullValueHandling = NullValueHandling.Ignore)]
        public AttackType? AttackType { get; set; }

        [JsonProperty("weapon", NullValueHandling = NullValueHandling.Ignore)]
        public ChildItem Weapon { get; set; }

        [JsonProperty("vehicle", NullValueHandling = NullValueHandling.Ignore)]
        public Vehicle Vehicle { get; set; }

        [JsonProperty("elapsedTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? ElapsedTime { get; set; }

        [JsonProperty("numAlivePlayers", NullValueHandling = NullValueHandling.Ignore)]
        public long? NumAlivePlayers { get; set; }

        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public ChildItem Item { get; set; }

        [JsonProperty("mapName", NullValueHandling = NullValueHandling.Ignore)]
        public string MapName { get; set; }

        [JsonProperty("weatherId", NullValueHandling = NullValueHandling.Ignore)]
        public string WeatherId { get; set; }

        [JsonProperty("characters", NullValueHandling = NullValueHandling.Ignore)]
        public Character[] Characters { get; set; }

        [JsonProperty("gameState", NullValueHandling = NullValueHandling.Ignore)]
        public GameState GameState { get; set; }

        [JsonProperty("victim", NullValueHandling = NullValueHandling.Ignore)]
        public Attacker Victim { get; set; }

        [JsonProperty("damageTypeCategory", NullValueHandling = NullValueHandling.Ignore)]
        public DamageTypeCategory? DamageTypeCategory { get; set; }

        [JsonProperty("damageReason", NullValueHandling = NullValueHandling.Ignore)]
        public DamageReason? DamageReason { get; set; }

        [JsonProperty("damage", NullValueHandling = NullValueHandling.Ignore)]
        public double? Damage { get; set; }

        [JsonProperty("damageCauserName", NullValueHandling = NullValueHandling.Ignore)]
        public DamageCauserName? DamageCauserName { get; set; }

        [JsonProperty("parentItem", NullValueHandling = NullValueHandling.Ignore)]
        public ChildItem ParentItem { get; set; }

        [JsonProperty("childItem", NullValueHandling = NullValueHandling.Ignore)]
        public ChildItem ChildItem { get; set; }

        [JsonProperty("killer", NullValueHandling = NullValueHandling.Ignore)]
        public Attacker Killer { get; set; }

        [JsonProperty("distance", NullValueHandling = NullValueHandling.Ignore)]
        public double? Distance { get; set; }

        [JsonProperty("itemPackage", NullValueHandling = NullValueHandling.Ignore)]
        public ItemPackage ItemPackage { get; set; }
    }

    public class Attacker
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("teamId")] public long TeamId { get; set; }

        [JsonProperty("health")] public double Health { get; set; }

        [JsonProperty("location")] public AttackerLocation Location { get; set; }

        [JsonProperty("ranking")] public long Ranking { get; set; }

        [JsonProperty("accountId")] public string AccountId { get; set; }
    }

    public class AttackerLocation
    {
        [JsonProperty("x")] public double X { get; set; }

        [JsonProperty("y")] public double Y { get; set; }

        [JsonProperty("z")] public double Z { get; set; }
    }

    public class Character
    {
        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("teamId")] public long TeamId { get; set; }

        [JsonProperty("health")] public long Health { get; set; }

        [JsonProperty("location")] public PurpleLocation Location { get; set; }

        [JsonProperty("ranking")] public long Ranking { get; set; }

        [JsonProperty("accountId")] public string AccountId { get; set; }
    }

    public class PurpleLocation
    {
        [JsonProperty("x")] public long X { get; set; }

        [JsonProperty("y")] public long Y { get; set; }

        [JsonProperty("z")] public long Z { get; set; }
    }

    public class ChildItem
    {
        [JsonProperty("itemId")] public ItemId ItemId { get; set; }

        [JsonProperty("stackCount")] public long StackCount { get; set; }

        [JsonProperty("category")] public Category Category { get; set; }

        [JsonProperty("subCategory")] public SubCategory SubCategory { get; set; }

        [JsonProperty("attachedItems")] public AttachedItem[] AttachedItems { get; set; }
    }

    public class Common
    {
        [JsonProperty("matchId")] public string MatchId { get; set; }

        [JsonProperty("mapName")] public MapName MapName { get; set; }

        [JsonProperty("isGame")] public double IsGame { get; set; }
    }

    public class GameState
    {
        [JsonProperty("elapsedTime")] public long ElapsedTime { get; set; }

        [JsonProperty("numAliveTeams")] public long NumAliveTeams { get; set; }

        [JsonProperty("numJoinPlayers")] public long NumJoinPlayers { get; set; }

        [JsonProperty("numStartPlayers")] public long NumStartPlayers { get; set; }

        [JsonProperty("numAlivePlayers")] public long NumAlivePlayers { get; set; }

        [JsonProperty("safetyZonePosition")] public Position SafetyZonePosition { get; set; }

        [JsonProperty("safetyZoneRadius")] public double SafetyZoneRadius { get; set; }

        [JsonProperty("poisonGasWarningPosition")]
        public Position PoisonGasWarningPosition { get; set; }

        [JsonProperty("poisonGasWarningRadius")]
        public double PoisonGasWarningRadius { get; set; }

        [JsonProperty("redZonePosition")] public Position RedZonePosition { get; set; }

        [JsonProperty("redZoneRadius")] public long RedZoneRadius { get; set; }
    }

    public class Position
    {
        [JsonProperty("x")] public double X { get; set; }

        [JsonProperty("y")] public double Y { get; set; }

        [JsonProperty("z")] public long Z { get; set; }
    }

    public class ItemPackage
    {
        [JsonProperty("itemPackageId")] public ItemPackageId ItemPackageId { get; set; }

        [JsonProperty("location")] public AttackerLocation Location { get; set; }

        [JsonProperty("items")] public ChildItem[] Items { get; set; }
    }

    public class Vehicle
    {
        [JsonProperty("vehicleType")] public VehicleType VehicleType { get; set; }

        [JsonProperty("vehicleId")] public VehicleId VehicleId { get; set; }

        [JsonProperty("healthPercent")] public double HealthPercent { get; set; }

        [JsonProperty("feulPercent")] public double FeulPercent { get; set; }
    }

    public enum AttackType
    {
        RedZone,
        Weapon
    }

    public enum AttachedItem
    {
        ItemAttachWeaponLowerAngledForeGripC,
        ItemAttachWeaponLowerForegripC,
        ItemAttachWeaponMagazineExtendedLargeC,
        ItemAttachWeaponMagazineExtendedMediumC,
        ItemAttachWeaponMagazineExtendedQuickDrawLargeC,
        ItemAttachWeaponMagazineExtendedQuickDrawMediumC,
        ItemAttachWeaponMagazineExtendedQuickDrawSmallC,
        ItemAttachWeaponMagazineExtendedQuickDrawSniperRifleC,
        ItemAttachWeaponMagazineExtendedSmallC,
        ItemAttachWeaponMagazineExtendedSniperRifleC,
        ItemAttachWeaponMagazineQuickDrawLargeC,
        ItemAttachWeaponMagazineQuickDrawMediumC,
        ItemAttachWeaponMagazineQuickDrawSmallC,
        ItemAttachWeaponMuzzleChokeC,
        ItemAttachWeaponMuzzleCompensatorLargeC,
        ItemAttachWeaponMuzzleCompensatorMediumC,
        ItemAttachWeaponMuzzleCompensatorSniperRifleC,
        ItemAttachWeaponMuzzleFlashHiderLargeC,
        ItemAttachWeaponMuzzleFlashHiderMediumC,
        ItemAttachWeaponMuzzleFlashHiderSniperRifleC,
        ItemAttachWeaponMuzzleSuppressorLargeC,
        ItemAttachWeaponMuzzleSuppressorMediumC,
        ItemAttachWeaponMuzzleSuppressorSmallC,
        ItemAttachWeaponMuzzleSuppressorSniperRifleC,
        ItemAttachWeaponStockArCompositeC,
        ItemAttachWeaponStockShotgunBulletLoopsC,
        ItemAttachWeaponStockSniperRifleBulletLoopsC,
        ItemAttachWeaponStockSniperRifleCheekPadC,
        ItemAttachWeaponUpperAcog01_C,
        ItemAttachWeaponUpperAimpointC,
        ItemAttachWeaponUpperCqbssC,
        ItemAttachWeaponUpperDotSight01_C,
        ItemAttachWeaponUpperHolosightC,
        ItemAttachWeaponUpperPm201_C
    }

    public enum Category
    {
        Ammunition,
        Attachment,
        Empty,
        Equipment,
        Use,
        Weapon
    }

    public enum ItemId
    {
        Empty,
        ItemAmmo12GuageC,
        ItemAmmo300MagnumC,
        ItemAmmo45AcpC,
        ItemAmmo556MmC,
        ItemAmmo762MmC,
        ItemAmmo9MmC,
        ItemAmmoBoltC,
        ItemAmmoFlareC,
        ItemArmorC01_Lv3C,
        ItemArmorD01_Lv2C,
        ItemArmorE01_Lv1C,
        ItemAttachWeaponLowerAngledForeGripC,
        ItemAttachWeaponLowerForegripC,
        ItemAttachWeaponLowerQuickDrawLargeCrossbowC,
        ItemAttachWeaponMagazineExtendedLargeC,
        ItemAttachWeaponMagazineExtendedMediumC,
        ItemAttachWeaponMagazineExtendedQuickDrawLargeC,
        ItemAttachWeaponMagazineExtendedQuickDrawMediumC,
        ItemAttachWeaponMagazineExtendedQuickDrawSmallC,
        ItemAttachWeaponMagazineExtendedQuickDrawSniperRifleC,
        ItemAttachWeaponMagazineExtendedSmallC,
        ItemAttachWeaponMagazineExtendedSniperRifleC,
        ItemAttachWeaponMagazineQuickDrawLargeC,
        ItemAttachWeaponMagazineQuickDrawMediumC,
        ItemAttachWeaponMagazineQuickDrawSmallC,
        ItemAttachWeaponMagazineQuickDrawSniperRifleC,
        ItemAttachWeaponMuzzleChokeC,
        ItemAttachWeaponMuzzleCompensatorLargeC,
        ItemAttachWeaponMuzzleCompensatorMediumC,
        ItemAttachWeaponMuzzleCompensatorSniperRifleC,
        ItemAttachWeaponMuzzleFlashHiderLargeC,
        ItemAttachWeaponMuzzleFlashHiderMediumC,
        ItemAttachWeaponMuzzleFlashHiderSniperRifleC,
        ItemAttachWeaponMuzzleSuppressorLargeC,
        ItemAttachWeaponMuzzleSuppressorMediumC,
        ItemAttachWeaponMuzzleSuppressorSmallC,
        ItemAttachWeaponMuzzleSuppressorSniperRifleC,
        ItemAttachWeaponStockArCompositeC,
        ItemAttachWeaponStockShotgunBulletLoopsC,
        ItemAttachWeaponStockSniperRifleBulletLoopsC,
        ItemAttachWeaponStockSniperRifleCheekPadC,
        ItemAttachWeaponStockUziC,
        ItemAttachWeaponUpperAcog01_C,
        ItemAttachWeaponUpperAimpointC,
        ItemAttachWeaponUpperCqbssC,
        ItemAttachWeaponUpperDotSight01_C,
        ItemAttachWeaponUpperHolosightC,
        ItemAttachWeaponUpperPm201_C,
        ItemBackB01_StartParachutePackC,
        ItemBackC02_Lv3C,
        ItemBackE01_Lv1C,
        ItemBackE02_Lv1C,
        ItemBackF01_Lv2C,
        ItemBackF02_Lv2C,
        ItemBoostEnergyDrinkC,
        ItemBoostPainKillerC,
        ItemHeadE01_Lv1C,
        ItemHeadE02_Lv1C,
        ItemHeadF01_Lv2C,
        ItemHeadF02_Lv2C,
        ItemHeadG01_Lv3C,
        ItemHealBandageC,
        ItemHealFirstAidC,
        ItemHealMedKitC,
        ItemJerryCanC,
        ItemWeaponAk47C,
        ItemWeaponAugC,
        ItemWeaponAwmC,
        ItemWeaponBerreta686C,
        ItemWeaponCowbarC,
        ItemWeaponCrossbowC,
        ItemWeaponFlareGunC,
        ItemWeaponFlashBangC,
        ItemWeaponG18C,
        ItemWeaponGrenadeC,
        ItemWeaponGrozaC,
        ItemWeaponHk416C,
        ItemWeaponKar98KC,
        ItemWeaponM16A4C,
        ItemWeaponM1911C,
        ItemWeaponM249C,
        ItemWeaponM24C,
        ItemWeaponM9C,
        ItemWeaponMacheteC,
        ItemWeaponMini14C,
        ItemWeaponMk14C,
        ItemWeaponMolotovC,
        ItemWeaponPanC,
        ItemWeaponRhinoC,
        ItemWeaponSaiga12C,
        ItemWeaponSawnoffC,
        ItemWeaponScarLC,
        ItemWeaponSickleC,
        ItemWeaponSksC,
        ItemWeaponSmokeBombC,
        ItemWeaponThompsonC,
        ItemWeaponUmpC,
        ItemWeaponUziC,
        ItemWeaponVectorC,
        ItemWeaponVssC,
        ItemWeaponWin1894C,
        ItemWeaponWinchesterC
    }

    public enum SubCategory
    {
        Backpack,
        Boost,
        Empty,
        Fuel,
        Handgun,
        Headgear,
        Heal,
        Main,
        Melee,
        None,
        Throwable,
        Vest
    }

    public enum MapName
    {
        DesertMain,
        Empty
    }

    public enum DamageCauserName
    {
        BattleRoyaleModeControllerDesertC,
        BpMotorbike04_DesertC,
        BpPickupTruckA01_C,
        BpPickupTruckA02_C,
        BpPickupTruckA03_C,
        BpPickupTruckB01_C,
        BpPickupTruckB02_C,
        BpVanA02_C,
        BuffDecreaseBreathInApneaC,
        BuggyA04_C,
        PlayerFemaleAC,
        PlayerMaleAC,
        ProjGrenadeC,
        RedZoneBombC,
        WeapAk47C,
        WeapAugC,
        WeapAwmC,
        WeapBerreta686C,
        WeapG18C,
        WeapHk416C,
        WeapKar98KC,
        WeapM16A4C,
        WeapM1911C,
        WeapM249C,
        WeapM24C,
        WeapM9C,
        WeapMk14C,
        WeapSaiga12C,
        WeapSawnoffC,
        WeapScarLC,
        WeapSksC,
        WeapUmpC,
        WeapUziC,
        WeapVectorC,
        WeapWin94C,
        WeapWinchesterC
    }

    public enum DamageReason
    {
        ArmShot,
        HeadShot,
        LegShot,
        NonSpecific,
        None,
        PelvisShot,
        TorsoShot
    }

    public enum DamageTypeCategory
    {
        DamageBlueZone,
        DamageDrown,
        DamageExplosionGrenade,
        DamageExplosionRedZone,
        DamageGroggy,
        DamageGun,
        DamageInstantFall,
        DamageMelee,
        DamageVehicleCrashHit,
        DamageVehicleHit,
        Empty
    }

    public enum ErrorMessage
    {
        Empty
    }

    public enum ItemPackageId
    {
        CarapackageFlareGunC,
        CarapackageRedBoxC
    }

    public enum T
    {
        LogCarePackageLand,
        LogCarePackageSpawn,
        LogGameStatePeriodic,
        LogItemAttach,
        LogItemDetach,
        LogItemDrop,
        LogItemEquip,
        LogItemPickup,
        LogItemUnequip,
        LogItemUse,
        LogMatchDefinition,
        LogMatchEnd,
        LogMatchStart,
        LogPlayerAttack,
        LogPlayerCreate,
        LogPlayerKill,
        LogPlayerLogin,
        LogPlayerLogout,
        LogPlayerPosition,
        LogPlayerTakeDamage,
        LogVehicleDestroy,
        LogVehicleLeave,
        LogVehicleRide
    }

    public enum VehicleId
    {
        BpMotorbike04_DesertC,
        BpMotorbike04_SideCarDesertC,
        BpPickupTruckA01_C,
        BpPickupTruckA02_C,
        BpPickupTruckA03_C,
        BpPickupTruckB01_C,
        BpPickupTruckB02_C,
        BpPickupTruckB03_C,
        BpVanA01_C,
        BpVanA02_C,
        BpVanA03_C,
        BuggyA04_C,
        BuggyA05_C,
        DummyTransportAircraftC,
        Empty,
        ParachutePlayerC
    }

    public enum VehicleType
    {
        Empty,
        Parachute,
        TransportAircraft,
        WheeledVehicle
    }

    public partial class JTelemetry
    {
        public static JTelemetry[] FromJson(string json)
        {
            return JsonConvert.DeserializeObject<JTelemetry[]>(json, Converter.Settings);
        }
    }

    internal static class AttackTypeExtensions
    {
        public static AttackType? ValueForString(string str)
        {
            switch (str)
            {
                case "RedZone": return AttackType.RedZone;
                case "Weapon": return AttackType.Weapon;
                default: return null;
            }
        }

        public static AttackType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this AttackType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case AttackType.RedZone:
                    serializer.Serialize(writer, "RedZone");
                    break;
                case AttackType.Weapon:
                    serializer.Serialize(writer, "Weapon");
                    break;
            }
        }
    }

    internal static class AccountIdExtensions
    {
        public static string ValueForString(string str)
        {
            return str;
        }

        public static string ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            return maybeValue;
        }

        public static void WriteJson(this string value, JsonWriter writer, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }

    internal static class NameExtensions
    {
        public static string ValueForString(string str)
        {
            return str;
        }

        public static string ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            return maybeValue;
        }

        public static void WriteJson(this string value, JsonWriter writer, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }

    internal static class AttachedItemExtensions
    {
        public static AttachedItem? ValueForString(string str)
        {
            switch (str)
            {
                case "Item_Attach_Weapon_Lower_AngledForeGrip_C":
                    return AttachedItem.ItemAttachWeaponLowerAngledForeGripC;
                case "Item_Attach_Weapon_Lower_Foregrip_C": return AttachedItem.ItemAttachWeaponLowerForegripC;
                case "Item_Attach_Weapon_Magazine_Extended_Large_C":
                    return AttachedItem.ItemAttachWeaponMagazineExtendedLargeC;
                case "Item_Attach_Weapon_Magazine_Extended_Medium_C":
                    return AttachedItem.ItemAttachWeaponMagazineExtendedMediumC;
                case "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Large_C":
                    return AttachedItem.ItemAttachWeaponMagazineExtendedQuickDrawLargeC;
                case "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Medium_C":
                    return AttachedItem.ItemAttachWeaponMagazineExtendedQuickDrawMediumC;
                case "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Small_C":
                    return AttachedItem.ItemAttachWeaponMagazineExtendedQuickDrawSmallC;
                case "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_SniperRifle_C":
                    return AttachedItem.ItemAttachWeaponMagazineExtendedQuickDrawSniperRifleC;
                case "Item_Attach_Weapon_Magazine_Extended_Small_C":
                    return AttachedItem.ItemAttachWeaponMagazineExtendedSmallC;
                case "Item_Attach_Weapon_Magazine_Extended_SniperRifle_C":
                    return AttachedItem.ItemAttachWeaponMagazineExtendedSniperRifleC;
                case "Item_Attach_Weapon_Magazine_QuickDraw_Large_C":
                    return AttachedItem.ItemAttachWeaponMagazineQuickDrawLargeC;
                case "Item_Attach_Weapon_Magazine_QuickDraw_Medium_C":
                    return AttachedItem.ItemAttachWeaponMagazineQuickDrawMediumC;
                case "Item_Attach_Weapon_Magazine_QuickDraw_Small_C":
                    return AttachedItem.ItemAttachWeaponMagazineQuickDrawSmallC;
                case "Item_Attach_Weapon_Muzzle_Choke_C": return AttachedItem.ItemAttachWeaponMuzzleChokeC;
                case "Item_Attach_Weapon_Muzzle_Compensator_Large_C":
                    return AttachedItem.ItemAttachWeaponMuzzleCompensatorLargeC;
                case "Item_Attach_Weapon_Muzzle_Compensator_Medium_C":
                    return AttachedItem.ItemAttachWeaponMuzzleCompensatorMediumC;
                case "Item_Attach_Weapon_Muzzle_Compensator_SniperRifle_C":
                    return AttachedItem.ItemAttachWeaponMuzzleCompensatorSniperRifleC;
                case "Item_Attach_Weapon_Muzzle_FlashHider_Large_C":
                    return AttachedItem.ItemAttachWeaponMuzzleFlashHiderLargeC;
                case "Item_Attach_Weapon_Muzzle_FlashHider_Medium_C":
                    return AttachedItem.ItemAttachWeaponMuzzleFlashHiderMediumC;
                case "Item_Attach_Weapon_Muzzle_FlashHider_SniperRifle_C":
                    return AttachedItem.ItemAttachWeaponMuzzleFlashHiderSniperRifleC;
                case "Item_Attach_Weapon_Muzzle_Suppressor_Large_C":
                    return AttachedItem.ItemAttachWeaponMuzzleSuppressorLargeC;
                case "Item_Attach_Weapon_Muzzle_Suppressor_Medium_C":
                    return AttachedItem.ItemAttachWeaponMuzzleSuppressorMediumC;
                case "Item_Attach_Weapon_Muzzle_Suppressor_Small_C":
                    return AttachedItem.ItemAttachWeaponMuzzleSuppressorSmallC;
                case "Item_Attach_Weapon_Muzzle_Suppressor_SniperRifle_C":
                    return AttachedItem.ItemAttachWeaponMuzzleSuppressorSniperRifleC;
                case "Item_Attach_Weapon_Stock_AR_Composite_C": return AttachedItem.ItemAttachWeaponStockArCompositeC;
                case "Item_Attach_Weapon_Stock_Shotgun_BulletLoops_C":
                    return AttachedItem.ItemAttachWeaponStockShotgunBulletLoopsC;
                case "Item_Attach_Weapon_Stock_SniperRifle_BulletLoops_C":
                    return AttachedItem.ItemAttachWeaponStockSniperRifleBulletLoopsC;
                case "Item_Attach_Weapon_Stock_SniperRifle_CheekPad_C":
                    return AttachedItem.ItemAttachWeaponStockSniperRifleCheekPadC;
                case "Item_Attach_Weapon_Upper_ACOG_01_C": return AttachedItem.ItemAttachWeaponUpperAcog01_C;
                case "Item_Attach_Weapon_Upper_Aimpoint_C": return AttachedItem.ItemAttachWeaponUpperAimpointC;
                case "Item_Attach_Weapon_Upper_CQBSS_C": return AttachedItem.ItemAttachWeaponUpperCqbssC;
                case "Item_Attach_Weapon_Upper_DotSight_01_C": return AttachedItem.ItemAttachWeaponUpperDotSight01_C;
                case "Item_Attach_Weapon_Upper_Holosight_C": return AttachedItem.ItemAttachWeaponUpperHolosightC;
                case "Item_Attach_Weapon_Upper_PM2_01_C": return AttachedItem.ItemAttachWeaponUpperPm201_C;
                default: return null;
            }
        }

        public static AttachedItem ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this AttachedItem value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case AttachedItem.ItemAttachWeaponLowerAngledForeGripC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Lower_AngledForeGrip_C");
                    break;
                case AttachedItem.ItemAttachWeaponLowerForegripC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Lower_Foregrip_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineExtendedLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_Extended_Large_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineExtendedMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_Extended_Medium_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineExtendedQuickDrawLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Large_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineExtendedQuickDrawMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Medium_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineExtendedQuickDrawSmallC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Small_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineExtendedQuickDrawSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_SniperRifle_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineExtendedSmallC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_Extended_Small_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineExtendedSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_Extended_SniperRifle_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineQuickDrawLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_QuickDraw_Large_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineQuickDrawMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_QuickDraw_Medium_C");
                    break;
                case AttachedItem.ItemAttachWeaponMagazineQuickDrawSmallC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_QuickDraw_Small_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleChokeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Choke_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleCompensatorLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Compensator_Large_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleCompensatorMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Compensator_Medium_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleCompensatorSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Compensator_SniperRifle_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleFlashHiderLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_FlashHider_Large_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleFlashHiderMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_FlashHider_Medium_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleFlashHiderSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_FlashHider_SniperRifle_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleSuppressorLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Suppressor_Large_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleSuppressorMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Suppressor_Medium_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleSuppressorSmallC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Suppressor_Small_C");
                    break;
                case AttachedItem.ItemAttachWeaponMuzzleSuppressorSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Suppressor_SniperRifle_C");
                    break;
                case AttachedItem.ItemAttachWeaponStockArCompositeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_AR_Composite_C");
                    break;
                case AttachedItem.ItemAttachWeaponStockShotgunBulletLoopsC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_Shotgun_BulletLoops_C");
                    break;
                case AttachedItem.ItemAttachWeaponStockSniperRifleBulletLoopsC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_SniperRifle_BulletLoops_C");
                    break;
                case AttachedItem.ItemAttachWeaponStockSniperRifleCheekPadC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_SniperRifle_CheekPad_C");
                    break;
                case AttachedItem.ItemAttachWeaponUpperAcog01_C:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_ACOG_01_C");
                    break;
                case AttachedItem.ItemAttachWeaponUpperAimpointC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_Aimpoint_C");
                    break;
                case AttachedItem.ItemAttachWeaponUpperCqbssC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_CQBSS_C");
                    break;
                case AttachedItem.ItemAttachWeaponUpperDotSight01_C:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_DotSight_01_C");
                    break;
                case AttachedItem.ItemAttachWeaponUpperHolosightC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_Holosight_C");
                    break;
                case AttachedItem.ItemAttachWeaponUpperPm201_C:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_PM2_01_C");
                    break;
            }
        }
    }

    internal static class CategoryExtensions
    {
        public static Category? ValueForString(string str)
        {
            switch (str)
            {
                case "Ammunition": return Category.Ammunition;
                case "Attachment": return Category.Attachment;
                case "": return Category.Empty;
                case "Equipment": return Category.Equipment;
                case "Use": return Category.Use;
                case "Weapon": return Category.Weapon;
                default: return null;
            }
        }

        public static Category ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Category value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Category.Ammunition:
                    serializer.Serialize(writer, "Ammunition");
                    break;
                case Category.Attachment:
                    serializer.Serialize(writer, "Attachment");
                    break;
                case Category.Empty:
                    serializer.Serialize(writer, "");
                    break;
                case Category.Equipment:
                    serializer.Serialize(writer, "Equipment");
                    break;
                case Category.Use:
                    serializer.Serialize(writer, "Use");
                    break;
                case Category.Weapon:
                    serializer.Serialize(writer, "Weapon");
                    break;
            }
        }
    }

    internal static class ItemIdExtensions
    {
        public static ItemId? ValueForString(string str)
        {
            switch (str)
            {
                case "": return ItemId.Empty;
                case "Item_Ammo_12Guage_C": return ItemId.ItemAmmo12GuageC;
                case "Item_Ammo_300Magnum_C": return ItemId.ItemAmmo300MagnumC;
                case "Item_Ammo_45ACP_C": return ItemId.ItemAmmo45AcpC;
                case "Item_Ammo_556mm_C": return ItemId.ItemAmmo556MmC;
                case "Item_Ammo_762mm_C": return ItemId.ItemAmmo762MmC;
                case "Item_Ammo_9mm_C": return ItemId.ItemAmmo9MmC;
                case "Item_Ammo_Bolt_C": return ItemId.ItemAmmoBoltC;
                case "Item_Ammo_Flare_C": return ItemId.ItemAmmoFlareC;
                case "Item_Armor_C_01_Lv3_C": return ItemId.ItemArmorC01_Lv3C;
                case "Item_Armor_D_01_Lv2_C": return ItemId.ItemArmorD01_Lv2C;
                case "Item_Armor_E_01_Lv1_C": return ItemId.ItemArmorE01_Lv1C;
                case "Item_Attach_Weapon_Lower_AngledForeGrip_C": return ItemId.ItemAttachWeaponLowerAngledForeGripC;
                case "Item_Attach_Weapon_Lower_Foregrip_C": return ItemId.ItemAttachWeaponLowerForegripC;
                case "Item_Attach_Weapon_Lower_QuickDraw_Large_Crossbow_C":
                    return ItemId.ItemAttachWeaponLowerQuickDrawLargeCrossbowC;
                case "Item_Attach_Weapon_Magazine_Extended_Large_C":
                    return ItemId.ItemAttachWeaponMagazineExtendedLargeC;
                case "Item_Attach_Weapon_Magazine_Extended_Medium_C":
                    return ItemId.ItemAttachWeaponMagazineExtendedMediumC;
                case "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Large_C":
                    return ItemId.ItemAttachWeaponMagazineExtendedQuickDrawLargeC;
                case "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Medium_C":
                    return ItemId.ItemAttachWeaponMagazineExtendedQuickDrawMediumC;
                case "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Small_C":
                    return ItemId.ItemAttachWeaponMagazineExtendedQuickDrawSmallC;
                case "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_SniperRifle_C":
                    return ItemId.ItemAttachWeaponMagazineExtendedQuickDrawSniperRifleC;
                case "Item_Attach_Weapon_Magazine_Extended_Small_C":
                    return ItemId.ItemAttachWeaponMagazineExtendedSmallC;
                case "Item_Attach_Weapon_Magazine_Extended_SniperRifle_C":
                    return ItemId.ItemAttachWeaponMagazineExtendedSniperRifleC;
                case "Item_Attach_Weapon_Magazine_QuickDraw_Large_C":
                    return ItemId.ItemAttachWeaponMagazineQuickDrawLargeC;
                case "Item_Attach_Weapon_Magazine_QuickDraw_Medium_C":
                    return ItemId.ItemAttachWeaponMagazineQuickDrawMediumC;
                case "Item_Attach_Weapon_Magazine_QuickDraw_Small_C":
                    return ItemId.ItemAttachWeaponMagazineQuickDrawSmallC;
                case "Item_Attach_Weapon_Magazine_QuickDraw_SniperRifle_C":
                    return ItemId.ItemAttachWeaponMagazineQuickDrawSniperRifleC;
                case "Item_Attach_Weapon_Muzzle_Choke_C": return ItemId.ItemAttachWeaponMuzzleChokeC;
                case "Item_Attach_Weapon_Muzzle_Compensator_Large_C":
                    return ItemId.ItemAttachWeaponMuzzleCompensatorLargeC;
                case "Item_Attach_Weapon_Muzzle_Compensator_Medium_C":
                    return ItemId.ItemAttachWeaponMuzzleCompensatorMediumC;
                case "Item_Attach_Weapon_Muzzle_Compensator_SniperRifle_C":
                    return ItemId.ItemAttachWeaponMuzzleCompensatorSniperRifleC;
                case "Item_Attach_Weapon_Muzzle_FlashHider_Large_C":
                    return ItemId.ItemAttachWeaponMuzzleFlashHiderLargeC;
                case "Item_Attach_Weapon_Muzzle_FlashHider_Medium_C":
                    return ItemId.ItemAttachWeaponMuzzleFlashHiderMediumC;
                case "Item_Attach_Weapon_Muzzle_FlashHider_SniperRifle_C":
                    return ItemId.ItemAttachWeaponMuzzleFlashHiderSniperRifleC;
                case "Item_Attach_Weapon_Muzzle_Suppressor_Large_C":
                    return ItemId.ItemAttachWeaponMuzzleSuppressorLargeC;
                case "Item_Attach_Weapon_Muzzle_Suppressor_Medium_C":
                    return ItemId.ItemAttachWeaponMuzzleSuppressorMediumC;
                case "Item_Attach_Weapon_Muzzle_Suppressor_Small_C":
                    return ItemId.ItemAttachWeaponMuzzleSuppressorSmallC;
                case "Item_Attach_Weapon_Muzzle_Suppressor_SniperRifle_C":
                    return ItemId.ItemAttachWeaponMuzzleSuppressorSniperRifleC;
                case "Item_Attach_Weapon_Stock_AR_Composite_C": return ItemId.ItemAttachWeaponStockArCompositeC;
                case "Item_Attach_Weapon_Stock_Shotgun_BulletLoops_C":
                    return ItemId.ItemAttachWeaponStockShotgunBulletLoopsC;
                case "Item_Attach_Weapon_Stock_SniperRifle_BulletLoops_C":
                    return ItemId.ItemAttachWeaponStockSniperRifleBulletLoopsC;
                case "Item_Attach_Weapon_Stock_SniperRifle_CheekPad_C":
                    return ItemId.ItemAttachWeaponStockSniperRifleCheekPadC;
                case "Item_Attach_Weapon_Stock_UZI_C": return ItemId.ItemAttachWeaponStockUziC;
                case "Item_Attach_Weapon_Upper_ACOG_01_C": return ItemId.ItemAttachWeaponUpperAcog01_C;
                case "Item_Attach_Weapon_Upper_Aimpoint_C": return ItemId.ItemAttachWeaponUpperAimpointC;
                case "Item_Attach_Weapon_Upper_CQBSS_C": return ItemId.ItemAttachWeaponUpperCqbssC;
                case "Item_Attach_Weapon_Upper_DotSight_01_C": return ItemId.ItemAttachWeaponUpperDotSight01_C;
                case "Item_Attach_Weapon_Upper_Holosight_C": return ItemId.ItemAttachWeaponUpperHolosightC;
                case "Item_Attach_Weapon_Upper_PM2_01_C": return ItemId.ItemAttachWeaponUpperPm201_C;
                case "Item_Back_B_01_StartParachutePack_C": return ItemId.ItemBackB01_StartParachutePackC;
                case "Item_Back_C_02_Lv3_C": return ItemId.ItemBackC02_Lv3C;
                case "Item_Back_E_01_Lv1_C": return ItemId.ItemBackE01_Lv1C;
                case "Item_Back_E_02_Lv1_C": return ItemId.ItemBackE02_Lv1C;
                case "Item_Back_F_01_Lv2_C": return ItemId.ItemBackF01_Lv2C;
                case "Item_Back_F_02_Lv2_C": return ItemId.ItemBackF02_Lv2C;
                case "Item_Boost_EnergyDrink_C": return ItemId.ItemBoostEnergyDrinkC;
                case "Item_Boost_PainKiller_C": return ItemId.ItemBoostPainKillerC;
                case "Item_Head_E_01_Lv1_C": return ItemId.ItemHeadE01_Lv1C;
                case "Item_Head_E_02_Lv1_C": return ItemId.ItemHeadE02_Lv1C;
                case "Item_Head_F_01_Lv2_C": return ItemId.ItemHeadF01_Lv2C;
                case "Item_Head_F_02_Lv2_C": return ItemId.ItemHeadF02_Lv2C;
                case "Item_Head_G_01_Lv3_C": return ItemId.ItemHeadG01_Lv3C;
                case "Item_Heal_Bandage_C": return ItemId.ItemHealBandageC;
                case "Item_Heal_FirstAid_C": return ItemId.ItemHealFirstAidC;
                case "Item_Heal_MedKit_C": return ItemId.ItemHealMedKitC;
                case "Item_JerryCan_C": return ItemId.ItemJerryCanC;
                case "Item_Weapon_AK47_C": return ItemId.ItemWeaponAk47C;
                case "Item_Weapon_AUG_C": return ItemId.ItemWeaponAugC;
                case "Item_Weapon_AWM_C": return ItemId.ItemWeaponAwmC;
                case "Item_Weapon_Berreta686_C": return ItemId.ItemWeaponBerreta686C;
                case "Item_Weapon_Cowbar_C": return ItemId.ItemWeaponCowbarC;
                case "Item_Weapon_Crossbow_C": return ItemId.ItemWeaponCrossbowC;
                case "Item_Weapon_FlareGun_C": return ItemId.ItemWeaponFlareGunC;
                case "Item_Weapon_FlashBang_C": return ItemId.ItemWeaponFlashBangC;
                case "Item_Weapon_G18_C": return ItemId.ItemWeaponG18C;
                case "Item_Weapon_Grenade_C": return ItemId.ItemWeaponGrenadeC;
                case "Item_Weapon_Groza_C": return ItemId.ItemWeaponGrozaC;
                case "Item_Weapon_HK416_C": return ItemId.ItemWeaponHk416C;
                case "Item_Weapon_Kar98k_C": return ItemId.ItemWeaponKar98KC;
                case "Item_Weapon_M16A4_C": return ItemId.ItemWeaponM16A4C;
                case "Item_Weapon_M1911_C": return ItemId.ItemWeaponM1911C;
                case "Item_Weapon_M249_C": return ItemId.ItemWeaponM249C;
                case "Item_Weapon_M24_C": return ItemId.ItemWeaponM24C;
                case "Item_Weapon_M9_C": return ItemId.ItemWeaponM9C;
                case "Item_Weapon_Machete_C": return ItemId.ItemWeaponMacheteC;
                case "Item_Weapon_Mini14_C": return ItemId.ItemWeaponMini14C;
                case "Item_Weapon_Mk14_C": return ItemId.ItemWeaponMk14C;
                case "Item_Weapon_Molotov_C": return ItemId.ItemWeaponMolotovC;
                case "Item_Weapon_Pan_C": return ItemId.ItemWeaponPanC;
                case "Item_Weapon_Rhino_C": return ItemId.ItemWeaponRhinoC;
                case "Item_Weapon_Saiga12_C": return ItemId.ItemWeaponSaiga12C;
                case "Item_Weapon_Sawnoff_C": return ItemId.ItemWeaponSawnoffC;
                case "Item_Weapon_SCAR-L_C": return ItemId.ItemWeaponScarLC;
                case "Item_Weapon_Sickle_C": return ItemId.ItemWeaponSickleC;
                case "Item_Weapon_SKS_C": return ItemId.ItemWeaponSksC;
                case "Item_Weapon_SmokeBomb_C": return ItemId.ItemWeaponSmokeBombC;
                case "Item_Weapon_Thompson_C": return ItemId.ItemWeaponThompsonC;
                case "Item_Weapon_UMP_C": return ItemId.ItemWeaponUmpC;
                case "Item_Weapon_UZI_C": return ItemId.ItemWeaponUziC;
                case "Item_Weapon_Vector_C": return ItemId.ItemWeaponVectorC;
                case "Item_Weapon_VSS_C": return ItemId.ItemWeaponVssC;
                case "Item_Weapon_Win1894_C": return ItemId.ItemWeaponWin1894C;
                case "Item_Weapon_Winchester_C": return ItemId.ItemWeaponWinchesterC;
                default: return null;
            }
        }

        public static ItemId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ItemId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ItemId.Empty:
                    serializer.Serialize(writer, "");
                    break;
                case ItemId.ItemAmmo12GuageC:
                    serializer.Serialize(writer, "Item_Ammo_12Guage_C");
                    break;
                case ItemId.ItemAmmo300MagnumC:
                    serializer.Serialize(writer, "Item_Ammo_300Magnum_C");
                    break;
                case ItemId.ItemAmmo45AcpC:
                    serializer.Serialize(writer, "Item_Ammo_45ACP_C");
                    break;
                case ItemId.ItemAmmo556MmC:
                    serializer.Serialize(writer, "Item_Ammo_556mm_C");
                    break;
                case ItemId.ItemAmmo762MmC:
                    serializer.Serialize(writer, "Item_Ammo_762mm_C");
                    break;
                case ItemId.ItemAmmo9MmC:
                    serializer.Serialize(writer, "Item_Ammo_9mm_C");
                    break;
                case ItemId.ItemAmmoBoltC:
                    serializer.Serialize(writer, "Item_Ammo_Bolt_C");
                    break;
                case ItemId.ItemAmmoFlareC:
                    serializer.Serialize(writer, "Item_Ammo_Flare_C");
                    break;
                case ItemId.ItemArmorC01_Lv3C:
                    serializer.Serialize(writer, "Item_Armor_C_01_Lv3_C");
                    break;
                case ItemId.ItemArmorD01_Lv2C:
                    serializer.Serialize(writer, "Item_Armor_D_01_Lv2_C");
                    break;
                case ItemId.ItemArmorE01_Lv1C:
                    serializer.Serialize(writer, "Item_Armor_E_01_Lv1_C");
                    break;
                case ItemId.ItemAttachWeaponLowerAngledForeGripC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Lower_AngledForeGrip_C");
                    break;
                case ItemId.ItemAttachWeaponLowerForegripC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Lower_Foregrip_C");
                    break;
                case ItemId.ItemAttachWeaponLowerQuickDrawLargeCrossbowC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Lower_QuickDraw_Large_Crossbow_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineExtendedLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_Extended_Large_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineExtendedMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_Extended_Medium_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineExtendedQuickDrawLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Large_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineExtendedQuickDrawMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Medium_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineExtendedQuickDrawSmallC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_Small_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineExtendedQuickDrawSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_ExtendedQuickDraw_SniperRifle_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineExtendedSmallC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_Extended_Small_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineExtendedSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_Extended_SniperRifle_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineQuickDrawLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_QuickDraw_Large_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineQuickDrawMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_QuickDraw_Medium_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineQuickDrawSmallC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_QuickDraw_Small_C");
                    break;
                case ItemId.ItemAttachWeaponMagazineQuickDrawSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Magazine_QuickDraw_SniperRifle_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleChokeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Choke_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleCompensatorLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Compensator_Large_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleCompensatorMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Compensator_Medium_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleCompensatorSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Compensator_SniperRifle_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleFlashHiderLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_FlashHider_Large_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleFlashHiderMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_FlashHider_Medium_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleFlashHiderSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_FlashHider_SniperRifle_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleSuppressorLargeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Suppressor_Large_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleSuppressorMediumC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Suppressor_Medium_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleSuppressorSmallC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Suppressor_Small_C");
                    break;
                case ItemId.ItemAttachWeaponMuzzleSuppressorSniperRifleC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Muzzle_Suppressor_SniperRifle_C");
                    break;
                case ItemId.ItemAttachWeaponStockArCompositeC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_AR_Composite_C");
                    break;
                case ItemId.ItemAttachWeaponStockShotgunBulletLoopsC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_Shotgun_BulletLoops_C");
                    break;
                case ItemId.ItemAttachWeaponStockSniperRifleBulletLoopsC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_SniperRifle_BulletLoops_C");
                    break;
                case ItemId.ItemAttachWeaponStockSniperRifleCheekPadC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_SniperRifle_CheekPad_C");
                    break;
                case ItemId.ItemAttachWeaponStockUziC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Stock_UZI_C");
                    break;
                case ItemId.ItemAttachWeaponUpperAcog01_C:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_ACOG_01_C");
                    break;
                case ItemId.ItemAttachWeaponUpperAimpointC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_Aimpoint_C");
                    break;
                case ItemId.ItemAttachWeaponUpperCqbssC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_CQBSS_C");
                    break;
                case ItemId.ItemAttachWeaponUpperDotSight01_C:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_DotSight_01_C");
                    break;
                case ItemId.ItemAttachWeaponUpperHolosightC:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_Holosight_C");
                    break;
                case ItemId.ItemAttachWeaponUpperPm201_C:
                    serializer.Serialize(writer, "Item_Attach_Weapon_Upper_PM2_01_C");
                    break;
                case ItemId.ItemBackB01_StartParachutePackC:
                    serializer.Serialize(writer, "Item_Back_B_01_StartParachutePack_C");
                    break;
                case ItemId.ItemBackC02_Lv3C:
                    serializer.Serialize(writer, "Item_Back_C_02_Lv3_C");
                    break;
                case ItemId.ItemBackE01_Lv1C:
                    serializer.Serialize(writer, "Item_Back_E_01_Lv1_C");
                    break;
                case ItemId.ItemBackE02_Lv1C:
                    serializer.Serialize(writer, "Item_Back_E_02_Lv1_C");
                    break;
                case ItemId.ItemBackF01_Lv2C:
                    serializer.Serialize(writer, "Item_Back_F_01_Lv2_C");
                    break;
                case ItemId.ItemBackF02_Lv2C:
                    serializer.Serialize(writer, "Item_Back_F_02_Lv2_C");
                    break;
                case ItemId.ItemBoostEnergyDrinkC:
                    serializer.Serialize(writer, "Item_Boost_EnergyDrink_C");
                    break;
                case ItemId.ItemBoostPainKillerC:
                    serializer.Serialize(writer, "Item_Boost_PainKiller_C");
                    break;
                case ItemId.ItemHeadE01_Lv1C:
                    serializer.Serialize(writer, "Item_Head_E_01_Lv1_C");
                    break;
                case ItemId.ItemHeadE02_Lv1C:
                    serializer.Serialize(writer, "Item_Head_E_02_Lv1_C");
                    break;
                case ItemId.ItemHeadF01_Lv2C:
                    serializer.Serialize(writer, "Item_Head_F_01_Lv2_C");
                    break;
                case ItemId.ItemHeadF02_Lv2C:
                    serializer.Serialize(writer, "Item_Head_F_02_Lv2_C");
                    break;
                case ItemId.ItemHeadG01_Lv3C:
                    serializer.Serialize(writer, "Item_Head_G_01_Lv3_C");
                    break;
                case ItemId.ItemHealBandageC:
                    serializer.Serialize(writer, "Item_Heal_Bandage_C");
                    break;
                case ItemId.ItemHealFirstAidC:
                    serializer.Serialize(writer, "Item_Heal_FirstAid_C");
                    break;
                case ItemId.ItemHealMedKitC:
                    serializer.Serialize(writer, "Item_Heal_MedKit_C");
                    break;
                case ItemId.ItemJerryCanC:
                    serializer.Serialize(writer, "Item_JerryCan_C");
                    break;
                case ItemId.ItemWeaponAk47C:
                    serializer.Serialize(writer, "Item_Weapon_AK47_C");
                    break;
                case ItemId.ItemWeaponAugC:
                    serializer.Serialize(writer, "Item_Weapon_AUG_C");
                    break;
                case ItemId.ItemWeaponAwmC:
                    serializer.Serialize(writer, "Item_Weapon_AWM_C");
                    break;
                case ItemId.ItemWeaponBerreta686C:
                    serializer.Serialize(writer, "Item_Weapon_Berreta686_C");
                    break;
                case ItemId.ItemWeaponCowbarC:
                    serializer.Serialize(writer, "Item_Weapon_Cowbar_C");
                    break;
                case ItemId.ItemWeaponCrossbowC:
                    serializer.Serialize(writer, "Item_Weapon_Crossbow_C");
                    break;
                case ItemId.ItemWeaponFlareGunC:
                    serializer.Serialize(writer, "Item_Weapon_FlareGun_C");
                    break;
                case ItemId.ItemWeaponFlashBangC:
                    serializer.Serialize(writer, "Item_Weapon_FlashBang_C");
                    break;
                case ItemId.ItemWeaponG18C:
                    serializer.Serialize(writer, "Item_Weapon_G18_C");
                    break;
                case ItemId.ItemWeaponGrenadeC:
                    serializer.Serialize(writer, "Item_Weapon_Grenade_C");
                    break;
                case ItemId.ItemWeaponGrozaC:
                    serializer.Serialize(writer, "Item_Weapon_Groza_C");
                    break;
                case ItemId.ItemWeaponHk416C:
                    serializer.Serialize(writer, "Item_Weapon_HK416_C");
                    break;
                case ItemId.ItemWeaponKar98KC:
                    serializer.Serialize(writer, "Item_Weapon_Kar98k_C");
                    break;
                case ItemId.ItemWeaponM16A4C:
                    serializer.Serialize(writer, "Item_Weapon_M16A4_C");
                    break;
                case ItemId.ItemWeaponM1911C:
                    serializer.Serialize(writer, "Item_Weapon_M1911_C");
                    break;
                case ItemId.ItemWeaponM249C:
                    serializer.Serialize(writer, "Item_Weapon_M249_C");
                    break;
                case ItemId.ItemWeaponM24C:
                    serializer.Serialize(writer, "Item_Weapon_M24_C");
                    break;
                case ItemId.ItemWeaponM9C:
                    serializer.Serialize(writer, "Item_Weapon_M9_C");
                    break;
                case ItemId.ItemWeaponMacheteC:
                    serializer.Serialize(writer, "Item_Weapon_Machete_C");
                    break;
                case ItemId.ItemWeaponMini14C:
                    serializer.Serialize(writer, "Item_Weapon_Mini14_C");
                    break;
                case ItemId.ItemWeaponMk14C:
                    serializer.Serialize(writer, "Item_Weapon_Mk14_C");
                    break;
                case ItemId.ItemWeaponMolotovC:
                    serializer.Serialize(writer, "Item_Weapon_Molotov_C");
                    break;
                case ItemId.ItemWeaponPanC:
                    serializer.Serialize(writer, "Item_Weapon_Pan_C");
                    break;
                case ItemId.ItemWeaponRhinoC:
                    serializer.Serialize(writer, "Item_Weapon_Rhino_C");
                    break;
                case ItemId.ItemWeaponSaiga12C:
                    serializer.Serialize(writer, "Item_Weapon_Saiga12_C");
                    break;
                case ItemId.ItemWeaponSawnoffC:
                    serializer.Serialize(writer, "Item_Weapon_Sawnoff_C");
                    break;
                case ItemId.ItemWeaponScarLC:
                    serializer.Serialize(writer, "Item_Weapon_SCAR-L_C");
                    break;
                case ItemId.ItemWeaponSickleC:
                    serializer.Serialize(writer, "Item_Weapon_Sickle_C");
                    break;
                case ItemId.ItemWeaponSksC:
                    serializer.Serialize(writer, "Item_Weapon_SKS_C");
                    break;
                case ItemId.ItemWeaponSmokeBombC:
                    serializer.Serialize(writer, "Item_Weapon_SmokeBomb_C");
                    break;
                case ItemId.ItemWeaponThompsonC:
                    serializer.Serialize(writer, "Item_Weapon_Thompson_C");
                    break;
                case ItemId.ItemWeaponUmpC:
                    serializer.Serialize(writer, "Item_Weapon_UMP_C");
                    break;
                case ItemId.ItemWeaponUziC:
                    serializer.Serialize(writer, "Item_Weapon_UZI_C");
                    break;
                case ItemId.ItemWeaponVectorC:
                    serializer.Serialize(writer, "Item_Weapon_Vector_C");
                    break;
                case ItemId.ItemWeaponVssC:
                    serializer.Serialize(writer, "Item_Weapon_VSS_C");
                    break;
                case ItemId.ItemWeaponWin1894C:
                    serializer.Serialize(writer, "Item_Weapon_Win1894_C");
                    break;
                case ItemId.ItemWeaponWinchesterC:
                    serializer.Serialize(writer, "Item_Weapon_Winchester_C");
                    break;
            }
        }
    }

    internal static class SubCategoryExtensions
    {
        public static SubCategory? ValueForString(string str)
        {
            switch (str)
            {
                case "Backpack": return SubCategory.Backpack;
                case "Boost": return SubCategory.Boost;
                case "": return SubCategory.Empty;
                case "Fuel": return SubCategory.Fuel;
                case "Handgun": return SubCategory.Handgun;
                case "Headgear": return SubCategory.Headgear;
                case "Heal": return SubCategory.Heal;
                case "Main": return SubCategory.Main;
                case "Melee": return SubCategory.Melee;
                case "None": return SubCategory.None;
                case "Throwable": return SubCategory.Throwable;
                case "Vest": return SubCategory.Vest;
                default: return null;
            }
        }

        public static SubCategory ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this SubCategory value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case SubCategory.Backpack:
                    serializer.Serialize(writer, "Backpack");
                    break;
                case SubCategory.Boost:
                    serializer.Serialize(writer, "Boost");
                    break;
                case SubCategory.Empty:
                    serializer.Serialize(writer, "");
                    break;
                case SubCategory.Fuel:
                    serializer.Serialize(writer, "Fuel");
                    break;
                case SubCategory.Handgun:
                    serializer.Serialize(writer, "Handgun");
                    break;
                case SubCategory.Headgear:
                    serializer.Serialize(writer, "Headgear");
                    break;
                case SubCategory.Heal:
                    serializer.Serialize(writer, "Heal");
                    break;
                case SubCategory.Main:
                    serializer.Serialize(writer, "Main");
                    break;
                case SubCategory.Melee:
                    serializer.Serialize(writer, "Melee");
                    break;
                case SubCategory.None:
                    serializer.Serialize(writer, "None");
                    break;
                case SubCategory.Throwable:
                    serializer.Serialize(writer, "Throwable");
                    break;
                case SubCategory.Vest:
                    serializer.Serialize(writer, "Vest");
                    break;
            }
        }
    }

    internal static class MapNameExtensions
    {
        public static MapName? ValueForString(string str)
        {
            switch (str)
            {
                case "Desert_Main": return MapName.DesertMain;
                case "": return MapName.Empty;
                default: return null;
            }
        }

        public static MapName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this MapName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case MapName.DesertMain:
                    serializer.Serialize(writer, "Desert_Main");
                    break;
                case MapName.Empty:
                    serializer.Serialize(writer, "");
                    break;
            }
        }
    }

    internal static class DamageCauserNameExtensions
    {
        public static DamageCauserName? ValueForString(string str)
        {
            switch (str)
            {
                case "BattleRoyaleModeController_Desert_C": return DamageCauserName.BattleRoyaleModeControllerDesertC;
                case "BP_Motorbike_04_Desert_C": return DamageCauserName.BpMotorbike04_DesertC;
                case "BP_PickupTruck_A_01_C": return DamageCauserName.BpPickupTruckA01_C;
                case "BP_PickupTruck_A_02_C": return DamageCauserName.BpPickupTruckA02_C;
                case "BP_PickupTruck_A_03_C": return DamageCauserName.BpPickupTruckA03_C;
                case "BP_PickupTruck_B_01_C": return DamageCauserName.BpPickupTruckB01_C;
                case "BP_PickupTruck_B_02_C": return DamageCauserName.BpPickupTruckB02_C;
                case "BP_Van_A_02_C": return DamageCauserName.BpVanA02_C;
                case "Buff_DecreaseBreathInApnea_C": return DamageCauserName.BuffDecreaseBreathInApneaC;
                case "Buggy_A_04_C": return DamageCauserName.BuggyA04_C;
                case "PlayerFemale_A_C": return DamageCauserName.PlayerFemaleAC;
                case "PlayerMale_A_C": return DamageCauserName.PlayerMaleAC;
                case "ProjGrenade_C": return DamageCauserName.ProjGrenadeC;
                case "RedZoneBomb_C": return DamageCauserName.RedZoneBombC;
                case "WeapAK47_C": return DamageCauserName.WeapAk47C;
                case "WeapAUG_C": return DamageCauserName.WeapAugC;
                case "WeapAWM_C": return DamageCauserName.WeapAwmC;
                case "WeapBerreta686_C": return DamageCauserName.WeapBerreta686C;
                case "WeapG18_C": return DamageCauserName.WeapG18C;
                case "WeapHK416_C": return DamageCauserName.WeapHk416C;
                case "WeapKar98k_C": return DamageCauserName.WeapKar98KC;
                case "WeapM16A4_C": return DamageCauserName.WeapM16A4C;
                case "WeapM1911_C": return DamageCauserName.WeapM1911C;
                case "WeapM249_C": return DamageCauserName.WeapM249C;
                case "WeapM24_C": return DamageCauserName.WeapM24C;
                case "WeapM9_C": return DamageCauserName.WeapM9C;
                case "WeapMk14_C": return DamageCauserName.WeapMk14C;
                case "WeapSaiga12_C": return DamageCauserName.WeapSaiga12C;
                case "WeapSawnoff_C": return DamageCauserName.WeapSawnoffC;
                case "WeapSCAR-L_C": return DamageCauserName.WeapScarLC;
                case "WeapSKS_C": return DamageCauserName.WeapSksC;
                case "WeapUMP_C": return DamageCauserName.WeapUmpC;
                case "WeapUZI_C": return DamageCauserName.WeapUziC;
                case "WeapVector_C": return DamageCauserName.WeapVectorC;
                case "WeapWin94_C": return DamageCauserName.WeapWin94C;
                case "WeapWinchester_C": return DamageCauserName.WeapWinchesterC;
                default: return null;
            }
        }

        public static DamageCauserName ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this DamageCauserName value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case DamageCauserName.BattleRoyaleModeControllerDesertC:
                    serializer.Serialize(writer, "BattleRoyaleModeController_Desert_C");
                    break;
                case DamageCauserName.BpMotorbike04_DesertC:
                    serializer.Serialize(writer, "BP_Motorbike_04_Desert_C");
                    break;
                case DamageCauserName.BpPickupTruckA01_C:
                    serializer.Serialize(writer, "BP_PickupTruck_A_01_C");
                    break;
                case DamageCauserName.BpPickupTruckA02_C:
                    serializer.Serialize(writer, "BP_PickupTruck_A_02_C");
                    break;
                case DamageCauserName.BpPickupTruckA03_C:
                    serializer.Serialize(writer, "BP_PickupTruck_A_03_C");
                    break;
                case DamageCauserName.BpPickupTruckB01_C:
                    serializer.Serialize(writer, "BP_PickupTruck_B_01_C");
                    break;
                case DamageCauserName.BpPickupTruckB02_C:
                    serializer.Serialize(writer, "BP_PickupTruck_B_02_C");
                    break;
                case DamageCauserName.BpVanA02_C:
                    serializer.Serialize(writer, "BP_Van_A_02_C");
                    break;
                case DamageCauserName.BuffDecreaseBreathInApneaC:
                    serializer.Serialize(writer, "Buff_DecreaseBreathInApnea_C");
                    break;
                case DamageCauserName.BuggyA04_C:
                    serializer.Serialize(writer, "Buggy_A_04_C");
                    break;
                case DamageCauserName.PlayerFemaleAC:
                    serializer.Serialize(writer, "PlayerFemale_A_C");
                    break;
                case DamageCauserName.PlayerMaleAC:
                    serializer.Serialize(writer, "PlayerMale_A_C");
                    break;
                case DamageCauserName.ProjGrenadeC:
                    serializer.Serialize(writer, "ProjGrenade_C");
                    break;
                case DamageCauserName.RedZoneBombC:
                    serializer.Serialize(writer, "RedZoneBomb_C");
                    break;
                case DamageCauserName.WeapAk47C:
                    serializer.Serialize(writer, "WeapAK47_C");
                    break;
                case DamageCauserName.WeapAugC:
                    serializer.Serialize(writer, "WeapAUG_C");
                    break;
                case DamageCauserName.WeapAwmC:
                    serializer.Serialize(writer, "WeapAWM_C");
                    break;
                case DamageCauserName.WeapBerreta686C:
                    serializer.Serialize(writer, "WeapBerreta686_C");
                    break;
                case DamageCauserName.WeapG18C:
                    serializer.Serialize(writer, "WeapG18_C");
                    break;
                case DamageCauserName.WeapHk416C:
                    serializer.Serialize(writer, "WeapHK416_C");
                    break;
                case DamageCauserName.WeapKar98KC:
                    serializer.Serialize(writer, "WeapKar98k_C");
                    break;
                case DamageCauserName.WeapM16A4C:
                    serializer.Serialize(writer, "WeapM16A4_C");
                    break;
                case DamageCauserName.WeapM1911C:
                    serializer.Serialize(writer, "WeapM1911_C");
                    break;
                case DamageCauserName.WeapM249C:
                    serializer.Serialize(writer, "WeapM249_C");
                    break;
                case DamageCauserName.WeapM24C:
                    serializer.Serialize(writer, "WeapM24_C");
                    break;
                case DamageCauserName.WeapM9C:
                    serializer.Serialize(writer, "WeapM9_C");
                    break;
                case DamageCauserName.WeapMk14C:
                    serializer.Serialize(writer, "WeapMk14_C");
                    break;
                case DamageCauserName.WeapSaiga12C:
                    serializer.Serialize(writer, "WeapSaiga12_C");
                    break;
                case DamageCauserName.WeapSawnoffC:
                    serializer.Serialize(writer, "WeapSawnoff_C");
                    break;
                case DamageCauserName.WeapScarLC:
                    serializer.Serialize(writer, "WeapSCAR-L_C");
                    break;
                case DamageCauserName.WeapSksC:
                    serializer.Serialize(writer, "WeapSKS_C");
                    break;
                case DamageCauserName.WeapUmpC:
                    serializer.Serialize(writer, "WeapUMP_C");
                    break;
                case DamageCauserName.WeapUziC:
                    serializer.Serialize(writer, "WeapUZI_C");
                    break;
                case DamageCauserName.WeapVectorC:
                    serializer.Serialize(writer, "WeapVector_C");
                    break;
                case DamageCauserName.WeapWin94C:
                    serializer.Serialize(writer, "WeapWin94_C");
                    break;
                case DamageCauserName.WeapWinchesterC:
                    serializer.Serialize(writer, "WeapWinchester_C");
                    break;
            }
        }
    }

    internal static class DamageReasonExtensions
    {
        public static DamageReason? ValueForString(string str)
        {
            switch (str)
            {
                case "ArmShot": return DamageReason.ArmShot;
                case "HeadShot": return DamageReason.HeadShot;
                case "LegShot": return DamageReason.LegShot;
                case "NonSpecific": return DamageReason.NonSpecific;
                case "None": return DamageReason.None;
                case "PelvisShot": return DamageReason.PelvisShot;
                case "TorsoShot": return DamageReason.TorsoShot;
                default: return null;
            }
        }

        public static DamageReason ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this DamageReason value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case DamageReason.ArmShot:
                    serializer.Serialize(writer, "ArmShot");
                    break;
                case DamageReason.HeadShot:
                    serializer.Serialize(writer, "HeadShot");
                    break;
                case DamageReason.LegShot:
                    serializer.Serialize(writer, "LegShot");
                    break;
                case DamageReason.NonSpecific:
                    serializer.Serialize(writer, "NonSpecific");
                    break;
                case DamageReason.None:
                    serializer.Serialize(writer, "None");
                    break;
                case DamageReason.PelvisShot:
                    serializer.Serialize(writer, "PelvisShot");
                    break;
                case DamageReason.TorsoShot:
                    serializer.Serialize(writer, "TorsoShot");
                    break;
            }
        }
    }

    internal static class DamageTypeCategoryExtensions
    {
        public static DamageTypeCategory? ValueForString(string str)
        {
            switch (str)
            {
                case "Damage_BlueZone": return DamageTypeCategory.DamageBlueZone;
                case "Damage_Drown": return DamageTypeCategory.DamageDrown;
                case "Damage_Explosion_Grenade": return DamageTypeCategory.DamageExplosionGrenade;
                case "Damage_Explosion_RedZone": return DamageTypeCategory.DamageExplosionRedZone;
                case "Damage_Groggy": return DamageTypeCategory.DamageGroggy;
                case "Damage_Gun": return DamageTypeCategory.DamageGun;
                case "Damage_Instant_Fall": return DamageTypeCategory.DamageInstantFall;
                case "Damage_Melee": return DamageTypeCategory.DamageMelee;
                case "Damage_VehicleCrashHit": return DamageTypeCategory.DamageVehicleCrashHit;
                case "Damage_VehicleHit": return DamageTypeCategory.DamageVehicleHit;
                case "": return DamageTypeCategory.Empty;
                default: return null;
            }
        }

        public static DamageTypeCategory ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this DamageTypeCategory value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case DamageTypeCategory.DamageBlueZone:
                    serializer.Serialize(writer, "Damage_BlueZone");
                    break;
                case DamageTypeCategory.DamageDrown:
                    serializer.Serialize(writer, "Damage_Drown");
                    break;
                case DamageTypeCategory.DamageExplosionGrenade:
                    serializer.Serialize(writer, "Damage_Explosion_Grenade");
                    break;
                case DamageTypeCategory.DamageExplosionRedZone:
                    serializer.Serialize(writer, "Damage_Explosion_RedZone");
                    break;
                case DamageTypeCategory.DamageGroggy:
                    serializer.Serialize(writer, "Damage_Groggy");
                    break;
                case DamageTypeCategory.DamageGun:
                    serializer.Serialize(writer, "Damage_Gun");
                    break;
                case DamageTypeCategory.DamageInstantFall:
                    serializer.Serialize(writer, "Damage_Instant_Fall");
                    break;
                case DamageTypeCategory.DamageMelee:
                    serializer.Serialize(writer, "Damage_Melee");
                    break;
                case DamageTypeCategory.DamageVehicleCrashHit:
                    serializer.Serialize(writer, "Damage_VehicleCrashHit");
                    break;
                case DamageTypeCategory.DamageVehicleHit:
                    serializer.Serialize(writer, "Damage_VehicleHit");
                    break;
                case DamageTypeCategory.Empty:
                    serializer.Serialize(writer, "");
                    break;
            }
        }
    }

    internal static class ErrorMessageExtensions
    {
        public static ErrorMessage? ValueForString(string str)
        {
            switch (str)
            {
                case "": return ErrorMessage.Empty;
                default: return null;
            }
        }

        public static ErrorMessage ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ErrorMessage value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ErrorMessage.Empty:
                    serializer.Serialize(writer, "");
                    break;
            }
        }
    }

    internal static class ItemPackageIdExtensions
    {
        public static ItemPackageId? ValueForString(string str)
        {
            switch (str)
            {
                case "Carapackage_FlareGun_C": return ItemPackageId.CarapackageFlareGunC;
                case "Carapackage_RedBox_C": return ItemPackageId.CarapackageRedBoxC;
                default: return null;
            }
        }

        public static ItemPackageId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ItemPackageId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ItemPackageId.CarapackageFlareGunC:
                    serializer.Serialize(writer, "Carapackage_FlareGun_C");
                    break;
                case ItemPackageId.CarapackageRedBoxC:
                    serializer.Serialize(writer, "Carapackage_RedBox_C");
                    break;
            }
        }
    }

    internal static class TExtensions
    {
        public static T? ValueForString(string str)
        {
            switch (str)
            {
                case "LogCarePackageLand": return T.LogCarePackageLand;
                case "LogCarePackageSpawn": return T.LogCarePackageSpawn;
                case "LogGameStatePeriodic": return T.LogGameStatePeriodic;
                case "LogItemAttach": return T.LogItemAttach;
                case "LogItemDetach": return T.LogItemDetach;
                case "LogItemDrop": return T.LogItemDrop;
                case "LogItemEquip": return T.LogItemEquip;
                case "LogItemPickup": return T.LogItemPickup;
                case "LogItemUnequip": return T.LogItemUnequip;
                case "LogItemUse": return T.LogItemUse;
                case "LogMatchDefinition": return T.LogMatchDefinition;
                case "LogMatchEnd": return T.LogMatchEnd;
                case "LogMatchStart": return T.LogMatchStart;
                case "LogPlayerAttack": return T.LogPlayerAttack;
                case "LogPlayerCreate": return T.LogPlayerCreate;
                case "LogPlayerKill": return T.LogPlayerKill;
                case "LogPlayerLogin": return T.LogPlayerLogin;
                case "LogPlayerLogout": return T.LogPlayerLogout;
                case "LogPlayerPosition": return T.LogPlayerPosition;
                case "LogPlayerTakeDamage": return T.LogPlayerTakeDamage;
                case "LogVehicleDestroy": return T.LogVehicleDestroy;
                case "LogVehicleLeave": return T.LogVehicleLeave;
                case "LogVehicleRide": return T.LogVehicleRide;
                default: return null;
            }
        }

        public static T ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this T value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case T.LogCarePackageLand:
                    serializer.Serialize(writer, "LogCarePackageLand");
                    break;
                case T.LogCarePackageSpawn:
                    serializer.Serialize(writer, "LogCarePackageSpawn");
                    break;
                case T.LogGameStatePeriodic:
                    serializer.Serialize(writer, "LogGameStatePeriodic");
                    break;
                case T.LogItemAttach:
                    serializer.Serialize(writer, "LogItemAttach");
                    break;
                case T.LogItemDetach:
                    serializer.Serialize(writer, "LogItemDetach");
                    break;
                case T.LogItemDrop:
                    serializer.Serialize(writer, "LogItemDrop");
                    break;
                case T.LogItemEquip:
                    serializer.Serialize(writer, "LogItemEquip");
                    break;
                case T.LogItemPickup:
                    serializer.Serialize(writer, "LogItemPickup");
                    break;
                case T.LogItemUnequip:
                    serializer.Serialize(writer, "LogItemUnequip");
                    break;
                case T.LogItemUse:
                    serializer.Serialize(writer, "LogItemUse");
                    break;
                case T.LogMatchDefinition:
                    serializer.Serialize(writer, "LogMatchDefinition");
                    break;
                case T.LogMatchEnd:
                    serializer.Serialize(writer, "LogMatchEnd");
                    break;
                case T.LogMatchStart:
                    serializer.Serialize(writer, "LogMatchStart");
                    break;
                case T.LogPlayerAttack:
                    serializer.Serialize(writer, "LogPlayerAttack");
                    break;
                case T.LogPlayerCreate:
                    serializer.Serialize(writer, "LogPlayerCreate");
                    break;
                case T.LogPlayerKill:
                    serializer.Serialize(writer, "LogPlayerKill");
                    break;
                case T.LogPlayerLogin:
                    serializer.Serialize(writer, "LogPlayerLogin");
                    break;
                case T.LogPlayerLogout:
                    serializer.Serialize(writer, "LogPlayerLogout");
                    break;
                case T.LogPlayerPosition:
                    serializer.Serialize(writer, "LogPlayerPosition");
                    break;
                case T.LogPlayerTakeDamage:
                    serializer.Serialize(writer, "LogPlayerTakeDamage");
                    break;
                case T.LogVehicleDestroy:
                    serializer.Serialize(writer, "LogVehicleDestroy");
                    break;
                case T.LogVehicleLeave:
                    serializer.Serialize(writer, "LogVehicleLeave");
                    break;
                case T.LogVehicleRide:
                    serializer.Serialize(writer, "LogVehicleRide");
                    break;
            }
        }
    }

    internal static class VehicleIdExtensions
    {
        public static VehicleId? ValueForString(string str)
        {
            switch (str)
            {
                case "BP_Motorbike_04_Desert_C": return VehicleId.BpMotorbike04_DesertC;
                case "BP_Motorbike_04_SideCar_Desert_C": return VehicleId.BpMotorbike04_SideCarDesertC;
                case "BP_PickupTruck_A_01_C": return VehicleId.BpPickupTruckA01_C;
                case "BP_PickupTruck_A_02_C": return VehicleId.BpPickupTruckA02_C;
                case "BP_PickupTruck_A_03_C": return VehicleId.BpPickupTruckA03_C;
                case "BP_PickupTruck_B_01_C": return VehicleId.BpPickupTruckB01_C;
                case "BP_PickupTruck_B_02_C": return VehicleId.BpPickupTruckB02_C;
                case "BP_PickupTruck_B_03_C": return VehicleId.BpPickupTruckB03_C;
                case "BP_Van_A_01_C": return VehicleId.BpVanA01_C;
                case "BP_Van_A_02_C": return VehicleId.BpVanA02_C;
                case "BP_Van_A_03_C": return VehicleId.BpVanA03_C;
                case "Buggy_A_04_C": return VehicleId.BuggyA04_C;
                case "Buggy_A_05_C": return VehicleId.BuggyA05_C;
                case "DummyTransportAircraft_C": return VehicleId.DummyTransportAircraftC;
                case "": return VehicleId.Empty;
                case "ParachutePlayer_C": return VehicleId.ParachutePlayerC;
                default: return null;
            }
        }

        public static VehicleId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this VehicleId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case VehicleId.BpMotorbike04_DesertC:
                    serializer.Serialize(writer, "BP_Motorbike_04_Desert_C");
                    break;
                case VehicleId.BpMotorbike04_SideCarDesertC:
                    serializer.Serialize(writer, "BP_Motorbike_04_SideCar_Desert_C");
                    break;
                case VehicleId.BpPickupTruckA01_C:
                    serializer.Serialize(writer, "BP_PickupTruck_A_01_C");
                    break;
                case VehicleId.BpPickupTruckA02_C:
                    serializer.Serialize(writer, "BP_PickupTruck_A_02_C");
                    break;
                case VehicleId.BpPickupTruckA03_C:
                    serializer.Serialize(writer, "BP_PickupTruck_A_03_C");
                    break;
                case VehicleId.BpPickupTruckB01_C:
                    serializer.Serialize(writer, "BP_PickupTruck_B_01_C");
                    break;
                case VehicleId.BpPickupTruckB02_C:
                    serializer.Serialize(writer, "BP_PickupTruck_B_02_C");
                    break;
                case VehicleId.BpPickupTruckB03_C:
                    serializer.Serialize(writer, "BP_PickupTruck_B_03_C");
                    break;
                case VehicleId.BpVanA01_C:
                    serializer.Serialize(writer, "BP_Van_A_01_C");
                    break;
                case VehicleId.BpVanA02_C:
                    serializer.Serialize(writer, "BP_Van_A_02_C");
                    break;
                case VehicleId.BpVanA03_C:
                    serializer.Serialize(writer, "BP_Van_A_03_C");
                    break;
                case VehicleId.BuggyA04_C:
                    serializer.Serialize(writer, "Buggy_A_04_C");
                    break;
                case VehicleId.BuggyA05_C:
                    serializer.Serialize(writer, "Buggy_A_05_C");
                    break;
                case VehicleId.DummyTransportAircraftC:
                    serializer.Serialize(writer, "DummyTransportAircraft_C");
                    break;
                case VehicleId.Empty:
                    serializer.Serialize(writer, "");
                    break;
                case VehicleId.ParachutePlayerC:
                    serializer.Serialize(writer, "ParachutePlayer_C");
                    break;
            }
        }
    }

    internal static class VehicleTypeExtensions
    {
        public static VehicleType? ValueForString(string str)
        {
            switch (str)
            {
                case "": return VehicleType.Empty;
                case "Parachute": return VehicleType.Parachute;
                case "TransportAircraft": return VehicleType.TransportAircraft;
                case "WheeledVehicle": return VehicleType.WheeledVehicle;
                default: return null;
            }
        }

        public static VehicleType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this VehicleType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case VehicleType.Empty:
                    serializer.Serialize(writer, "");
                    break;
                case VehicleType.Parachute:
                    serializer.Serialize(writer, "Parachute");
                    break;
                case VehicleType.TransportAircraft:
                    serializer.Serialize(writer, "TransportAircraft");
                    break;
                case VehicleType.WheeledVehicle:
                    serializer.Serialize(writer, "WheeledVehicle");
                    break;
            }
        }
    }

    public static class Serialize
    {
        public static string ToJson(this JTelemetry[] self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

    internal class Converter : JsonConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new Converter(),
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            }
        };

        public override bool CanConvert(Type t)
        {
            return t == typeof(AttackType) || t == typeof(AttachedItem) || t == typeof(Category) ||
                   t == typeof(ItemId) || t == typeof(SubCategory) || t == typeof(MapName) ||
                   t == typeof(DamageCauserName) || t == typeof(DamageReason) || t == typeof(DamageTypeCategory) ||
                   t == typeof(ErrorMessage) || t == typeof(ItemPackageId) || t == typeof(T) ||
                   t == typeof(VehicleId) || t == typeof(VehicleType) || t == typeof(AttackType?) ||
                   t == typeof(AttachedItem?) || t == typeof(Category?) || t == typeof(ItemId?) ||
                   t == typeof(SubCategory?) || t == typeof(MapName?) || t == typeof(DamageCauserName?) ||
                   t == typeof(DamageReason?) || t == typeof(DamageTypeCategory?) || t == typeof(ErrorMessage?) ||
                   t == typeof(ItemPackageId?) || t == typeof(T?) || t == typeof(VehicleId?) ||
                   t == typeof(VehicleType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(AttackType))
                return AttackTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(AttachedItem))
                return AttachedItemExtensions.ReadJson(reader, serializer);
            if (t == typeof(Category))
                return CategoryExtensions.ReadJson(reader, serializer);
            if (t == typeof(ItemId))
                return ItemIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(SubCategory))
                return SubCategoryExtensions.ReadJson(reader, serializer);
            if (t == typeof(MapName))
                return MapNameExtensions.ReadJson(reader, serializer);
            if (t == typeof(DamageCauserName))
                return DamageCauserNameExtensions.ReadJson(reader, serializer);
            if (t == typeof(DamageReason))
                return DamageReasonExtensions.ReadJson(reader, serializer);
            if (t == typeof(DamageTypeCategory))
                return DamageTypeCategoryExtensions.ReadJson(reader, serializer);
            if (t == typeof(ErrorMessage))
                return ErrorMessageExtensions.ReadJson(reader, serializer);
            if (t == typeof(ItemPackageId))
                return ItemPackageIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(T))
                return TExtensions.ReadJson(reader, serializer);
            if (t == typeof(VehicleId))
                return VehicleIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(VehicleType))
                return VehicleTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(AttackType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return AttackTypeExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(AttachedItem?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return AttachedItemExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(Category?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return CategoryExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(ItemId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ItemIdExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(SubCategory?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return SubCategoryExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(MapName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return MapNameExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(DamageCauserName?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DamageCauserNameExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(DamageReason?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DamageReasonExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(DamageTypeCategory?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DamageTypeCategoryExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(ErrorMessage?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ErrorMessageExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(ItemPackageId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ItemPackageIdExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(T?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return TExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(VehicleId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return VehicleIdExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(VehicleType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return VehicleTypeExtensions.ReadJson(reader, serializer);
            }

            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(AttackType))
            {
                ((AttackType) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(AttachedItem))
            {
                ((AttachedItem) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(Category))
            {
                ((Category) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(ItemId))
            {
                ((ItemId) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(SubCategory))
            {
                ((SubCategory) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(MapName))
            {
                ((MapName) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(DamageCauserName))
            {
                ((DamageCauserName) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(DamageReason))
            {
                ((DamageReason) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(DamageTypeCategory))
            {
                ((DamageTypeCategory) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(ErrorMessage))
            {
                ((ErrorMessage) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(ItemPackageId))
            {
                ((ItemPackageId) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(T))
            {
                ((T) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(VehicleId))
            {
                ((VehicleId) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(VehicleType))
            {
                ((VehicleType) value).WriteJson(writer, serializer);
                return;
            }

            throw new Exception("Unknown type");
        }
    }
}