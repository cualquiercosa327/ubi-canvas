using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventCommandAttackStop : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x80974784;
	}
}

