using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicScoreAIBranchComponent : RO2_BezierBranchComponent {
		[Serialize("startOpen")] public bool startOpen;
		[Serialize("startOpen")] public byte startOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(startOpen));
				}
				SerializeField(s, nameof(startOpen));
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(startOpen));
				}
			}
		}
		public override uint? ClassCRC => 0xDB2FA652;
	}
}

