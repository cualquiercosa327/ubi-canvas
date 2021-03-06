using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIFollowBezierCurveAction_Template : AIAction_Template {
		[Serialize("speed")] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
		}
		public override uint? ClassCRC => 0xFA806DD2;
	}
}

