using UnityEngine;

namespace UbiArt.ITF {
	public partial class LogisticParams : BaseCurveParams {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF35691F8;
	}
}

