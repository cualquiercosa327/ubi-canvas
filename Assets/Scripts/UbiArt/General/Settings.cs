﻿using System.Collections.Generic;

namespace UbiArt {
	public class Settings {
		public enum Mode {
			[System.ComponentModel.Description("Rayman Origins (PC)")] RaymanOriginsPC,
			[System.ComponentModel.Description("Rayman Legends (PC)")] RaymanLegendsPC,
			[System.ComponentModel.Description("Rayman Legends (PSV)")] RaymanLegendsVitaCatchThemAll,
			//RaymanAdventuresIOS,
			[System.ComponentModel.Description("Rayman Adventures (Android)")] RaymanAdventuresAndroid,
			[System.ComponentModel.Description("Rayman Mini (MacOS)")] RaymanMiniMacOS
		};
		public Mode mode = Mode.RaymanLegendsPC;


		public static Dictionary<string, Mode> cmdModeNameDict = new Dictionary<string, Mode>() {
			{ "ro_pc", Mode.RaymanOriginsPC },
			{ "rl_pc", Mode.RaymanLegendsPC },
			{ "rl_vita", Mode.RaymanLegendsVitaCatchThemAll },
			{ "ra_android", Mode.RaymanAdventuresAndroid },
			{ "rm_mac", Mode.RaymanMiniMacOS },
		};


		public enum EngineVersion {
			None = -1,
			RO = 0,
			RL = 1
		};
		public enum Game { None, RO, RL, RA, RJR, RFR, COL, VH };
		public enum Platform { None, PC, iOS, Android, WiiU, Vita, MacOS };
		public enum Endian { Little, Big };
		public enum SerializerType { Binary, TagBinary };

		public EngineVersion engineVersion;
		public Game game;
		public Platform platform;
		public Endian endian;
		public VersionFlags versionFlags;
		public SerializerType serializerType = SerializerType.Binary;
		public bool usesSerializeFlags = true;
		public bool isCatchThemAll = false;
		public bool cooked = true;

		public bool IsLittleEndian {
			get { return endian == Endian.Little; }
		}
		public string PlatformString {
			get {
				switch (platform) {
					case Platform.PC: return "pc";
					case Platform.Android: return "android";
					case Platform.MacOS: return "macos";
					default: return null;
				}
			}
		}
		public string ITFDirectory {
			get {
				if (cooked) {
					if (engineVersion > EngineVersion.RO) {
						return "cache/itf_cooked/" + PlatformString + "/";
					} else {
						return "itf_cooked/" + PlatformString + "/";
					}
				} else {
					return "";
				}
			}
		}

		public static void Init(Mode mode) {
			if (settingsDict.ContainsKey(mode)) {
				s = settingsDict[mode];
			}
			if (s != null) s.mode = mode;
		}


		public static Settings s = null;
		public static Settings ROPC = new Settings() {
			engineVersion = EngineVersion.RO,
			game = Game.RO,
			platform = Platform.PC,
			endian = Endian.Big,
			versionFlags = VersionFlags.Origins,
			usesSerializeFlags = false
		};
		public static Settings RLPC = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RL,
			platform = Platform.PC,
			endian = Endian.Big,
			versionFlags = VersionFlags.Legends
		};
		public static Settings RAIOS = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RA,
			platform = Platform.iOS,
			endian = Endian.Big,
			versionFlags = VersionFlags.Adventures,
			serializerType = SerializerType.TagBinary
		};
		public static Settings RAAndroid = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RA,
			platform = Platform.Android,
			endian = Endian.Big,
			versionFlags = VersionFlags.Adventures,
			serializerType = SerializerType.TagBinary
		};
		public static Settings RMMac = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RA,
			platform = Platform.MacOS,
			endian = Endian.Big,
			versionFlags = VersionFlags.Adventures,
			serializerType = SerializerType.TagBinary
		};
		public static Settings RLVita = new Settings() {
			engineVersion = EngineVersion.RL,
			game = Game.RL,
			platform = Platform.Vita,
			endian = Endian.Big,
			versionFlags = VersionFlags.Legends,
			isCatchThemAll = true
		};


		public static Dictionary<Mode, Settings> settingsDict = new Dictionary<Mode, Settings>() {
			{ Mode.RaymanOriginsPC, ROPC },
			{ Mode.RaymanLegendsPC, RLPC },
			{ Mode.RaymanLegendsVitaCatchThemAll, RLVita },
			{ Mode.RaymanAdventuresAndroid, RAAndroid },
			{ Mode.RaymanMiniMacOS, RMMac },
		};
	}
}