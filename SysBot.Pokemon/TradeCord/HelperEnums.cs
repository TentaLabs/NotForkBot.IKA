﻿namespace SysBot.Pokemon;

public enum GenderDependent : ushort
{
    Venusaur = 3,
    Butterfree = 12,
    Rattata = 19,
    Raticate = 20,
    Pikachu = 25,
    Raichu = 26,
    Zubat = 41,
    Golbat = 42,
    Gloom = 44,
    Vileplume = 45,
    Kadabra = 64,
    Alakazam = 65,
    Doduo = 84,
    Dodrio = 85,
    Hypno = 97,
    Rhyhorn = 111,
    Rhydon = 112,
    Goldeen = 118,
    Seaking = 119,
    Scyther = 123,
    Magikarp = 129,
    Gyarados = 130,
    Eevee = 133,
    Meganium = 154,
    Ledyba = 165,
    Ledian = 166,
    Xatu = 178,
    Sudowoodo = 185,
    Politoed = 186,
    Aipom = 190,
    Wooper = 194,
    Quagsire = 195,
    Murkrow = 198,
    Wobbuffet = 202,
    Girafarig = 203,
    Gligar = 207,
    Steelix = 208,
    Scizor = 212,
    Heracross = 214,
    Sneasel = 215,
    Ursaring = 217,
    Piloswine = 221,
    Octillery = 224,
    Houndoom = 229,
    Donphan = 232,
    Torchic = 255,
    Combusken = 256,
    Blaziken = 257,
    Beautifly = 267,
    Dustox = 269,
    Ludicolo = 272,
    Nuzleaf = 274,
    Shiftry = 275,
    Meditite = 307,
    Medicham = 308,
    Roselia = 315,
    Gulpin = 316,
    Swalot = 317,
    Numel = 322,
    Camerupt = 323,
    Cacturne = 332,
    Milotic = 350,
    Relicanth = 369,
    Starly = 396,
    Staravia = 397,
    Staraptor = 398,
    Bidoof = 399,
    Bibarel = 400,
    Kricketot = 401,
    Kricketune = 402,
    Shinx = 403,
    Luxio = 404,
    Luxray = 405,
    Roserade = 407,
    Combee = 415,
    Pachirisu = 417,
    Floatzel = 418,
    Buizel = 419,
    Ambipom = 424,
    Gible = 443,
    Gabite = 444,
    Garchomp = 445,
    Hippopotas = 449,
    Hippowdon = 450,
    Croagunk = 453,
    Toxicroak = 454,
    Finneon = 456,
    Lumineon = 457,
    Snover = 459,
    Abomasnow = 460,
    Weavile = 461,
    Rhyperior = 464,
    Tangrowth = 465,
    Mamoswine = 473,
    Unfezant = 521,
    Frillish = 592,
    Jellicent = 593,
    Pyroar = 668,
}

public enum GreatMarsh : ushort
{
    Paras = 46,
    Golduck = 55,
    Exeggcute = 102,
    Kangaskhan = 115,
    Yanma = 193,
    Shroomish = 285,
    Roselia = 315,
    Gulpin = 316,
    Staravia = 397,
    Skorupi = 451,
    Drapion = 452,
    Croagunk = 453,
    Toxicroak = 454,
    Carnivine = 455,
}

public enum DexPerks : ushort
{
    CatchBoost = 0,
    EggRateBoost = 1,
    ShinyBoost = 2,
    SpeciesBoost = 3,
    GmaxBoost = 4,
    CherishBoost = 5,
    ItemBoost = 6,
}

