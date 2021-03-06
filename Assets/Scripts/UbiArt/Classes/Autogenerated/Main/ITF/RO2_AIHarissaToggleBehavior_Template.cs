using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIHarissaToggleBehavior_Template : TemplateAIBehavior {
		[Serialize("drcCollisionShape"          )] public Generic<PhysShape> drcCollisionShape;
		[Serialize("offAction"                  )] public Generic<AIAction_Template> offAction;
		[Serialize("onAction"                   )] public Generic<AIAction_Template> onAction;
		[Serialize("hitAction"                  )] public Generic<AIAction_Template> hitAction;
		[Serialize("flameFXName"                )] public StringID flameFXName;
		[Serialize("squashedInAnim"             )] public StringID squashedInAnim;
		[Serialize("squashedLoopAnim"           )] public StringID squashedLoopAnim;
		[Serialize("squashedOutAnim"            )] public StringID squashedOutAnim;
		[Serialize("polylineName"               )] public StringID polylineName;
		[Serialize("weightThreshold"            )] public float weightThreshold;
		[Serialize("flamesDurationOnCrushAttack")] public float flamesDurationOnCrushAttack;
		[Serialize("flamesDurationOnDRCStim"    )] public float flamesDurationOnDRCStim;
		[Serialize("hitActionDuration"          )] public float hitActionDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(drcCollisionShape));
			SerializeField(s, nameof(offAction));
			SerializeField(s, nameof(onAction));
			SerializeField(s, nameof(hitAction));
			SerializeField(s, nameof(flameFXName));
			SerializeField(s, nameof(squashedInAnim));
			SerializeField(s, nameof(squashedLoopAnim));
			SerializeField(s, nameof(squashedOutAnim));
			SerializeField(s, nameof(polylineName));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(flamesDurationOnCrushAttack));
			SerializeField(s, nameof(flamesDurationOnDRCStim));
			SerializeField(s, nameof(hitActionDuration));
		}
		public override uint? ClassCRC => 0x2CA127FB;
	}
}

