using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterStatsDebugComponent : CSerializable {
		[Serialize("playerLevel"      )] public uint playerLevel;
		[Serialize("refillHPOnLevelUp")] public bool refillHPOnLevelUp;
		[Serialize("refillMPOnLevelUp")] public int refillMPOnLevelUp;
		[Serialize("refillMPOnLevelUp")] public byte refillMPOnLevelUp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(playerLevel));
				SerializeField(s, nameof(refillHPOnLevelUp), boolAsByte: true);
				SerializeField(s, nameof(refillMPOnLevelUp));
			}
			SerializeField(s, nameof(refillMPOnLevelUp));
		}
		public override uint? ClassCRC => 0x0E325A03;
	}
}

