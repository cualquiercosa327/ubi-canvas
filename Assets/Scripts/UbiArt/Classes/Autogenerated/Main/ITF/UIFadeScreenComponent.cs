using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIFadeScreenComponent : UIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x51353352;
	}
}

