using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlaySpawn_evt : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x614D7696;
	}
}

