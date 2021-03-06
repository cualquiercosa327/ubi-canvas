using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_BezierTween : CSerializable {
		[Serialize("set"   )] public StringID set;
		[Serialize("offset")] public float offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(set));
			SerializeField(s, nameof(offset));
		}
	}
}

