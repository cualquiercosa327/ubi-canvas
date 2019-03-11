using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventShooterLandingRequested : CSerializable {
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0x1D5F4853;
	}
}

