using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SpikyShellTrapComponent_Template : CSerializable {
		[Serialize("texturePath"                     )] public Path texturePath;
		[Serialize("baseWidth"                       )] public float baseWidth;
		[Serialize("minScaleFactor"                  )] public float minScaleFactor;
		[Serialize("minSpacing"                      )] public float minSpacing;
		[Serialize("maxSpacing"                      )] public float maxSpacing;
		[Serialize("baseHeight"                      )] public float baseHeight;
		[Serialize("restHeightPercent"               )] public float restHeightPercent;
		[Serialize("risenHeightPercent"              )] public float risenHeightPercent;
		[Serialize("maxHeight"                       )] public float maxHeight;
		[Serialize("frontBaseTexIndex_Idle"          )] public uint frontBaseTexIndex_Idle;
		[Serialize("frontBaseFirstTexIndex_Shaking"  )] public uint frontBaseFirstTexIndex_Shaking;
		[Serialize("frontBaseLastTexIndex_Shaking"   )] public uint frontBaseLastTexIndex_Shaking;
		[Serialize("backBaseTexIndex_Idle"           )] public uint backBaseTexIndex_Idle;
		[Serialize("backBaseFirstTexIndex_Shaking"   )] public uint backBaseFirstTexIndex_Shaking;
		[Serialize("spikeFirstTexIndex"              )] public uint spikeFirstTexIndex;
		[Serialize("spikeLastTexIndex"               )] public uint spikeLastTexIndex;
		[Serialize("spikeWidth"                      )] public float spikeWidth;
		[Serialize("shakeDetectionRadius"            )] public float shakeDetectionRadius;
		[Serialize("spikeDetectionRadius"            )] public float spikeDetectionRadius;
		[Serialize("endOfSpikeDetectionRadius"       )] public float endOfSpikeDetectionRadius;
		[Serialize("faction"                         )] public uint faction;
		[Serialize("minAlertDuration"                )] public float minAlertDuration;
		[Serialize("minSpikeDuration"                )] public float minSpikeDuration;
		[Serialize("shakeAmplitude"                  )] public float shakeAmplitude;
		[Serialize("spikeVibration_UpDuration"       )] public float spikeVibration_UpDuration;
		[Serialize("spikeVibration_DownDuration"     )] public float spikeVibration_DownDuration;
		[Serialize("spikeAmplitude"                  )] public float spikeAmplitude;
		[Serialize("spikeYOffset"                    )] public float spikeYOffset;
		[Serialize("hitMarginPercent"                )] public float hitMarginPercent;
		[Serialize("hitLevel"                        )] public uint hitLevel;
		[Serialize("spikeAnimationFirstFrameDuration")] public float spikeAnimationFirstFrameDuration;
		[Serialize("spikeAnimationFrameDuration"     )] public float spikeAnimationFrameDuration;
		[Serialize("baseAnimationFrameDuration"      )] public float baseAnimationFrameDuration;
		[Serialize("spikeInertia_Out"                )] public float spikeInertia_Out;
		[Serialize("spikeInertia_EmergencyOut"       )] public float spikeInertia_EmergencyOut;
		[Serialize("spikeInertia_Holster"            )] public float spikeInertia_Holster;
		[Serialize("spikeDetectionRadius_Emergency"  )] public float spikeDetectionRadius_Emergency;
		[Serialize("spikeBounciness"                 )] public float spikeBounciness;
		[Serialize("hitWidthScale"                   )] public float hitWidthScale;
		[Serialize("rotationMargin"                  )] public Angle rotationMargin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(texturePath));
			SerializeField(s, nameof(baseWidth));
			SerializeField(s, nameof(minScaleFactor));
			SerializeField(s, nameof(minSpacing));
			SerializeField(s, nameof(maxSpacing));
			SerializeField(s, nameof(baseHeight));
			SerializeField(s, nameof(restHeightPercent));
			SerializeField(s, nameof(risenHeightPercent));
			SerializeField(s, nameof(maxHeight));
			SerializeField(s, nameof(frontBaseTexIndex_Idle));
			SerializeField(s, nameof(frontBaseFirstTexIndex_Shaking));
			SerializeField(s, nameof(frontBaseLastTexIndex_Shaking));
			SerializeField(s, nameof(backBaseTexIndex_Idle));
			SerializeField(s, nameof(backBaseFirstTexIndex_Shaking));
			SerializeField(s, nameof(spikeFirstTexIndex));
			SerializeField(s, nameof(spikeLastTexIndex));
			SerializeField(s, nameof(spikeWidth));
			SerializeField(s, nameof(shakeDetectionRadius));
			SerializeField(s, nameof(spikeDetectionRadius));
			SerializeField(s, nameof(endOfSpikeDetectionRadius));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(minAlertDuration));
			SerializeField(s, nameof(minSpikeDuration));
			SerializeField(s, nameof(shakeAmplitude));
			SerializeField(s, nameof(spikeVibration_UpDuration));
			SerializeField(s, nameof(spikeVibration_DownDuration));
			SerializeField(s, nameof(spikeAmplitude));
			SerializeField(s, nameof(spikeYOffset));
			SerializeField(s, nameof(hitMarginPercent));
			SerializeField(s, nameof(hitLevel));
			SerializeField(s, nameof(spikeAnimationFirstFrameDuration));
			SerializeField(s, nameof(spikeAnimationFrameDuration));
			SerializeField(s, nameof(baseAnimationFrameDuration));
			SerializeField(s, nameof(spikeInertia_Out));
			SerializeField(s, nameof(spikeInertia_EmergencyOut));
			SerializeField(s, nameof(spikeInertia_Holster));
			SerializeField(s, nameof(spikeDetectionRadius_Emergency));
			SerializeField(s, nameof(spikeBounciness));
			SerializeField(s, nameof(hitWidthScale));
			SerializeField(s, nameof(rotationMargin));
		}
		public override uint? ClassCRC => 0xE62DB02F;
	}
}

