using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class MultipassBranchRendererComponent : BezierBranchComponent {
		[Serialize("flipTexture")] public bool flipTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flipTexture));
		}
		public override uint? ClassCRC => 0xB6934339;
	}
}

