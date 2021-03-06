using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BlackSwarmRepellerAIComponent : ActorComponent {
		[Serialize("syncOffset"   )] public float syncOffset;
		[Serialize("radiusMax"    )] public float radiusMax;
		[Serialize("radiusMin"    )] public float radiusMin;
		[Serialize("cycleDuration")] public float cycleDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(syncOffset));
			SerializeField(s, nameof(radiusMax));
			SerializeField(s, nameof(radiusMin));
			SerializeField(s, nameof(cycleDuration));
		}
		public override uint? ClassCRC => 0x1FD07686;
	}
}