public enum Halloween : ushort
{
    Zubat = 41,
    Golbat = 42,
    Gastly = 92,
    Haunter = 93,
    Gengar = 94,
    Cubone = 104,
    Marowak = 105,
    MrMime = 122,
    Ditto = 132,
    Moltres = 146,
    Spinarak = 167,
    Ariados = 168,
    Crobat = 169,
    Umbreon = 197,
    Murkrow = 198,
    Misdreavus = 200,
    Unown = 201,
    Girafarig = 203,
    Gligar = 207,
    Corsola = 222,
    Houndour = 228,
    Houndoom = 229,
    Poochyena = 261,
    Mightyena = 262,
    Shedinja = 292,
    Sableye = 302,
    Mawile = 303,
    Cacnea = 331,
    Cacturne = 332,
    Shuppet = 353,
    Banette = 354,
    Duskull = 355,
    Dusclops = 356,
    Drifloon = 425,
    Drifblim = 426,
    Mismagius = 429,
    Honchkrow = 430,
    Spiritomb = 442,
    Carnivine = 455,
    Gliscor = 472,
    Dusknoir = 477,
    Froslass = 478,
    Rotom = 479,
    Giratina = 487,
    Darkrai = 491,
    Yamask = 562,
    Cofagrigus = 563,
    Zorua = 570,
    Zoroark = 571,
    Litwick = 607,
    Lampent = 608,
    Chandelure = 609,
    Golett = 622,
    Golurk = 623,
    Deino = 633,
    Zweilous = 634,
    Hydreigon = 635,
    Honedge = 679,
    Doublade = 680,
    Aegislash = 681,
    Phantump = 708,
    Trevenant = 709,
    Pumpkaboo = 710,
    Gourgeist = 711,
    Yveltal = 717,
    Decidueye = 724,
    Incineroar = 727,
    Sandygast = 769,
    Palossand = 770,
    Mimikyu = 778,
    Dhelmise = 781,
    Lunala = 792,
    Guzzlord = 799,
    Marshadow = 802,
    Blacephalon = 806,
    Sinistea = 854,
    Polteageist = 855,
    Impidimp = 859,
    Morgrem = 860,
    Grimmsnarl = 861,
    Cursola = 864,
    Runerigus = 867,
    Dreepy = 885,
    Drakloak = 886,
    Dragapult = 887,
    Eternatus = 890,
    Spectrier = 897,
    Meowscarada = 908,
    Skeledirge = 911,
    Quaquaval = 914,
    Ceruledge = 937,
    Annihilape = 979,

}

public enum PokePets : ushort
{
    Pidgey = 16,
    Pidgeotto = 17,
    Pidgeot = 18,
    Rattata = 19,
    Raticate = 20,
    Ekans = 23,
    Arbok = 24,
    Pikachu = 25,
    Vulpix = 37,
    Ninetales = 38,
    Meowth = 52,
    Persian = 53,
    Growlithe = 58,
    Arcanine = 59,
    Ponyta = 77,
    Rapidash = 78,
    Goldeen = 118,
    Seaking = 119,
    Tauros = 128,
    Magikarp = 129,
    Eevee = 133,
    Vaporeon = 134,
    Jolteon = 135,
    Flareon = 136,
    Snorlax = 143,
    Mewtwo = 150,
    Mew = 151,
    Furret = 162,
    Mareep = 179,
    Espeon = 196,
    Umbreon = 197,
    Murkrow = 198,
    Snubbull = 209,
    Granbull = 210,
    Teddiursa = 216,
    Ursaring = 217,
    Houndour = 228,
    Houndoom = 229,
    Miltank = 241,
    Raikou = 243,
    Entei = 244,
    Suicune = 245,
    Poochyena = 261,
    Mightyena = 262,
    Zigzagoon = 263,
    Linoone = 264,
    Skitty = 300,
    Delcatty = 301,
    Electrike = 309,
    Manectric = 310,
    Plusle = 311,
    Minun = 312,
    Zangoose = 335,
    Seviper = 336,
    Feebas = 349,
    Turtwig = 387,
    Chimchar = 390,
    Piplup = 393,
    Pachirisu = 417,
    Buneary = 427,
    Honchkrow = 430,
    Glameow = 431,
    Purugly = 432,
    Chatot = 441,
    Munchlax = 446,
    Riolu = 447,
    Lucario = 448,
    Leafeon = 470,
    Glaceon = 471,
    Shaymin = 492,
    Purrloin = 509,
    Liepard = 510,
    Cubchoo = 613,
    Beartic = 614,
    Bunnelby = 659,
    Pancham = 674,
    Pangoro = 675,
    Espurr = 677,
    Meowstic = 678,
    Swirlix = 684,
    Sylveon = 700,
    Dedenne = 702,
    Litten = 725,
    Rockruff = 744,
    Lycanroc = 745,
    Stufful = 759,
    Bewear = 760,
    Solgaleo = 791,
    Scorbunny = 813,
    Rookidee = 821,
    Nickit = 827,
    Thievul = 828,
    Yamper = 835,
    Boltund = 836,
    Silicobra = 843,
    Obstagoon = 862,
    Perrserker = 863,
    Morpeko = 877,
    Zacian = 888,
    Zamazenta = 889,
    Kubfu = 891,
    Urshifu = 892,
}

