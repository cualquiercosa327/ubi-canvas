using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BTDelay : BTNode {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8C60A622;
	}
}

