using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIFruitTrapBehavior_Template : CSerializable {
		[Serialize("delay"          )] public float delay;
		[Serialize("weightThreshold")] public float weightThreshold;
		[Serialize("standAction"    )] public Generic<AIAction_Template> standAction;
		[Serialize("fruitFallAction")] public Generic<AIAction_Template> fruitFallAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(delay));
			SerializeField(s, nameof(weightThreshold));
			SerializeField(s, nameof(standAction));
			SerializeField(s, nameof(fruitFallAction));
		}
		public override uint? ClassCRC => 0xB4066175;
	}
}

