using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_RubyComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x60B45BAC;
	}
}

