using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventPlayMusic : Event {
		[Serialize("metronomeType")] public uint metronomeType;
		[Serialize("nodeName"     )] public StringID nodeName;
		[Serialize("fadeTime"     )] public float fadeTime;
		[Serialize("volume"       )] public Volume volume;
		[Serialize("playOnNext"   )] public uint playOnNext;
		[Serialize("stopAndPlay"  )] public int stopAndPlay;
		[Serialize("name"         )] public StringID name;
		[Serialize("fadeInTime"   )] public float fadeInTime;
		[Serialize("fadeOutTime"  )] public float fadeOutTime;
		[Serialize("offsetTime"   )] public float offsetTime;
		[Serialize("delay"        )] public float delay;
		[Serialize("eventDelay"   )] public float eventDelay;
		[Serialize("priority"     )] public uint priority;
		[Serialize("setPriority"  )] public uint setPriority;
		[Serialize("bus"          )] public StringID bus;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(metronomeType));
				SerializeField(s, nameof(nodeName));
				SerializeField(s, nameof(fadeTime));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(playOnNext));
				SerializeField(s, nameof(stopAndPlay));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(metronomeType));
				SerializeField(s, nameof(nodeName));
				SerializeField(s, nameof(fadeInTime));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(playOnNext));
				SerializeField(s, nameof(stopAndPlay));
				SerializeField(s, nameof(offsetTime));
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(delay));
				SerializeField(s, nameof(eventDelay));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(setPriority));
			} else {
			}
		}
		public override uint? ClassCRC => 0x8964ECD0;
	}
}

