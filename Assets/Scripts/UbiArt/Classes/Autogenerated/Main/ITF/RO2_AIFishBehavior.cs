using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIFishBehavior : RO2_AIGroundBaseBehavior {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0FB24A4A;
	}
}