public enum RodentLite : ushort
{
    Rattata = 19,
    Raticate = 20,
    Pikachu = 25,
    Raichu = 26,
    Sandshrew = 27,
    Sandslash = 28,
    NidoranF = 29,
    Nidorina = 30,
    NidoranM = 32,
    Nidorino = 33,
    Diglett = 50,
    Dugtrio = 51,
    Pichu = 172,
    Marill = 183,
    Zigzagoon = 263,
    Linoone = 264,
    Azurill = 298,
    Plusle = 311,
    Minun = 312,
    Bidoof = 399,
    Bibarel = 400,
    Pachirisu = 417,
    Buizel = 418,
    Floatzel = 419,
    Buneary = 427,
    Lopunny = 428,
    Stunky = 434,
    Skunktank = 435,
    Shaymin = 492,
    Drilbur = 529,
    Excadrill = 530,
    Minccino = 572,
    Cinccino = 573,
    Emolga = 587,
    Bunnelby = 659,
    Diggersby = 660,
    Dedenne = 702,
    Togedemaru = 777,
    Mimikyu = 778,
    Skwovet = 819,
    Greedent = 820,
    Morpeko = 877,
}

public enum Clickbait : ushort
{
    Venusaur = 3,
    Charizard = 6,
    Blastoise = 9,
    Pikachu = 25,
    Ninetales = 38,
    Magnemite = 81,
    Gengar = 94,
    Magikarp = 129,
    Gyarados = 130,
    Lapras = 131,
    Ditto = 132,
    Eevee = 133,
    Snorlax = 143,
    Mewtwo = 150,
    Mew = 151,
    Meganium = 154,
    Typhlosion = 157,
    Feraligatr = 160,
    Tyranitar = 248,
    Lugia = 249,
    Gardevoir = 282,
    Sableye = 302,
    Flygon = 330,
    Spheal = 363,
    Rayquaza = 384,
    Jirachi = 385,
    Torterra = 389,
    Infernape = 392,
    Empoleon = 395,
    Bidoof = 399,
    Luxray = 405,
    Pachirisu = 417,
    Lopunny = 428,
    Garchomp = 445,
    Lucario = 448,
    Phione = 489,
    Manaphy = 490,
    Darkrai = 491,
    Shaymin = 492,
    Arceus = 493,
    Scolipede = 545,
    Lilligant = 549,
    Cinccino = 573,
    Chandelure = 609,
    Barbaracle = 689,
    Dedenne = 702,
    Sliggoo = 705,
    Mimikyu = 778,
    Buzzwole = 794,
    Rillaboom = 812,
    Cinderace = 815,
    Inteleon = 818,
    Toxtricity = 849,
    Dragapult = 887,
}

