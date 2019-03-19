using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_AIChest2Behavior_Template : TemplateAIBehavior {
		[Serialize("safeDistance"           )] public float safeDistance;
		[Serialize("minSpeed"               )] public float minSpeed;
		[Serialize("maxSpeed"               )] public float maxSpeed;
		[Serialize("swimMinSpeed"           )] public float swimMinSpeed;
		[Serialize("swimMaxSpeed"           )] public float swimMaxSpeed;
		[Serialize("waitSpeed"              )] public float waitSpeed;
		[Serialize("upsideDownFloorSpeed"   )] public float upsideDownFloorSpeed;
		[Serialize("upsideDownCeilingSpeed" )] public float upsideDownCeilingSpeed;
		[Serialize("breakableSpeed"         )] public float breakableSpeed;
		[Serialize("reducedScale"           )] public float reducedScale;
		[Serialize("lumsToGiveMax"          )] public uint lumsToGiveMax;
		[Serialize("lumPath"                )] public Path lumPath;
		[Serialize("lumsToCloseEye"         )] public uint lumsToCloseEye;
		[Serialize("eyeClosingDuration"     )] public float eyeClosingDuration;
		[Serialize("lumInsensitiveTime"     )] public float lumInsensitiveTime;
		[Serialize("drcLumDropEnabled"      )] public bool drcLumDropEnabled;
		[Serialize("sendBreakEventsDirectly")] public bool sendBreakEventsDirectly;
		[Serialize("disableAfterBreakEvents")] public bool disableAfterBreakEvents;
		[Serialize("snapBreakSequencePlayer")] public bool snapBreakSequencePlayer;
		[Serialize("breakEvents"            )] public CArray<Generic<Event>> breakEvents;
		[Serialize("detectDelay"            )] public float detectDelay;
		[Serialize("hideTimeout"            )] public float hideTimeout;
		[Serialize("canReverse"             )] public bool canReverse;
		[Serialize("reverseInterval"        )] public float reverseInterval;
		[Serialize("standAction"            )] public Generic<AIAction_Template> standAction;
		[Serialize("runAction"              )] public Generic<AIAction_Template> runAction;
		[Serialize("jumpAction"             )] public Generic<AIAction_Template> jumpAction;
		[Serialize("toFlyAction"            )] public Generic<AIAction_Template> toFlyAction;
		[Serialize("flyAction"              )] public Generic<AIAction_Template> flyAction;
		[Serialize("landAction"             )] public Generic<AIAction_Template> landAction;
		[Serialize("skidAction"             )] public Generic<AIAction_Template> skidAction;
		[Serialize("waitAction"             )] public Generic<AIAction_Template> waitAction;
		[Serialize("tauntAction"            )] public Generic<AIAction_Template> tauntAction;
		[Serialize("diveAction"             )] public Generic<AIAction_Template> diveAction;
		[Serialize("swimAction"             )] public Generic<AIAction_Template> swimAction;
		[Serialize("thinkDetectAction"      )] public Generic<AIAction_Template> thinkDetectAction;
		[Serialize("thinkHideAction"        )] public Generic<AIAction_Template> thinkHideAction;
		[Serialize("breaksAction"           )] public Generic<AIAction_Template> breaksAction;
		[Serialize("brokenAction"           )] public Generic<AIAction_Template> brokenAction;
		[Serialize("tickleAction"           )] public Generic<AIAction_Template> tickleAction;
		[Serialize("registerCameraEnabled"  )] public bool registerCameraEnabled;
		[Serialize("forceBreakable"         )] public bool forceBreakable;
		[Serialize("cineLaunchEnabled"      )] public bool cineLaunchEnabled;
		[Serialize("crushEnabled"           )] public bool crushEnabled;
		[Serialize("hitLumDropEnabled"      )] public bool hitLumDropEnabled;
		[Serialize("hitLumDropCount"        )] public uint hitLumDropCount;
		[Serialize("distMinForSwipe"        )] public float distMinForSwipe;
		[Serialize("tickleEnabled"          )] public bool tickleEnabled;
		[Serialize("tickleDuration"         )] public float tickleDuration;
		[Serialize("forceShieldEnabled"     )] public bool forceShieldEnabled;
		[Serialize("forceShieldPath"        )] public Path forceShieldPath;
		[Serialize("forceShieldBone"        )] public StringID forceShieldBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(safeDistance));
			SerializeField(s, nameof(minSpeed));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(swimMinSpeed));
			SerializeField(s, nameof(swimMaxSpeed));
			SerializeField(s, nameof(waitSpeed));
			SerializeField(s, nameof(upsideDownFloorSpeed));
			SerializeField(s, nameof(upsideDownCeilingSpeed));
			SerializeField(s, nameof(breakableSpeed));
			SerializeField(s, nameof(reducedScale));
			SerializeField(s, nameof(lumsToGiveMax));
			SerializeField(s, nameof(lumPath));
			SerializeField(s, nameof(lumsToCloseEye));
			SerializeField(s, nameof(eyeClosingDuration));
			SerializeField(s, nameof(lumInsensitiveTime));
			SerializeField(s, nameof(drcLumDropEnabled));
			SerializeField(s, nameof(sendBreakEventsDirectly));
			SerializeField(s, nameof(disableAfterBreakEvents));
			SerializeField(s, nameof(snapBreakSequencePlayer));
			SerializeField(s, nameof(breakEvents));
			SerializeField(s, nameof(detectDelay));
			SerializeField(s, nameof(hideTimeout));
			SerializeField(s, nameof(canReverse));
			SerializeField(s, nameof(reverseInterval));
			SerializeField(s, nameof(standAction));
			SerializeField(s, nameof(runAction));
			SerializeField(s, nameof(jumpAction));
			SerializeField(s, nameof(toFlyAction));
			SerializeField(s, nameof(flyAction));
			SerializeField(s, nameof(landAction));
			SerializeField(s, nameof(skidAction));
			SerializeField(s, nameof(waitAction));
			SerializeField(s, nameof(tauntAction));
			SerializeField(s, nameof(diveAction));
			SerializeField(s, nameof(swimAction));
			SerializeField(s, nameof(thinkDetectAction));
			SerializeField(s, nameof(thinkHideAction));
			SerializeField(s, nameof(breaksAction));
			SerializeField(s, nameof(brokenAction));
			SerializeField(s, nameof(tickleAction));
			SerializeField(s, nameof(registerCameraEnabled));
			SerializeField(s, nameof(forceBreakable));
			SerializeField(s, nameof(cineLaunchEnabled));
			SerializeField(s, nameof(crushEnabled));
			SerializeField(s, nameof(hitLumDropEnabled));
			SerializeField(s, nameof(hitLumDropCount));
			SerializeField(s, nameof(distMinForSwipe));
			SerializeField(s, nameof(tickleEnabled));
			SerializeField(s, nameof(tickleDuration));
			SerializeField(s, nameof(forceShieldEnabled));
			SerializeField(s, nameof(forceShieldPath));
			SerializeField(s, nameof(forceShieldBone));
		}
		public override uint? ClassCRC => 0x242F9D6A;
	}
}
