using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTapInteraction : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF51AA8A7;
	}
}

