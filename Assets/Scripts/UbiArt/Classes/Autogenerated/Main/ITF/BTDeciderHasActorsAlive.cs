using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDeciderHasActorsAlive : BTDecider {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x66642C07;
	}
}

