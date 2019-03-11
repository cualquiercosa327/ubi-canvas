using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_254_sub_8A41C0 : CSerializable {
		[Serialize("teleportDuration")] public float teleportDuration;
		[Serialize("targetActorPath" )] public ObjectPath targetActorPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(teleportDuration));
			SerializeField(s, nameof(targetActorPath));
		}
		public override uint? ClassCRC => 0xC5BA7F3F;
	}
}

