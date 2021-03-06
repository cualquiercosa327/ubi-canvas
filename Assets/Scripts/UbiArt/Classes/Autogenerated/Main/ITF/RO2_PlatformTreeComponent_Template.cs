using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlatformTreeComponent_Template : ActorComponent_Template {
		[Serialize("ignoreEventTrigger"              )] public bool ignoreEventTrigger;
		[Serialize("maxStartDelay"                   )] public float maxStartDelay;
		[Serialize("childMoveSpeed"                  )] public float childMoveSpeed;
		[Serialize("childMoveSpeedRandom"            )] public float childMoveSpeedRandom;
		[Serialize("fastMode"                        )] public bool fastMode;
		[Serialize("useTouch"                        )] public bool useTouch;
		[Serialize("childAngleCorrectionDist"        )] public float childAngleCorrectionDist;
		[Serialize("childLinkFadeDist"               )] public float childLinkFadeDist;
		[Serialize("childAppearDist"                 )] public float childAppearDist;
		[Serialize("childDisappearDist"              )] public float childDisappearDist;
		[Serialize("childOpenDist"                   )] public float childOpenDist;
		[Serialize("childCloseDist"                  )] public float childCloseDist;
		[Serialize("animOpened"                      )] public StringID animOpened;
		[Serialize("animClosed"                      )] public StringID animClosed;
		[Serialize("animAppear"                      )] public StringID animAppear;
		[Serialize("animDisappear"                   )] public StringID animDisappear;
		[Serialize("animHidden"                      )] public StringID animHidden;
		[Serialize("openingDelay"                    )] public float openingDelay;
		[Serialize("closingDelay"                    )] public float closingDelay;
		[Serialize("softCollision"                   )] public RO2_SoftCollision_Template softCollision;
		[Serialize("canWiggle"                       )] public bool canWiggle;
		[Serialize("padRumbleWiggle"                 )] public StringID padRumbleWiggle;
		[Serialize("animWiggleOpened"                )] public StringID animWiggleOpened;
		[Serialize("animWiggleClosed"                )] public StringID animWiggleClosed;
		[Serialize("disableCollisionDuringTransition")] public bool disableCollisionDuringTransition;
		[Serialize("disableActorOnOpen"              )] public bool disableActorOnOpen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ignoreEventTrigger));
			SerializeField(s, nameof(maxStartDelay));
			SerializeField(s, nameof(childMoveSpeed));
			SerializeField(s, nameof(childMoveSpeedRandom));
			SerializeField(s, nameof(fastMode));
			SerializeField(s, nameof(useTouch));
			SerializeField(s, nameof(childAngleCorrectionDist));
			SerializeField(s, nameof(childLinkFadeDist));
			SerializeField(s, nameof(childAppearDist));
			SerializeField(s, nameof(childDisappearDist));
			SerializeField(s, nameof(childOpenDist));
			SerializeField(s, nameof(childCloseDist));
			SerializeField(s, nameof(animOpened));
			SerializeField(s, nameof(animClosed));
			SerializeField(s, nameof(animAppear));
			SerializeField(s, nameof(animDisappear));
			SerializeField(s, nameof(animHidden));
			SerializeField(s, nameof(openingDelay));
			SerializeField(s, nameof(closingDelay));
			SerializeField(s, nameof(softCollision));
			SerializeField(s, nameof(canWiggle));
			SerializeField(s, nameof(padRumbleWiggle));
			SerializeField(s, nameof(animWiggleOpened));
			SerializeField(s, nameof(animWiggleClosed));
			SerializeField(s, nameof(disableCollisionDuringTransition));
			SerializeField(s, nameof(disableActorOnOpen));
		}
		public override uint? ClassCRC => 0x69661AA4;
	}
}

