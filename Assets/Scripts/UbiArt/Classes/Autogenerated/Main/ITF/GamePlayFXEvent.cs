using UnityEngine;

namespace UbiArt.ITF {
	public partial class GamePlayFXEvent : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE097D502;
	}
}

