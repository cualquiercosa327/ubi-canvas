using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventQueryHeartNeeded : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD6B7B7EF;
	}
}

