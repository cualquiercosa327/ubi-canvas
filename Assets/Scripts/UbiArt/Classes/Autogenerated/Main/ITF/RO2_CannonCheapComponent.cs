using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CannonCheapComponent : RO2_AIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x590F2766;
	}
}

