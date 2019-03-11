using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LuckyTicketComponent_Template : ActorComponent_Template {
		[Serialize("regionPath"                    )] public Path regionPath;
		[Serialize("startPos"                      )] public Vector2 startPos;
		[Serialize("lineHeight"                    )] public float lineHeight;
		[Serialize("columnWidth"                   )] public float columnWidth;
		[Serialize("revealedCoef"                  )] public float revealedCoef;
		[Serialize("teensyRandomCoef"              )] public uint teensyRandomCoef;
		[Serialize("lumsThreshold_4"               )] public int lumsThreshold_4;
		[Serialize("lumsThreshold_5"               )] public int lumsThreshold_5;
		[Serialize("lumsThreshold_6"               )] public int lumsThreshold_6;
		[Serialize("lumsThreshold_3_RandomCoef"    )] public uint lumsThreshold_3_RandomCoef;
		[Serialize("lumsThreshold_4_RandomCoef"    )] public uint lumsThreshold_4_RandomCoef;
		[Serialize("lumsThreshold_5_RandomCoef"    )] public uint lumsThreshold_5_RandomCoef;
		[Serialize("lumsThreshold_6_RandomCoef"    )] public uint lumsThreshold_6_RandomCoef;
		[Serialize("frameRandomCoef"               )] public uint frameRandomCoef;
		[Serialize("petRandomCoef"                 )] public uint petRandomCoef;
		[Serialize("teensyIconPath"                )] public Path teensyIconPath;
		[Serialize("petIconPath"                   )] public Path petIconPath;
		[Serialize("frameIconPath"                 )] public Path frameIconPath;
		[Serialize("lumIconPath"                   )] public Path lumIconPath;
		[Serialize("teensyIconOffset"              )] public Vector2 teensyIconOffset;
		[Serialize("petIconOffset"                 )] public Vector2 petIconOffset;
		[Serialize("frameIconOffset"               )] public Vector2 frameIconOffset;
		[Serialize("lumIconOffset"                 )] public Vector2 lumIconOffset;
		[Serialize("iconAnimStand"                 )] public StringID iconAnimStand;
		[Serialize("iconAnimRevealed"              )] public StringID iconAnimRevealed;
		[Serialize("hideMenuCoef"                  )] public float hideMenuCoef;
		[Serialize("petRewardCount"                )] public uint petRewardCount;
		[Serialize("teensyRewardCount"             )] public uint teensyRewardCount;
		[Serialize("lums_3_RewardCount"            )] public uint lums_3_RewardCount;
		[Serialize("lums_4_RewardCount"            )] public uint lums_4_RewardCount;
		[Serialize("lums_5_RewardCount"            )] public uint lums_5_RewardCount;
		[Serialize("lums_6_RewardCount"            )] public uint lums_6_RewardCount;
		[Serialize("frameRewardCount"              )] public uint frameRewardCount;
		[Serialize("fadeToBlackDuration"           )] public float fadeToBlackDuration;
		[Serialize("rewardIconOffsetWidth"         )] public float rewardIconOffsetWidth;
		[Serialize("rewardIconOffsetHeight"        )] public float rewardIconOffsetHeight;
		[Serialize("speedBlend"                    )] public float speedBlend;
		[Serialize("speedMin"                      )] public float speedMin;
		[Serialize("speedMax"                      )] public float speedMax;
		[Serialize("blendAtSpeedMin"               )] public float blendAtSpeedMin;
		[Serialize("blendAtSpeedMax"               )] public float blendAtSpeedMax;
		[Serialize("dalleFramePath"                )] public Path dalleFramePath;
		[Serialize("dalleLumPath"                  )] public Path dalleLumPath;
		[Serialize("dalleNeutralPath"              )] public Path dalleNeutralPath;
		[Serialize("dallePetPath"                  )] public Path dallePetPath;
		[Serialize("dalleTeensyPath"               )] public Path dalleTeensyPath;
		[Serialize("iconFadeAlpha"                 )] public float iconFadeAlpha;
		[Serialize("dalleFadeAlpha"                )] public float dalleFadeAlpha;
		[Serialize("cameraFX"                      )] public StringID cameraFX;
		[Serialize("fireworkFX"                    )] public StringID fireworkFX;
		[Serialize("fireworksOffsets"              )] public CArray<Vector3> fireworksOffsets;
		[Serialize("minTimeBetweenFireworks"       )] public float minTimeBetweenFireworks;
		[Serialize("maxTimeBetweenFireworks"       )] public float maxTimeBetweenFireworks;
		[Serialize("iconFadeColor"                 )] public Color iconFadeColor;
		[Serialize("timeBetweenRewardIconMove"     )] public float timeBetweenRewardIconMove;
		[Serialize("looseRandomCoef"               )] public uint looseRandomCoef;
		[Serialize("rewardsOrder"                  )] public CList<RO2_LTReward> rewardsOrder;
		[Serialize("debugRewardFilePath"           )] public Path debugRewardFilePath;
		[Serialize("delayBeforeReward"             )] public float delayBeforeReward;
		[Serialize("digShapeRadiusSpeed"           )] public float digShapeRadiusSpeed;
		[Serialize("scratchStopTime"               )] public float scratchStopTime;
		[Serialize("scratchAccelTime"              )] public float scratchAccelTime;
		[Serialize("scratchMinSpeed"               )] public float scratchMinSpeed;
		[Serialize("scratchMaxSpeed"               )] public float scratchMaxSpeed;
		[Serialize("scratchStepSpeed"              )] public float scratchStepSpeed;
		[Serialize("scratchAcceleration"           )] public float scratchAcceleration;
		[Serialize("scratchDeceleration"           )] public float scratchDeceleration;
		[Serialize("scratchShapeEnabled"           )] public bool scratchShapeEnabled;
		[Serialize("musicEnterEvent"               )] public Placeholder musicEnterEvent;
		[Serialize("musicWinEvent"                 )] public Placeholder musicWinEvent;
		[Serialize("musicStopEvent"                )] public Placeholder musicStopEvent;
		[Serialize("textRewardScaleStart"          )] public float textRewardScaleStart;
		[Serialize("textRewardScaleEnd"            )] public float textRewardScaleEnd;
		[Serialize("textRewardScaleDuration"       )] public float textRewardScaleDuration;
		[Serialize("textRewardAlphaStart"          )] public float textRewardAlphaStart;
		[Serialize("textRewardAlphaEnd"            )] public float textRewardAlphaEnd;
		[Serialize("textRewardAlphaDuration"       )] public float textRewardAlphaDuration;
		[Serialize("textRewardTypeDelay"           )] public float textRewardTypeDelay;
		[Serialize("murphyFingerFadeOutDuration"   )] public float murphyFingerFadeOutDuration;
		[Serialize("textRewardDelay"               )] public float textRewardDelay;
		[Serialize("screenDarkerAlphaStart"        )] public float screenDarkerAlphaStart;
		[Serialize("screenDarkerAlphaEnd"          )] public float screenDarkerAlphaEnd;
		[Serialize("screenDarkerAlphaStartDuration")] public float screenDarkerAlphaStartDuration;
		[Serialize("screenDarkerAlphaEndDuration"  )] public float screenDarkerAlphaEndDuration;
		[Serialize("iconFadeOutDuration"           )] public float iconFadeOutDuration;
		[Serialize("iconFadeInDelay"               )] public float iconFadeInDelay;
		[Serialize("iconFadeInDuration"            )] public float iconFadeInDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(regionPath));
				SerializeField(s, nameof(startPos));
				SerializeField(s, nameof(lineHeight));
				SerializeField(s, nameof(columnWidth));
				SerializeField(s, nameof(revealedCoef));
				SerializeField(s, nameof(teensyRandomCoef));
				SerializeField(s, nameof(lumsThreshold_4));
				SerializeField(s, nameof(lumsThreshold_5));
				SerializeField(s, nameof(lumsThreshold_6));
				SerializeField(s, nameof(lumsThreshold_3_RandomCoef));
				SerializeField(s, nameof(lumsThreshold_4_RandomCoef));
				SerializeField(s, nameof(lumsThreshold_5_RandomCoef));
				SerializeField(s, nameof(lumsThreshold_6_RandomCoef));
				SerializeField(s, nameof(frameRandomCoef));
				SerializeField(s, nameof(petRandomCoef));
				SerializeField(s, nameof(teensyIconPath));
				SerializeField(s, nameof(petIconPath));
				SerializeField(s, nameof(frameIconPath));
				SerializeField(s, nameof(lumIconPath));
				SerializeField(s, nameof(teensyIconOffset));
				SerializeField(s, nameof(petIconOffset));
				SerializeField(s, nameof(frameIconOffset));
				SerializeField(s, nameof(lumIconOffset));
				SerializeField(s, nameof(iconAnimStand));
				SerializeField(s, nameof(iconAnimRevealed));
				SerializeField(s, nameof(hideMenuCoef));
				SerializeField(s, nameof(petRewardCount));
				SerializeField(s, nameof(teensyRewardCount));
				SerializeField(s, nameof(lums_3_RewardCount));
				SerializeField(s, nameof(lums_4_RewardCount));
				SerializeField(s, nameof(lums_5_RewardCount));
				SerializeField(s, nameof(lums_6_RewardCount));
				SerializeField(s, nameof(frameRewardCount));
				SerializeField(s, nameof(musicEnterEvent));
				SerializeField(s, nameof(musicWinEvent));
				SerializeField(s, nameof(musicStopEvent));
				SerializeField(s, nameof(fadeToBlackDuration));
				SerializeField(s, nameof(rewardIconOffsetWidth));
				SerializeField(s, nameof(rewardIconOffsetHeight));
				SerializeField(s, nameof(speedBlend));
				SerializeField(s, nameof(speedMin));
				SerializeField(s, nameof(speedMax));
				SerializeField(s, nameof(blendAtSpeedMin));
				SerializeField(s, nameof(blendAtSpeedMax));
				SerializeField(s, nameof(dalleFramePath));
				SerializeField(s, nameof(dalleLumPath));
				SerializeField(s, nameof(dalleNeutralPath));
				SerializeField(s, nameof(dallePetPath));
				SerializeField(s, nameof(dalleTeensyPath));
				SerializeField(s, nameof(iconFadeAlpha));
				SerializeField(s, nameof(dalleFadeAlpha));
				SerializeField(s, nameof(cameraFX));
				SerializeField(s, nameof(fireworkFX));
				SerializeField(s, nameof(fireworksOffsets));
				SerializeField(s, nameof(minTimeBetweenFireworks));
				SerializeField(s, nameof(maxTimeBetweenFireworks));
				SerializeField(s, nameof(iconFadeColor));
				SerializeField(s, nameof(timeBetweenRewardIconMove));
				SerializeField(s, nameof(looseRandomCoef));
				SerializeField(s, nameof(rewardsOrder));
				SerializeField(s, nameof(debugRewardFilePath));
				SerializeField(s, nameof(delayBeforeReward));
				SerializeField(s, nameof(digShapeRadiusSpeed));
				SerializeField(s, nameof(scratchStopTime));
				SerializeField(s, nameof(scratchAccelTime));
				SerializeField(s, nameof(scratchMinSpeed));
				SerializeField(s, nameof(scratchMaxSpeed));
				SerializeField(s, nameof(scratchStepSpeed));
				SerializeField(s, nameof(scratchAcceleration));
				SerializeField(s, nameof(scratchDeceleration));
				SerializeField(s, nameof(scratchShapeEnabled));
				SerializeField(s, nameof(textRewardScaleStart));
				SerializeField(s, nameof(textRewardScaleEnd));
				SerializeField(s, nameof(textRewardScaleDuration));
				SerializeField(s, nameof(textRewardAlphaStart));
				SerializeField(s, nameof(textRewardAlphaEnd));
				SerializeField(s, nameof(textRewardAlphaDuration));
				SerializeField(s, nameof(textRewardTypeDelay));
				SerializeField(s, nameof(murphyFingerFadeOutDuration));
				SerializeField(s, nameof(textRewardDelay));
				SerializeField(s, nameof(screenDarkerAlphaStart));
				SerializeField(s, nameof(screenDarkerAlphaEnd));
				SerializeField(s, nameof(screenDarkerAlphaStartDuration));
				SerializeField(s, nameof(screenDarkerAlphaEndDuration));
				SerializeField(s, nameof(iconFadeOutDuration));
				SerializeField(s, nameof(iconFadeInDelay));
				SerializeField(s, nameof(iconFadeInDuration));
			} else {
				SerializeField(s, nameof(regionPath));
				SerializeField(s, nameof(startPos));
				SerializeField(s, nameof(lineHeight));
				SerializeField(s, nameof(columnWidth));
				SerializeField(s, nameof(revealedCoef));
				SerializeField(s, nameof(teensyRandomCoef));
				SerializeField(s, nameof(lumsThreshold_4));
				SerializeField(s, nameof(lumsThreshold_5));
				SerializeField(s, nameof(lumsThreshold_6));
				SerializeField(s, nameof(lumsThreshold_3_RandomCoef));
				SerializeField(s, nameof(lumsThreshold_4_RandomCoef));
				SerializeField(s, nameof(lumsThreshold_5_RandomCoef));
				SerializeField(s, nameof(lumsThreshold_6_RandomCoef));
				SerializeField(s, nameof(frameRandomCoef));
				SerializeField(s, nameof(petRandomCoef));
				SerializeField(s, nameof(teensyIconPath));
				SerializeField(s, nameof(petIconPath));
				SerializeField(s, nameof(frameIconPath));
				SerializeField(s, nameof(lumIconPath));
				SerializeField(s, nameof(teensyIconOffset));
				SerializeField(s, nameof(petIconOffset));
				SerializeField(s, nameof(frameIconOffset));
				SerializeField(s, nameof(lumIconOffset));
				SerializeField(s, nameof(iconAnimStand));
				SerializeField(s, nameof(iconAnimRevealed));
				SerializeField(s, nameof(hideMenuCoef));
				SerializeField(s, nameof(petRewardCount));
				SerializeField(s, nameof(teensyRewardCount));
				SerializeField(s, nameof(lums_3_RewardCount));
				SerializeField(s, nameof(lums_4_RewardCount));
				SerializeField(s, nameof(lums_5_RewardCount));
				SerializeField(s, nameof(lums_6_RewardCount));
				SerializeField(s, nameof(frameRewardCount));
				SerializeField(s, nameof(fadeToBlackDuration));
				SerializeField(s, nameof(rewardIconOffsetWidth));
				SerializeField(s, nameof(rewardIconOffsetHeight));
				SerializeField(s, nameof(speedBlend));
				SerializeField(s, nameof(speedMin));
				SerializeField(s, nameof(speedMax));
				SerializeField(s, nameof(blendAtSpeedMin));
				SerializeField(s, nameof(blendAtSpeedMax));
				SerializeField(s, nameof(dalleFramePath));
				SerializeField(s, nameof(dalleLumPath));
				SerializeField(s, nameof(dalleNeutralPath));
				SerializeField(s, nameof(dallePetPath));
				SerializeField(s, nameof(dalleTeensyPath));
				SerializeField(s, nameof(iconFadeAlpha));
				SerializeField(s, nameof(dalleFadeAlpha));
				SerializeField(s, nameof(cameraFX));
				SerializeField(s, nameof(fireworkFX));
				SerializeField(s, nameof(fireworksOffsets));
				SerializeField(s, nameof(minTimeBetweenFireworks));
				SerializeField(s, nameof(maxTimeBetweenFireworks));
				SerializeField(s, nameof(iconFadeColor));
				SerializeField(s, nameof(timeBetweenRewardIconMove));
				SerializeField(s, nameof(looseRandomCoef));
				SerializeField(s, nameof(rewardsOrder));
				SerializeField(s, nameof(debugRewardFilePath));
				SerializeField(s, nameof(delayBeforeReward));
				SerializeField(s, nameof(digShapeRadiusSpeed));
				SerializeField(s, nameof(scratchStopTime));
				SerializeField(s, nameof(scratchAccelTime));
				SerializeField(s, nameof(scratchMinSpeed));
				SerializeField(s, nameof(scratchMaxSpeed));
				SerializeField(s, nameof(scratchStepSpeed));
				SerializeField(s, nameof(scratchAcceleration));
				SerializeField(s, nameof(scratchDeceleration));
				SerializeField(s, nameof(scratchShapeEnabled));
			}
		}
		public override uint? ClassCRC => 0x24B33A58;
	}
}

