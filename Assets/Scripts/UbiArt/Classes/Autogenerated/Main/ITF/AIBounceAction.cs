using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIBounceAction : AIAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA0D9587C;
	}
}

