using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_138_sub_7436B0 : CSerializable {
		[Serialize("checkActorPath")] public Path checkActorPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(checkActorPath));
		}
		public override uint? ClassCRC => 0xDA0F4D8D;
	}
}

