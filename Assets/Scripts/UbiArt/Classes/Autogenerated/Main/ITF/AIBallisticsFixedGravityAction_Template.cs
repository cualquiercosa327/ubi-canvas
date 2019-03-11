using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIBallisticsFixedGravityAction_Template : AIBallisticsAction_Template {
		[Serialize("usePhysicsGravity")] public bool usePhysicsGravity;
		[Serialize("fixedGravity"     )] public float fixedGravity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(usePhysicsGravity));
			SerializeField(s, nameof(fixedGravity));
		}
		public override uint? ClassCRC => 0x31EF148E;
	}
}

