using UnityEngine;

namespace UbiArt.ITF {
	public partial class WindComponent : PhysForceModifierComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4FE542FF;
	}
}

