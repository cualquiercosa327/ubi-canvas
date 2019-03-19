using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class AnimPartitionEvent : AnimMarkerEvent {
		[Serialize("name"    )] public StringID name;
		[Serialize("posLocal")] public Vector2 posLocal;
		[Serialize("sender"  )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(posLocal));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(posLocal));
			} else {
			}
		}
		public override uint? ClassCRC => 0xC301A504;
	}
}

