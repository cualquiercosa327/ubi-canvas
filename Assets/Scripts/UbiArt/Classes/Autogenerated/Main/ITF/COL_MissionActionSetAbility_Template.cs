using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionSetAbility_Template : CSerializable {
		[Description("Ability type to unlock")]
		[Serialize("abilityType")] public Enum_abilityType abilityType;
		[Serialize("unlock"     )] public bool unlock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(abilityType));
			SerializeField(s, nameof(unlock), boolAsByte: true);
		}
		public enum Enum_abilityType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public override uint? ClassCRC => 0xF2C69BB2;
	}
}

