using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SeekingJellyfishAIComponent : ActorComponent {
		[Serialize("autoStart")] public bool autoStart;
		[Serialize("autoStart")] public byte autoStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(autoStart));
				}
				SerializeField(s, nameof(autoStart));
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(autoStart));
				}
			}
		}
		public override uint? ClassCRC => 0xB7E47051;
	}
}

