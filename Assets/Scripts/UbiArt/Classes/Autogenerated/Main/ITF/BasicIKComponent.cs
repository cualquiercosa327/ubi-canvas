using UnityEngine;

namespace UbiArt.ITF {
	public partial class BasicIKComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x36F3A84C;
	}
}

