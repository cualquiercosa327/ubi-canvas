using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimState : State {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7DC6268C;
	}
}

