using UnityEngine;

namespace UbiArt.ITF {
	public partial class Phys3DComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFB9DE59A;
	}
}

