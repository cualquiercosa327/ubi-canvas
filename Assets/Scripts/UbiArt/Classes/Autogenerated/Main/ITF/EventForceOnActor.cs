using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventForceOnActor : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0FF3C749;
	}
}

