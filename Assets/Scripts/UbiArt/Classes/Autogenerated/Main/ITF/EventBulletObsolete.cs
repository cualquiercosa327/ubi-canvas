using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventBulletObsolete : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x611940DF;
	}
}

