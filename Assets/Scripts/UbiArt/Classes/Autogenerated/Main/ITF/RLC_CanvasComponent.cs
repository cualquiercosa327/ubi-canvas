using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_CanvasComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xED0F26C8;
	}
}

