using UnityEngine;

namespace UbiArt.ITF {
	public partial class EmitLifeTimeCurve : ParCurve {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x746D3E66;
	}
}

