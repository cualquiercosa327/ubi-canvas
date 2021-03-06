using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class IdRedirect : CSerializable {
		[Serialize("src")] public StringID src;
		[Serialize("dst")] public StringID dst;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(src));
			SerializeField(s, nameof(dst));
		}
	}
}

