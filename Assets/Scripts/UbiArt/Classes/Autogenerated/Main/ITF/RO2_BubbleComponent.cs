using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BubbleComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x42507D5F;
	}
}

