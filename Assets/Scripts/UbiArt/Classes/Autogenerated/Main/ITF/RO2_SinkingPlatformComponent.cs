using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SinkingPlatformComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4B0813EC;
	}
}

