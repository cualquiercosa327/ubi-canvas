using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryFloatInput : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC37E6D09;
	}
}

