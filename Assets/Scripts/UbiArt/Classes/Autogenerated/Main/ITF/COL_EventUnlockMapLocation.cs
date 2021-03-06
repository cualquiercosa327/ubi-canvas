using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventUnlockMapLocation : Event {
		[Serialize("mapLocationId")] public StringID mapLocationId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mapLocationId));
		}
		public override uint? ClassCRC => 0xA859529E;
	}
}

