using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GameModeParameters : GameModeParameters {
		[Serialize("gameMode")] public GameMode gameMode;
		[Serialize("gameMode")] public GameMode2 gameMode2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(gameMode2));
			} else {
				SerializeField(s, nameof(gameMode));
			}
		}
		public enum GameMode {
			[Serialize("GAMEMODE_UNKNOWN"       )] GAMEMODE_UNKNOWN = -1,
			[Serialize("RO2_GAMEMODE_PLATFORMER")] RO2_GAMEMODE_PLATFORMER = 0,
			[Serialize("RO2_GAMEMODE_DUCK"      )] RO2_GAMEMODE_DUCK = 1,
		}
		public enum GameMode2 {
			[Serialize("GAMEMODE_UNKNOWN"       )] GAMEMODE_UNKNOWN = -1,
			[Serialize("RO2_GAMEMODE_PLATFORMER")] RO2_GAMEMODE_PLATFORMER = 0,
			[Serialize("RO2_GAMEMODE_DUCK"      )] RO2_GAMEMODE_DUCK = 1,
			[Serialize("RO2_GAMEMODE_2"         )] RO2_GAMEMODE_2 = 2,
		}
		public override uint? ClassCRC => 0xC1686E68;
	}
}

