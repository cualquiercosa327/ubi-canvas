using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionShootingRange_Template : RO2_BTActionRangedAttack_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4C0ABEAB;
	}
}

