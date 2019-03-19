using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_SubAnchor : CSerializable {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("Vector3__1" )] public Vector3 Vector3__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(Vector3__1));
		}
	}
}
