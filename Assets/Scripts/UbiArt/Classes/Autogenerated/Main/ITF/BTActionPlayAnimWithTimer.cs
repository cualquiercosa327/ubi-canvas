using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionPlayAnimWithTimer : BTActionPlayAnim {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEDA945EB;
	}
}

