using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIGround_ReceiveNormalHitAction : RO2_AIGroundReceiveHitAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF7C6E6CC;
	}
}

