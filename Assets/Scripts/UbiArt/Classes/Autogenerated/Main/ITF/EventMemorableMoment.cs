using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventMemorableMoment : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x453FBEFF;
	}
}