public enum HouseParty : ushort
{
    Rattata = 19,
    Raticate = 20,
    Pikachu = 25,
    Raichu = 26,
    Sandshrew = 27,
    Sandslash = 28,
    Vulpix = 37,
    Ninetales = 38,
    Diglett = 50,
    Dugtrio = 51,
    Meowth = 52,
    Persian = 53,
    Growlithe = 58,
    Arcanine = 59,
    Geodude = 74,
    Graveler = 75,
    Golem = 76,
    Ponyta = 77,
    Rapidash = 78,
    Slowpoke = 79,
    Slowbro = 80,
    Farfetchd = 83,
    Grimer = 88,
    Muk = 89,
    Voltorb = 100,
    Electrode = 101,
    Exeggutor = 103,
    Marowak = 105,
    Weezing = 110,
    MrMime = 122,
    Tauros = 128,
    Articuno = 144,
    Zapdos = 145,
    Moltres = 146,
    Typhlosion = 157,
    Wooper = 194,
    Slowking = 199,
    Unown = 201,
    Qwilfish = 211,
    Sneasel = 215,
    Corsola = 222,
    Zigzagoon = 263,
    Linoone = 264,
    Castform = 351,
    Kyogre = 382,
    Groudon = 383,
    Rayquaza = 384,
    Deoxys = 386,
    Burmy = 412,
    Wormadam = 413,
    Cherrim = 421,
    Shellos = 422,
    Gastrodon = 423,
    Rotom = 479,
    Dialga = 483,
    Palkia = 484,
    Giratina = 487,
    Shaymin = 492,
    Arceus = 493,
    Samurott = 503,
    Lilligant = 549,
    Basculin = 550,
    Darumaka = 554,
    Darmanitan = 555,
    Yamask = 562,
    Zorua = 570,
    Zoroark = 571,
    Deerling = 585,
    Sawsbuck = 586,
    Stunfisk = 618,
    Braviary = 628,
    Tornadus = 641,
    Thundurus = 642,
    Landorus = 645,
    Genesect = 649,
    Greninja = 658,
    Vivillon = 666,
    Flabébé = 669,
    Floette = 670,
    Florges = 671,
    Furfrou = 676,
    Sliggoo = 705,
    Goodra = 706,
    Avalugg = 713,
    Decidueye = 724,
    Oricorio = 741,
    Lycanroc = 745,
    Silvally = 773,
    Sinistea = 854,
    Alcremie = 869,
    Enamorus = 905,
    Maushold = 925,
    Squawkabilly = 931,
    Palafin = 964,
    Tatsugiri = 978,
    Dudunsparce = 982,
}

public enum Paradox : ushort
{
    Jigglypuff = 39,
    Magneton = 82,
    Misdreavus = 200,
    Delibird = 225,
    Donphan = 232,
    Tyranitar = 248,
    Gardevoir = 282,
    Hariyama = 297,
    Salamence = 373,
    Gallade = 475,
    Amoonguss = 591,
    Hydreigon = 635,
    Volcarona = 637,
    Cobalion = 638,
    Terrakion = 639,
    Virizion = 640,
    Cyclizar = 967,
    GreatTusk = 984,
    ScreamTail = 985,
    BruteBonnet = 986,
    FlutterMane = 987,
    SlitherWing = 988,
    SandyShocks = 989,
    IronTreads = 990,
    IronBundle = 991,
    IronHands = 992,
    IronJugulis = 993,
    IronMoth = 994,
    IronThorns = 995,
    RoaringMoon = 1005,
    IronValiant = 1006,
    Koraidon = 1007,
    Miraidon = 1008,
    WalkingWake = 1009,
    IronLeaves = 1010,
    GougingFire = 1020,
    RagingBolt = 1021,
    IronBoulder = 1022,
    IronCrown = 1023,
}

public enum FroggyFrenzy : ushort
{
    Bulbasaur = 1,
    Ivysaur = 2,
    Venusaur = 3,
    Poliwag = 60,
    Poliwhirl = 61,
    Poliwrath = 62,
    Politoed = 186,
    Croagunk = 453,
    Toxicroak = 454,
    Tympole = 535,
    Palpitoad = 536,
    Seismitoad = 537,
    Froakie = 656,
    Frogadier = 657,
    Greninja = 658,
    Tadbulb = 938,
    Bellibolt = 939,
}

