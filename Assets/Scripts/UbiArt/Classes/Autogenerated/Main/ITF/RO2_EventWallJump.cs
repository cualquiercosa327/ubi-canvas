using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventWallJump : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x46CC1AB6;
	}
}

