using UnityEngine;

namespace UbiArt.ITF {
	public partial class EnemyDetectorComponent : ShapeDetectorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE7590898;
	}
}

