using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossBirdPawnComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x61B89524;
	}
}

