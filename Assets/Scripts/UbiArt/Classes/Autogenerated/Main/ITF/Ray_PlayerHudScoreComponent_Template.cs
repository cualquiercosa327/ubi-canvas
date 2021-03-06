using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PlayerHudScoreComponent_Template : GraphicComponent_Template {
		[Serialize("relativeWidth"                       )] public float relativeWidth;
		[Serialize("relativeSpacing"                     )] public float relativeSpacing;
		[Serialize("actualWidthPercent"                  )] public float actualWidthPercent;
		[Serialize("relativeAdditionalMargin"            )] public Placeholder relativeAdditionalMargin;
		[Serialize("pressToJoinRelativeAdditionalMargin" )] public Placeholder pressToJoinRelativeAdditionalMargin;
		[Serialize("fadeInDuration"                      )] public float fadeInDuration;
		[Serialize("visibleDuration"                     )] public float visibleDuration;
		[Serialize("fadeOutDuration"                     )] public float fadeOutDuration;
		[Serialize("fontName"                            )] public Path fontName;
		[Serialize("scorePos"                            )] public Vector2 scorePos;
		[Serialize("scoreSize"                           )] public Vector2 scoreSize;
		[Serialize("scoreColor"                          )] public Color scoreColor;
		[Serialize("lumBigIncreaseSpeed"                 )] public uint lumBigIncreaseSpeed;
		[Serialize("lumProgressiveBigIncreaseThreshold"  )] public uint lumProgressiveBigIncreaseThreshold;
		[Serialize("lumSmallIncreaseSpeed"               )] public uint lumSmallIncreaseSpeed;
		[Serialize("lumProgressiveSmallIncreaseThreshold")] public uint lumProgressiveSmallIncreaseThreshold;
		[Serialize("pulseSustainDuration"                )] public float pulseSustainDuration;
		[Serialize("lumNormalScale"                      )] public float lumNormalScale;
		[Serialize("pulseScale"                          )] public float pulseScale;
		[Serialize("pulseIncreaseDuration"               )] public float pulseIncreaseDuration;
		[Serialize("pulseDecreaseDuration"               )] public float pulseDecreaseDuration;
		[Serialize("pulseDoublePeakDuration"             )] public float pulseDoublePeakDuration;
		[Serialize("pulseDoublePeakMinScale"             )] public float pulseDoublePeakMinScale;
		[Serialize("pulseCycleDuration_SingleLum"        )] public float pulseCycleDuration_SingleLum;
		[Serialize("pulseCycleDuration_MultipleLums"     )] public float pulseCycleDuration_MultipleLums;
		[Serialize("scoreMultiplierParticleID"           )] public StringID scoreMultiplierParticleID;
		[Serialize("scoreMultiplierValue"                )] public uint scoreMultiplierValue;
		[Serialize("pressStartHeight"                    )] public float pressStartHeight;
		[Serialize("pressStartPos"                       )] public Vector2 pressStartPos;
		[Serialize("pressStartFontName"                  )] public Path pressStartFontName;
		[Serialize("grayedAlpha"                         )] public float grayedAlpha;
		[Serialize("idleAlpha"                           )] public float idleAlpha;
		[Serialize("pressStartPulsePeriod"               )] public float pressStartPulsePeriod;
		[Serialize("pressStartFadeInDuration"            )] public float pressStartFadeInDuration;
		[Serialize("pressStartFadeOutDuration"           )] public float pressStartFadeOutDuration;
		[Serialize("pressStartMinAlpha"                  )] public float pressStartMinAlpha;
		[Serialize("pressStartMaxAlpha"                  )] public float pressStartMaxAlpha;
		[Serialize("pressStartTextID"                    )] public LocalisationId pressStartTextID;
		[Serialize("lumTexture"                          )] public Path lumTexture;
		[Serialize("characterTexture"                    )] public Path characterTexture;
		[Serialize("lumBoxLocalPosition"                 )] public Vector2 lumBoxLocalPosition;
		[Serialize("lumBoxLocalSize"                     )] public Vector2 lumBoxLocalSize;
		[Serialize("headBoxLocalSize"                    )] public Vector2 headBoxLocalSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(relativeWidth));
			SerializeField(s, nameof(relativeSpacing));
			SerializeField(s, nameof(actualWidthPercent));
			SerializeField(s, nameof(relativeAdditionalMargin));
			SerializeField(s, nameof(pressToJoinRelativeAdditionalMargin));
			SerializeField(s, nameof(fadeInDuration));
			SerializeField(s, nameof(visibleDuration));
			SerializeField(s, nameof(fadeOutDuration));
			SerializeField(s, nameof(fontName));
			SerializeField(s, nameof(scorePos));
			SerializeField(s, nameof(scoreSize));
			SerializeField(s, nameof(scoreColor));
			SerializeField(s, nameof(lumBigIncreaseSpeed));
			SerializeField(s, nameof(lumProgressiveBigIncreaseThreshold));
			SerializeField(s, nameof(lumSmallIncreaseSpeed));
			SerializeField(s, nameof(lumProgressiveSmallIncreaseThreshold));
			SerializeField(s, nameof(pulseSustainDuration));
			SerializeField(s, nameof(lumNormalScale));
			SerializeField(s, nameof(pulseScale));
			SerializeField(s, nameof(pulseIncreaseDuration));
			SerializeField(s, nameof(pulseDecreaseDuration));
			SerializeField(s, nameof(pulseDoublePeakDuration));
			SerializeField(s, nameof(pulseDoublePeakMinScale));
			SerializeField(s, nameof(pulseCycleDuration_SingleLum));
			SerializeField(s, nameof(pulseCycleDuration_MultipleLums));
			SerializeField(s, nameof(scoreMultiplierParticleID));
			SerializeField(s, nameof(scoreMultiplierValue));
			SerializeField(s, nameof(pressStartHeight));
			SerializeField(s, nameof(pressStartPos));
			SerializeField(s, nameof(pressStartFontName));
			SerializeField(s, nameof(grayedAlpha));
			SerializeField(s, nameof(idleAlpha));
			SerializeField(s, nameof(pressStartPulsePeriod));
			SerializeField(s, nameof(pressStartFadeInDuration));
			SerializeField(s, nameof(pressStartFadeOutDuration));
			SerializeField(s, nameof(pressStartMinAlpha));
			SerializeField(s, nameof(pressStartMaxAlpha));
			SerializeField(s, nameof(pressStartTextID));
			SerializeField(s, nameof(lumTexture));
			SerializeField(s, nameof(characterTexture));
			SerializeField(s, nameof(lumBoxLocalPosition));
			SerializeField(s, nameof(lumBoxLocalSize));
			SerializeField(s, nameof(headBoxLocalSize));
		}
		public override uint? ClassCRC => 0xF0F35EB5;
	}
}

