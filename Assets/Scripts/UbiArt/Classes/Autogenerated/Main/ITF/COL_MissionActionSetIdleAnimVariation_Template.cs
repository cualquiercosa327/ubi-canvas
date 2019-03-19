using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionSetIdleAnimVariation_Template : CSerializable {
		[Description("Idle anim variation")]
		[Serialize("idleAnimVariation")] public Enum_idleAnimVariation idleAnimVariation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleAnimVariation));
		}
		public enum Enum_idleAnimVariation {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xA2CBD67E;
	}
}

