using UnityEngine;

namespace UbiArt.ITF {
	public partial class DeathTriggerComponent_Template : TriggerComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF2356402;
	}
}

