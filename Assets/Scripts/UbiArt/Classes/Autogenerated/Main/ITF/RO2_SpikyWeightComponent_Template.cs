using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SpikyWeightComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x30226668;
	}
}

