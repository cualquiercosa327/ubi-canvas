using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventPhysicsUpdated : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9CE64DCE;
	}
}

