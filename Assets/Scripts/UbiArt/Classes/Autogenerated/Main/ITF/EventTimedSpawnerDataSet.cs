using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventTimedSpawnerDataSet : Event {
		[Serialize("spawnDelay"        )] public float spawnDelay;
		[Serialize("spawnRate"         )] public float spawnRate;
		[Serialize("burstElementsCount")] public int burstElementsCount;
		[Serialize("burstCount"        )] public int burstCount;
		[Serialize("burstDelay"        )] public float burstDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnDelay));
			SerializeField(s, nameof(spawnRate));
			SerializeField(s, nameof(burstElementsCount));
			SerializeField(s, nameof(burstCount));
			SerializeField(s, nameof(burstDelay));
		}
		public override uint? ClassCRC => 0x19FE4D74;
	}
}

