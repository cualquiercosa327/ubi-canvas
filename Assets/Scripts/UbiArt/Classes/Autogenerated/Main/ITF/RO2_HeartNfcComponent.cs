using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_HeartNfcComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x32B20E2E;
	}
}

