using UnityEngine;

namespace UbiArt.ITF {
	public partial class FlexMeshComponent : GraphicComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x010345B7;
	}
}

