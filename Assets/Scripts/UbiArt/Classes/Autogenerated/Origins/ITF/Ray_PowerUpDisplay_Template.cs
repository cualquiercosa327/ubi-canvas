using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_PowerUpDisplay_Template : CSerializable {
		[Serialize("id")] public StringID id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
		}
		public override uint? ClassCRC => 0x1D175BED;
	}
}

