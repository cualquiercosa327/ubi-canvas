using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimTreeNodePlayAnimProceduralSmooth_Template : AnimTreeNodePlayAnim_Template {
		[Serialize("startCursor"  )] public float startCursor;
		[Serialize("stiffConstant")] public float stiffConstant;
		[Serialize("dampConstant" )] public float dampConstant;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startCursor));
			SerializeField(s, nameof(stiffConstant));
			SerializeField(s, nameof(dampConstant));
		}
		public override uint? ClassCRC => 0xEEF2E99F;
	}
}

