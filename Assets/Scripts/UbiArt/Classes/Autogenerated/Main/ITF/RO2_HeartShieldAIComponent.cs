using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_HeartShieldAIComponent : RO2_SimpleAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x970CD9D0;
	}
}

