using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SwarmChaseAIComponent : RO2_AIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF990713F;
	}
}

