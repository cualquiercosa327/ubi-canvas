using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventAnimUpdated : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x85E40D29;
	}
}

