using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventTrajectorySpawn : Event {
		[Serialize("spawneeIndex")] public uint spawneeIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawneeIndex));
		}
		public override uint? ClassCRC => 0xE54BBD95;
	}
}

