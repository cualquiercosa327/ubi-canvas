using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FixedAIComponent : RO2_AIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8A711C28;
	}
}

