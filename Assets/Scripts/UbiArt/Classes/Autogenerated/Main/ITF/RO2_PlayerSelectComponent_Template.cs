using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerSelectComponent_Template : ShapeComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x612471DD;
	}
}

