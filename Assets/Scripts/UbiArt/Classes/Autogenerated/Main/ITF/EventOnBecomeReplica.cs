using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventOnBecomeReplica : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF7AE174B;
	}
}

