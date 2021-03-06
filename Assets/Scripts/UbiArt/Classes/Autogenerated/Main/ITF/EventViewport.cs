using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventViewport : Event {
		[Serialize("activated")] public bool activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activated));
		}
		public override uint? ClassCRC => 0x8386BA64;
	}
}

