using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterSpawnerComponent : TimedSpawnerComponent {
		[Serialize("tweenId"                    )] public Enum_RFR_0 tweenId;
		[Serialize("spawnActorId"               )] public Enum_RFR_1 spawnActorId;
		[Serialize("beforeCamRelativeInitialPos")] public Vector3 beforeCamRelativeInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenId));
			SerializeField(s, nameof(spawnActorId));
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
		}
		public enum Enum_RFR_0 {
			[Serialize("invalid")] invalid = -1,
		}
		public override uint? ClassCRC => 0xFFCF1689;
	}
}
