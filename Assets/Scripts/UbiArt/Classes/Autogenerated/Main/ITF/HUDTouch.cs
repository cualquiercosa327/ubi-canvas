using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class HUDTouch : ActorComponent {
		[Serialize("bool__0")] public bool bool__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
		}
		public override uint? ClassCRC => 0x798DB946;
	}
}

