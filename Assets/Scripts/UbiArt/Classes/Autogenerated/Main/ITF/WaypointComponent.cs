using UnityEngine;

namespace UbiArt.ITF {
	public partial class WaypointComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x165BA635;
	}
}

