using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchWeightComponent : BezierBranchComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF1B68D9D;
	}
}

