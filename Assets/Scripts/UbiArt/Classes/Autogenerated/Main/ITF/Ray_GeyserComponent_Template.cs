using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_GeyserComponent_Template : Ray_ChildLaunchComponent_Template {
		[Serialize("warnDuration"     )] public float warnDuration;
		[Serialize("launchDuration"   )] public float launchDuration;
		[Serialize("launchCameraShake")] public StringID launchCameraShake;
		[Serialize("warnFx"           )] public Path warnFx;
		[Serialize("warnFxOffset"     )] public Vector3 warnFxOffset;
		[Serialize("launchFx"         )] public Path launchFx;
		[Serialize("launchFxOffset"   )] public Vector3 launchFxOffset;
		[Serialize("idleAnim"         )] public StringID idleAnim;
		[Serialize("warnAnim"         )] public StringID warnAnim;
		[Serialize("launchAnim"       )] public StringID launchAnim;
		[Serialize("doneAnim"         )] public StringID doneAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(warnDuration));
			SerializeField(s, nameof(launchDuration));
			SerializeField(s, nameof(launchCameraShake));
			SerializeField(s, nameof(warnFx));
			SerializeField(s, nameof(warnFxOffset));
			SerializeField(s, nameof(launchFx));
			SerializeField(s, nameof(launchFxOffset));
			SerializeField(s, nameof(idleAnim));
			SerializeField(s, nameof(warnAnim));
			SerializeField(s, nameof(launchAnim));
			SerializeField(s, nameof(doneAnim));
		}
		public override uint? ClassCRC => 0x8AE897A3;
	}
}

