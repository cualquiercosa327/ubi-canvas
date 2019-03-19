using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TriggerComponent : ActorComponent {
		[Serialize("mode"                        )] public Mode mode;
		[Serialize("triggerOnceDone"             )] public bool triggerOnceDone;
		[Serialize("countdown"                   )] public float countdown;
		[Serialize("DBG_DrawCountdown"           )] public bool DBG_DrawCountdown;
		[Serialize("AutoActivation"              )] public bool AutoActivation;
		[Serialize("NoConditionEvent"            )] public Generic<Event> NoConditionEvent;
		[Serialize("onEnterMoreEvent"            )] public CList<Event> onEnterMoreEvent;
		[Serialize("onExitMoreEvent"             )] public CList<Event> onExitMoreEvent;
		[Serialize("moreEventSendBroadcast"      )] public bool moreEventSendBroadcast;
		[Serialize("moreEventSendGameManager"    )] public bool moreEventSendGameManager;
		[Serialize("activatedOnGo"               )] public bool activatedOnGo;
		[Serialize("specificTutoShieldDialog"    )] public bool specificTutoShieldDialog;
		[Serialize("disableIfMapAlreadyCompleted")] public bool disableIfMapAlreadyCompleted;
		[Serialize("triggerActivator"            )] public bool triggerActivator;
		[Serialize("retriggerOnCheckpoint"       )] public int retriggerOnCheckpoint;
		[Serialize("triggerOnceDone"             )] public int triggerOnceDone;
		[Serialize("activator"                   )] public uint activator;
		[Serialize("mode"                        )] public Enum_mode mode;
		[Serialize("onEnterEvent"                )] public Placeholder onEnterEvent;
		[Serialize("onExitEvent"                 )] public Placeholder onExitEvent;
		[Serialize("resetOnExit"                 )] public bool resetOnExit;
		[Serialize("triggerEachActor"            )] public bool triggerEachActor;
		[Serialize("triggerAllActors"            )] public bool triggerAllActors;
		[Serialize("sendEventEveryFrame"         )] public bool sendEventEveryFrame;
		[Serialize("triggerOnDetector"           )] public bool triggerOnDetector;
		[Serialize("triggerOnHit"                )] public bool triggerOnHit;
		[Serialize("triggerOnCrush"              )] public bool triggerOnCrush;
		[Serialize("triggerable"                 )] public bool triggerable;
		[Serialize("triggerSelf"                 )] public bool triggerSelf;
		[Serialize("triggerChildren"             )] public bool triggerChildren;
		[Serialize("triggerBoundChildren"        )] public bool triggerBoundChildren;
		[Serialize("triggerParent"               )] public bool triggerParent;
		[Serialize("triggerGameManager"          )] public bool triggerGameManager;
		[Serialize("triggerBroadcast"            )] public bool triggerBroadcast;
		[Serialize("triggerExitOnBecomeInactive" )] public bool triggerExitOnBecomeInactive;
		[Serialize("version"                     )] public uint version;
		[Serialize("Enum_VH_0__0"                )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("float__1"                    )] public float float__1;
		[Serialize("bool__2"                     )] public bool bool__2;
		[Serialize("bool__3"                     )] public bool bool__3;
		[Serialize("Generic<Event>__4"           )] public Generic<Event> Generic_Event__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(retriggerOnCheckpoint));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
					SerializeField(s, nameof(activator));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(mode));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
					SerializeField(s, nameof(activator));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(mode));
					SerializeField(s, nameof(onEnterEvent));
					SerializeField(s, nameof(onExitEvent));
					SerializeField(s, nameof(resetOnExit), boolAsByte: true);
					SerializeField(s, nameof(triggerEachActor), boolAsByte: true);
					SerializeField(s, nameof(triggerAllActors), boolAsByte: true);
					SerializeField(s, nameof(sendEventEveryFrame), boolAsByte: true);
					SerializeField(s, nameof(triggerOnDetector), boolAsByte: true);
					SerializeField(s, nameof(triggerOnHit), boolAsByte: true);
					SerializeField(s, nameof(triggerOnCrush), boolAsByte: true);
					SerializeField(s, nameof(triggerable), boolAsByte: true);
					SerializeField(s, nameof(triggerSelf), boolAsByte: true);
					SerializeField(s, nameof(triggerChildren), boolAsByte: true);
					SerializeField(s, nameof(triggerBoundChildren), boolAsByte: true);
					SerializeField(s, nameof(triggerParent), boolAsByte: true);
					SerializeField(s, nameof(triggerActivator), boolAsByte: true);
					SerializeField(s, nameof(triggerGameManager), boolAsByte: true);
					SerializeField(s, nameof(triggerBroadcast), boolAsByte: true);
					SerializeField(s, nameof(triggerExitOnBecomeInactive), boolAsByte: true);
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(version));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone), boolAsByte: true);
					SerializeField(s, nameof(activator));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Enum_VH_0__0));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
				}
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(bool__3));
				SerializeField(s, nameof(Generic_Event__4));
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(mode));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(triggerOnceDone));
				}
				SerializeField(s, nameof(countdown));
				SerializeField(s, nameof(DBG_DrawCountdown));
				SerializeField(s, nameof(AutoActivation));
				SerializeField(s, nameof(NoConditionEvent));
				SerializeField(s, nameof(onEnterMoreEvent));
				SerializeField(s, nameof(onExitMoreEvent));
				SerializeField(s, nameof(moreEventSendBroadcast));
				SerializeField(s, nameof(moreEventSendGameManager));
				SerializeField(s, nameof(activatedOnGo));
				SerializeField(s, nameof(specificTutoShieldDialog));
				SerializeField(s, nameof(disableIfMapAlreadyCompleted));
				SerializeField(s, nameof(triggerActivator));
			}
		}
		public enum Mode {
			[Serialize("Mode_Once"            )] Once = 1,
			[Serialize("Mode_OnceAndRetrigger")] OnceAndRetrigger = 2,
			[Serialize("Mode_OnceAndReset"    )] OnceAndReset = 3,
			[Serialize("Mode_Multiple"        )] Multiple = 4,
		}
		public enum Enum_mode {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_mode {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0x5E302A40;
	}
}

