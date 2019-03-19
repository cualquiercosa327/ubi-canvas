using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventCameraIgnoreShake : Event {
		[Serialize("ignoreShake")] public bool ignoreShake;
		[Serialize("sender"     )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(ignoreShake));
			} else {
				SerializeField(s, nameof(ignoreShake));
			}
		}
		public override uint? ClassCRC => 0x6D2CA7CB;
	}
}

