using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class ScreenShotDataFamilyShowcase : online.OpenGraphObject {
		[Serialize("family_name")] public string family_name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(family_name));
		}
		public override uint? ClassCRC => 0x82483F71;
	}
}

