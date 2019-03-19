using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class SoundComponent : ActorComponent {
		[Serialize("soundList")] public CList<SoundDescriptor_Template> soundList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
			} else {
				SerializeField(s, nameof(soundList));
			}
		}
		public override uint? ClassCRC => 0x7DD8643C;
	}
}

