using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryReadyForDialog : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7D02771F;
	}
}

