using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIShooterStepDamageBehavior_Template : TemplateAIBehavior {
		[Serialize("stepDamageList")] public Placeholder stepDamageList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stepDamageList));
		}
		public override uint? ClassCRC => 0xA9B7DFCD;
	}
}

