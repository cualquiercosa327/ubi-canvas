using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimSkeletonResource : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x481DD42F;
	}
}