public enum Anonymyths : ushort
{
    Oddish = 43,
    Gloom = 44,
    Vileplume = 45,
    Psyduck = 54,
    Golduck = 55,
    Poliwag = 60,
    Poliwhirl = 61,
    Poliwrath = 62,
    Gastly = 92,
    Haunter = 93,
    Gengar = 94,
    Magikarp = 129,
    Gyarados = 130,
    Totodile = 158,
    Croconaw = 159,
    Feraligatr = 160,
    Mudkip = 258,
    Marshtomp = 259,
    Swampert = 260,
    Ralts = 280,
    Kirlia = 281,
    Gardevoir = 282,
    Tropius = 357,
    Cranidos = 408,
    Rampardos = 409,
    Timburr = 534,
    Gurdurr = 535,
    Conkeldurr = 536,
    Litwick = 607,
    Lampent = 608,
    Chandelure = 609,
    Fennekin = 653,
    Braixen = 654,
    Delphox = 655,
    Salandit = 757,
    Salazzle = 758,
    Scorbunny = 813,
    Raboot = 814,
    Cinderace = 815,
    Sinistea = 854,
    Polteageist = 855,
    Sinistcha = 1013,
    Poltchageist = 1012,
    IronThorns = 995,
    Capsakid = 951,
    Scovillain = 952,
    Tadbulb = 938,
    Bellibolt = 939,
    Fidough = 926,
    Dachsbun = 927,
    Cyclizar = 967,
    Sprigatito = 906,
    Floragato = 907,
    Meowscarada = 908,
    Fuecoco = 909,
    Crocalor = 910,
    Skeledirge = 911,
    Quaxly = 912,
    Quaxwell = 913,
    Quaquaval = 914,
    Pawmi = 921,
    Pawmo = 922,
    Pawmot = 923,
    Larvitar = 246,
    Pupitar = 247,
    Tyranitar = 248,
    Smeargle = 234,
    Eevee = 133,
    Vaporeon = 134,
    Jolteon = 135,
    Flareon = 136,
    Espeon = 196,
    Umbreon = 197,
    Leafeon = 470,
    Glaceon = 471,
    Sylveon = 700,
}

public enum TCCommandContext
{
    Catch,
    Trade,
    Gift,
    Info,
    List,
    Release,
    MassRelease,
    TrainerInfo,
    TrainerInfoSet,
    Dex,
    Perks,
    Boost,
    DaycareInfo,
    Daycare,
    FavoritesInfo,
    Favorites,
    Buddy,
    Nickname,
    Evolution,
    GiveItem,
    GiftItem,
    TakeItem,
    ItemList,
    DropItem,
    TimeZone,
    DeleteUser,
    EventVote,
    EventPing,
}

public enum TCItems
{
    // Hack
    MarkCharm = -3,
    ShinyCharm = -2,
    Sweets = -1,

    // Evolution items
    None = 0,
    SunStone = 80,
    MoonStone = 81,
    FireStone = 82,
    ThunderStone = 83,
    WaterStone = 84,
    LeafStone = 85,
    ShinyStone = 107,
    DuskStone = 108,
    DawnStone = 109,
    OvalStone = 110,
    GriseousOrb = 112,
    SootheBell = 218,
    KingsRock = 221,

    // Not available in SWSH
    DeepSeaTooth = 226,
    DeepSeaScale = 227,
    //

    Everstone = 229,
    MetalCoat = 233,
    DragonScale = 235,
    Upgrade = 252,
    Protector = 321,
    Electirizer = 322,
    Magmarizer = 323,
    DubiousDisc = 324,
    ReaperCloth = 325,
    RazorClaw = 326,

    // Not available in BDSP
    PrismScale = 537,
    WhippedDream = 646,
    Sachet = 647,
    IceStone = 849,
    FightingMemory = 904,
    FlyingMemory = 905,
    PoisonMemory = 906,
    GroundMemory = 907,
    RockMemory = 908,
    BugMemory = 909,
    GhostMemory = 910,
    SteelMemory = 911,
    FireMemory = 912,
    WaterMemory = 913,
    GrassMemory = 914,
    ElectricMemory = 915,
    PsychicMemory = 916,
    IceMemory = 917,
    DragonMemory = 918,
    DarkMemory = 919,
    FairyMemory = 920,
    StrawberrySweet = 1109,
    BerrySweet = 1111,
    LoveSweet = 1110,
    StarSweet = 1114,
    CloverSweet = 1112,
    FlowerSweet = 1113,
    RibbonSweet = 1115,
    SweetApple = 1116,
    TartApple = 1117,
    CrackedPot = 1253,
    ChippedPot = 1254,
    GalaricaCuff = 1582,
    GalaricaWreath = 1592,
    PeatBlock = 1692,
    GriseousCore = 1779,
    MaliciousArmor = 1861,
    GimmighoulCoin = 2137,
    AuspiciousArmor = 2344,
    LeadersCrest = 2345,
    SyrupyApple = 2402,
    UnremarkableTeacup = 2403,
    MasterpieceTeacup = 2404,
    MetalAlloy = 2482,
}

