using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDlcStatusChanged : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8D55C6C2;
	}
}

