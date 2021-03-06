using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_WaveBallComponent_Template : ActorComponent_Template {
		[Serialize("scaleWhenOff"             )] public float scaleWhenOff;
		[Serialize("scaleWhenOn"              )] public float scaleWhenOn;
		[Serialize("offToOnDelay"             )] public float offToOnDelay;
		[Serialize("onToOffDelay"             )] public float onToOffDelay;
		[Serialize("texturePath"              )] public Path texturePath;
		[Serialize("spikeMultiplier_Preparing")] public float spikeMultiplier_Preparing;
		[Serialize("spikeMultiplier_Idle"     )] public float spikeMultiplier_Idle;
		[Serialize("colorOn"                  )] public Color colorOn;
		[Serialize("colorOff"                 )] public Color colorOff;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scaleWhenOff));
			SerializeField(s, nameof(scaleWhenOn));
			SerializeField(s, nameof(offToOnDelay));
			SerializeField(s, nameof(onToOffDelay));
			SerializeField(s, nameof(texturePath));
			SerializeField(s, nameof(spikeMultiplier_Preparing));
			SerializeField(s, nameof(spikeMultiplier_Idle));
			SerializeField(s, nameof(colorOn));
			SerializeField(s, nameof(colorOff));
		}
		public override uint? ClassCRC => 0xB268A3CF;
	}
}

