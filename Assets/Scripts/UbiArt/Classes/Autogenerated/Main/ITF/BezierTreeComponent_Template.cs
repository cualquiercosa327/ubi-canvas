using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierTreeComponent_Template : BezierTree_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7C0C114C;
	}
}

