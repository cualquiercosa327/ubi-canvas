using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBoulderSentBackBehavior_Template : TemplateAIBehavior {
		[Serialize("gravity" )] public float gravity;
		[Serialize("friction")] public float friction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravity));
			SerializeField(s, nameof(friction));
		}
		public override uint? ClassCRC => 0xE282EE83;
	}
}

