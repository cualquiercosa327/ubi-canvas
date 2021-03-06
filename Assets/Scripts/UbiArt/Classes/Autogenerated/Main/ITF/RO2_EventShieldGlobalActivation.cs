using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventShieldGlobalActivation : Event {
		[Serialize("activation")] public bool activation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activation));
		}
		public override uint? ClassCRC => 0x5B896E39;
	}
}

