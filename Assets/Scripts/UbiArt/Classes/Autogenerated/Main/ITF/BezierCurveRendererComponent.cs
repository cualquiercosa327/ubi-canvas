using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierCurveRendererComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x71887BA7;
	}
}

