using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventSpawnReward : Event {
		[Serialize("numRewards"          )] public uint numRewards;
		[Serialize("autoPickup"          )] public int autoPickup;
		[Serialize("ejectionRandomForce" )] public float ejectionRandomForce;
		[Serialize("ejectionRandomAngle" )] public Angle ejectionRandomAngle;
		[Serialize("ejectionDuration"    )] public float ejectionDuration;
		[Serialize("ejectionForce"       )] public float ejectionForce;
		[Serialize("ejectionGravityAngle")] public Angle ejectionGravityAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(numRewards));
			SerializeField(s, nameof(autoPickup));
			SerializeField(s, nameof(ejectionRandomForce));
			SerializeField(s, nameof(ejectionRandomAngle));
			SerializeField(s, nameof(ejectionDuration));
			SerializeField(s, nameof(ejectionForce));
			SerializeField(s, nameof(ejectionGravityAngle));
		}
		public override uint? ClassCRC => 0x08ACF93F;
	}
}

