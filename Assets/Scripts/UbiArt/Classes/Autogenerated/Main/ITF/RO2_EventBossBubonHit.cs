using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventBossBubonHit : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x03B82BF1;
	}
}

