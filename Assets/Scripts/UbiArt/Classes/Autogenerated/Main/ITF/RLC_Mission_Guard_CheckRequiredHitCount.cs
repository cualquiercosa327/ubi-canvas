using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Mission_Guard_CheckRequiredHitCount : RLC_Mission_Guard {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC38D70CC;
	}
}

