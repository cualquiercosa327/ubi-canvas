using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_BTActionPerformPedestal_Template : BTAction_Template {
		[Serialize("animPedestal"       )] public StringID animPedestal;
		[Serialize("animJump"           )] public StringID animJump;
		[Serialize("supportBone"        )] public StringID supportBone;
		[Serialize("walkTargetFactActor")] public StringID walkTargetFactActor;
		[Serialize("walkTargetFactPos"  )] public StringID walkTargetFactPos;
		[Serialize("areaRadius"         )] public float areaRadius;
		[Serialize("distanceCheck"      )] public float distanceCheck;
		[Serialize("feetDistanceCheck"  )] public float feetDistanceCheck;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animPedestal));
			SerializeField(s, nameof(animJump));
			SerializeField(s, nameof(supportBone));
			SerializeField(s, nameof(walkTargetFactActor));
			SerializeField(s, nameof(walkTargetFactPos));
			SerializeField(s, nameof(areaRadius));
			SerializeField(s, nameof(distanceCheck));
			SerializeField(s, nameof(feetDistanceCheck));
		}
		public override uint? ClassCRC => 0x0A35C7A8;
	}
}

