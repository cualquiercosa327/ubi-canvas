using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysShapePolyline : PhysShape {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF5A6E50F;
	}
}

