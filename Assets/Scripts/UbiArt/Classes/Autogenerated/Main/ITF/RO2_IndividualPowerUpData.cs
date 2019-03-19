using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_IndividualPowerUpData : RO2_BasicPowerUpData {
		[Serialize("enabled"     )] public int enabled;
		[Serialize("toAllPlayers")] public int toAllPlayers;
		[Serialize("index"       )] public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(enabled));
				SerializeField(s, nameof(toAllPlayers));
				SerializeField(s, nameof(index));
			} else {
			}
		}
		public override uint? ClassCRC => 0x97738B72;
	}
}
