using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_34_sub_4A7BB0 : CSerializable {
		[Serialize("sender")] public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0xBF9DFFB5;
	}
}

