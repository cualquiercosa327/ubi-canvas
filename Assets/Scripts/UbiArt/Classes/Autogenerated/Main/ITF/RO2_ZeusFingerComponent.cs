using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ZeusFingerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD078669E;
	}
}

