using UnityEngine;

namespace UbiArt.ITF {
	public partial class MoviePlayerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x0366A904;
	}
}