public enum AlcremieForms
{
    None = -1,
    VanillaCream = 0,
    RubyCream = 1,
    MatchaCream = 2,
    MintCream = 3,
    LemonCream = 4,
    SaltedCream = 5,
    RubySwirl = 6,
    CaramelSwirl = 7,
    RainbowSwirl = 8,
}

public enum RegionalFormArgument
{
    None = -1,
    Kanto = 0,
    Alola = 1,
    Galar = 2,
    Hisui = 3,
    Paldea = 4,
}

public enum TimeOfDay
{
    Any,
    Dawn,
    Morning,
    Day,
    Dusk,
    Night,
}

public enum TableEnum
{
    Users = 0,
    TrainerInfo = 1,
    Dex = 2,
    Perks = 3,
    Daycare = 4,
    Buddy = 5,
    Items = 6,
    Catches = 7,
}

public enum SQLTableContext
{
    Select,
    Update,
    Insert,
    Delete,
}

public enum CurryBerries
{
    Starf = 207,
    Enigma = 208,
    Micle = 209,
    Custap = 210,
    Jaboca = 211,
    Rowap = 212,
}

public enum CurryIngredients
{
    SmokePokeTail = 1091,
    LargeLeek = 1092,
    FancyApple = 1093,
    BoiledEgg = 1099,
    FruitBunch = 1256,
    MoomooCheese = 1257,
    Gigantamix = 1264,
}

public enum DisplayMode
{
    Everything,
    Baby,
    Adult,
}

public enum PicnicFillings
{
    None = 0,
    Lettuce = 1909,
    Tomato = 1910,
    CherryTomatoes = 1911,
    Cucumber = 1912,
    Pickle = 1913,
    Onion = 1914,
    RedOnion = 1915,
    GreenBellPepper = 1916,
    RedBellPepper = 1917,
    YellowBellPepper = 1918,
    Avocado = 1919,
    Bacon = 1920,
    Ham = 1921,
    Prosciutto = 1922,
    Chorizo = 1923,
    HerbedSausage = 1924,
    Hamburger = 1925,
    KlawfStick = 1926,
    SmokedFillet = 1927,
    FriedFillet = 1928,
    Egg = 1929,
    PotatoTortilla = 1930,
    Tofu = 1931,
    Rice = 1932,
    Noodles = 1933,
    PotatoSalad = 1934,
    Cheese = 1935,
    Banana = 1936,
    Strawberry = 1937,
    Apple = 1938,
    Kiwi = 1939,
    Pineapple = 1940,
    Jalapeno = 1941,
    Watercress = 1945,
    Basil = 1946,
}

public enum PicnicCondiments
{
    None = 0,
    Mayonnaise = 1889,
    Ketchup = 1890,
    Mustard = 1891,
    Butter = 1892,
    PeanutButter = 1893,
    ChiliSauce = 1894,
    Salt = 1895,
    Pepper = 1896,
    Yogurt = 1897,
    WhippedCream = 1898,
    CreamCheese = 1899,
    Jam = 1900,
    Marmalade = 1901,
    OliveOil = 1902,
    Vinegar = 1903,
    SweetHerbaMystica = 1904,
    SaltyHerbaMystica = 1905,
    SourHerbaMystica = 1906,
    BitterHerbaMystica = 1907,
    SpicyHerbaMystica = 1908,
    HorseRadish = 1942,
    CurryPowder = 1943,
    Wasabi = 1944,
}

public enum SandwichSelection
{
    Normal = 0,
    Fire = 1,
    Water = 2,
    Grass = 3,
    Flying = 4,
    Fighting = 5,
    Poison = 6,
    Electric = 7,
    Ground = 8,
    Rock = 9,
    Psychic = 10,
    Ice = 11,
    Bug = 12,
    Ghost = 13,
    Steel = 14,
    Dragon = 15,
    Dark = 16,
    Fairy = 17,
    Custom = 18,
    NoSandwich = 19,
}

public enum SandwichFlavor
{
    Encounter = 0,
    Humongo = 1,
    Teensy = 2,
}
