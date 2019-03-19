using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AdventureManager_Template : TemplateObj {
		[Serialize("maps"                                                  )] public CMap<StringID, RLC_Map> maps;
		[Serialize("adventures"                                            )] public CMap<StringID, RLC_Adventure> adventures;
		[Serialize("deprecatedMaps"                                        )] public CMap<PathRef, uint> deprecatedMaps;
		[Serialize("deprecatedAdventures"                                  )] public CMap<PathRef, uint> deprecatedAdventures;
		[Serialize("MagnifyingGlassWeight"                                 )] public CMap<uint, RLC_MagnifyingGlass> MagnifyingGlassWeight;
		[Serialize("bonusMapRandRangeMin"                                  )] public uint bonusMapRandRangeMin;
		[Serialize("bonusMapRandRangeMax"                                  )] public uint bonusMapRandRangeMax;
		[Serialize("challengeMapRandRangeMin"                              )] public uint challengeMapRandRangeMin;
		[Serialize("challengeMapRandRangeMax"                              )] public uint challengeMapRandRangeMax;
		[Serialize("challengeMapActive"                                    )] public bool challengeMapActive;
		[Serialize("bonusMapActive"                                        )] public bool bonusMapActive;
		[Serialize("queenMapActive"                                        )] public bool queenMapActive;
		[Serialize("findCharlieFrequency"                                  )] public CList<uint> findCharlieFrequency;
		[Serialize("findCharlieIntroduction"                               )] public uint findCharlieIntroduction;
		[Serialize("findCharlieSpawnChance"                                )] public float findCharlieSpawnChance;
		[Serialize("findCharlieTeaseDuration"                              )] public float findCharlieTeaseDuration;
		[Serialize("findCharlieTeaseCountdownMin"                          )] public float findCharlieTeaseCountdownMin;
		[Serialize("findCharlieTeaseCountdownMax"                          )] public float findCharlieTeaseCountdownMax;
		[Serialize("RegionGfxConfig"                                       )] public CArray<Generic<RLC_RegionGfxConfig>> RegionGfxConfig;
		[Serialize("defaultLineRootPrimitiveParam"                         )] public GFXPrimitiveParam defaultLineRootPrimitiveParam;
		[Serialize("useNextRegionSelection"                                )] public bool useNextRegionSelection;
		[Serialize("nextRegionSelectionConfirmation"                       )] public bool nextRegionSelectionConfirmation;
		[Serialize("blowOnceIfMultipleRegionsToReval"                      )] public bool blowOnceIfMultipleRegionsToReval;
		[Serialize("delayAfterBlowing"                                     )] public float delayAfterBlowing;
		[Serialize("nextRegionTravelMarkDistMinOldMarks"                   )] public float nextRegionTravelMarkDistMinOldMarks;
		[Serialize("nextRegionTravelMarkDistMinEggCages"                   )] public float nextRegionTravelMarkDistMinEggCages;
		[Serialize("nextRegionTravelMarkDistMinRegionName"                 )] public float nextRegionTravelMarkDistMinRegionName;
		[Serialize("computeTravelMarkMaxTries"                             )] public uint computeTravelMarkMaxTries;
		[Serialize("checkTravelMarkInsideShape"                            )] public bool checkTravelMarkInsideShape;
		[Serialize("travelMarkFlipChance"                                  )] public float travelMarkFlipChance;
		[Serialize("travelMarkRotatePiChance"                              )] public float travelMarkRotatePiChance;
		[Serialize("travelMarkRotateAngleMaxDegree"                        )] public float travelMarkRotateAngleMaxDegree;
		[Serialize("travelMarkMinScaleX"                                   )] public float travelMarkMinScaleX;
		[Serialize("travelMarkMaxScaleX"                                   )] public float travelMarkMaxScaleX;
		[Serialize("travelMarkMinScaleY"                                   )] public float travelMarkMinScaleY;
		[Serialize("travelMarkMaxScaleY"                                   )] public float travelMarkMaxScaleY;
		[Serialize("travelMarkMultiplyScaleXtoY"                           )] public bool travelMarkMultiplyScaleXtoY;
		[Serialize("travelMarksApplyRegionNameColor"                       )] public bool travelMarksApplyRegionNameColor;
		[Serialize("travelMarksNbMaxToDisplay"                             )] public uint travelMarksNbMaxToDisplay;
		[Serialize("travelMarksNbMaxToDisplayByUnlockedRegionsNb"          )] public CList<uint> travelMarksNbMaxToDisplayByUnlockedRegionsNb;
		[Serialize("travelMarksCountdownNbFade"                            )] public uint travelMarksCountdownNbFade;
		[Serialize("travelMarksPctFade"                                    )] public float travelMarksPctFade;
		[Serialize("travelMarksAlphaMax"                                   )] public float travelMarksAlphaMax;
		[Serialize("nextRegionEggCageSpawnZ"                               )] public float nextRegionEggCageSpawnZ;
		[Serialize("nextRegionEggCageForcedSpawningNb"                     )] public uint nextRegionEggCageForcedSpawningNb;
		[Serialize("nextRegionBoatSpawnZ"                                  )] public float nextRegionBoatSpawnZ;
		[Serialize("nextRegionBoatScale"                                   )] public float nextRegionBoatScale;
		[Serialize("nextRegionBoatShowDuration"                            )] public float nextRegionBoatShowDuration;
		[Serialize("nextRegionBoatSailingDuration"                         )] public float nextRegionBoatSailingDuration;
		[Serialize("nextRegionBoatDisappearingDuration"                    )] public float nextRegionBoatDisappearingDuration;
		[Serialize("nextRegionBoatSailingTangentSize"                      )] public float nextRegionBoatSailingTangentSize;
		[Serialize("eggCageAnimSpawnFallEachTime"                          )] public bool eggCageAnimSpawnFallEachTime;
		[Serialize("eggCageSelectionPath"                                  )] public PathRef eggCageSelectionPath;
		[Serialize("cameraShowsEggCageSpawning"                            )] public bool cameraShowsEggCageSpawning;
		[Serialize("cameraShowsEggCageSpawningDelay"                       )] public float cameraShowsEggCageSpawningDelay;
		[Serialize("cameraShowsEggCageRevealing"                           )] public bool cameraShowsEggCageRevealing;
		[Serialize("cameraShowsEggCageRevealingDelay"                      )] public float cameraShowsEggCageRevealingDelay;
		[Serialize("nextRegionChoiceNb"                                    )] public CList<uint> nextRegionChoiceNb;
		[Serialize("NextRegionRandom_NewRegionRevealedForcedEggCageSpawnNb")] public uint NextRegionRandom_NewRegionRevealedForcedEggCageSpawnNb;
		[Serialize("NextRegionRandomWeight_NewRegionRevealed"              )] public float NextRegionRandomWeight_NewRegionRevealed;
		[Serialize("NextRegionRandomWeight_Default"                        )] public float NextRegionRandomWeight_Default;
		[Serialize("NextRegionRandomWeight_LastAdventureRegion"            )] public float NextRegionRandomWeight_LastAdventureRegion;
		[Serialize("NextRegionRandomWeight_ChosenMultiplier"               )] public float NextRegionRandomWeight_ChosenMultiplier;
		[Serialize("NextRegionEggSameRegionInARowCptToExcludeIt"           )] public uint NextRegionEggSameRegionInARowCptToExcludeIt;
		[Serialize("MagnifyingGlassAppearanceAdventureNb"                  )] public uint MagnifyingGlassAppearanceAdventureNb;
		[Serialize("MagnifyingGlassTutorialForcedEggCageSpawnNb"           )] public uint MagnifyingGlassTutorialForcedEggCageSpawnNb;
		[Serialize("DragTutoHandPath"                                      )] public Path DragTutoHandPath;
		[Serialize("DragTutoEggPath"                                       )] public Path DragTutoEggPath;
		[Serialize("DragTutoCirclePath"                                    )] public Path DragTutoCirclePath;
		[Serialize("GraphicalFamilyTextLeftIcons"                          )] public CMap<RLC_GraphicalFamily, Path> GraphicalFamilyTextLeftIcons;
		[Serialize("GraphicalFamilyTextRightIcons"                         )] public CMap<RLC_GraphicalFamily, Path> GraphicalFamilyTextRightIcons;
		[Serialize("TutoNewElixir3DPath"                                   )] public PathRef TutoNewElixir3DPath;
		[Serialize("TutoIconGemPath"                                       )] public Path TutoIconGemPath;
		[Serialize("SmallTutoIconGemPath"                                  )] public Path SmallTutoIconGemPath;
		[Serialize("TutoIconMapPath"                                       )] public Path TutoIconMapPath;
		[Serialize("TutoIconLevelPath"                                     )] public Path TutoIconLevelPath;
		[Serialize("TutoIconLevelLumsPath"                                 )] public Path TutoIconLevelLumsPath;
		[Serialize("TutoIconLevelEnemyPath"                                )] public Path TutoIconLevelEnemyPath;
		[Serialize("TutoIconLevelExploPath"                                )] public Path TutoIconLevelExploPath;
		[Serialize("TutoIconLevelTimePath"                                 )] public Path TutoIconLevelTimePath;
		[Serialize("TutoIconTreePath"                                      )] public Path TutoIconTreePath;
		[Serialize("TutoIconShopPath"                                      )] public Path TutoIconShopPath;
		[Serialize("TutoIconFoodPath"                                      )] public Path TutoIconFoodPath;
		[Serialize("TutoIconMagnetPath"                                    )] public Path TutoIconMagnetPath;
		[Serialize("TutoIconShieldPath"                                    )] public Path TutoIconShieldPath;
		[Serialize("TutoIconRadarPath"                                     )] public Path TutoIconRadarPath;
		[Serialize("TutoIconSandclockPath"                                 )] public Path TutoIconSandclockPath;
		[Serialize("TutoIconGameCenterPath"                                )] public Path TutoIconGameCenterPath;
		[Serialize("TutoIconGameServicesPath"                              )] public Path TutoIconGameServicesPath;
		[Serialize("TutoIconGameCirclePath"                                )] public Path TutoIconGameCirclePath;
		[Serialize("TutoIconPlayAppleTVPath"                               )] public Path TutoIconPlayAppleTVPath;
		[Serialize("TutoIconsForPad"                                       )] public CMap<string, Path> TutoIconsForPad;
		[Serialize("TutoNextSteps"                                         )] public CMap<string, string> TutoNextSteps;
		[Serialize("TutoIconFacebookPath"                                  )] public Path TutoIconFacebookPath;
		[Serialize("TutoIconFacebookSmallPath"                             )] public Path TutoIconFacebookSmallPath;
		[Serialize("TutoIconSinaweiboPath"                                 )] public Path TutoIconSinaweiboPath;
		[Serialize("TutoIconSinaWeiboSmallPath"                            )] public Path TutoIconSinaWeiboSmallPath;
		[Serialize("TreeHandOnMapButtonAppearTimer"                        )] public float TreeHandOnMapButtonAppearTimer;
		[Serialize("TreeHandOnMapButtonResetTimer"                         )] public float TreeHandOnMapButtonResetTimer;
		[Serialize("EggVisualConfigs"                                      )] public CList<RLC_EggVisualConfig> EggVisualConfigs;
		[Serialize("EveryPlayMetaDataKits"                                 )] public CMap<RLC_GraphicalKit, string> EveryPlayMetaDataKits;
		[Serialize("EveryPlayMetaDataMapTypes"                             )] public CMap<RLC_MapType, string> EveryPlayMetaDataMapTypes;
		[Serialize("EveryPlayMetaDataCostumes"                             )] public CMap<StringID, string> EveryPlayMetaDataCostumes;
		[Serialize("WwiseGUID_NextRegion_Medieval"                         )] public StringID WwiseGUID_NextRegion_Medieval;
		[Serialize("WwiseGUID_NextRegion_ToadStory"                        )] public StringID WwiseGUID_NextRegion_ToadStory;
		[Serialize("WwiseGUID_NextRegion_Greece"                           )] public StringID WwiseGUID_NextRegion_Greece;
		[Serialize("WwiseGUID_NextRegion_UnderWater"                       )] public StringID WwiseGUID_NextRegion_UnderWater;
		[Serialize("WwiseGUID_NextRegion_Shaolin"                          )] public StringID WwiseGUID_NextRegion_Shaolin;
		[Serialize("WwiseGUID_NextRegion_LandOfTheDead"                    )] public StringID WwiseGUID_NextRegion_LandOfTheDead;
		[Serialize("WwiseGUID_NextRegion_Desert"                           )] public StringID WwiseGUID_NextRegion_Desert;
		[Serialize("BoatPath"                                              )] public Path BoatPath;
		[Serialize("BoatTeaseCountDownMin"                                 )] public float BoatTeaseCountDownMin;
		[Serialize("BoatTeaseCountDownMax"                                 )] public float BoatTeaseCountDownMax;
		[Serialize("ForcedGreeceFirstLevelPathRef"                         )] public PathRef ForcedGreeceFirstLevelPathRef;
		[Serialize("AdventureSequenceOnBoardingFinished"                   )] public uint AdventureSequenceOnBoardingFinished;
		[Serialize("WwiseGUID_eggCageSpawningRtpc"                         )] public StringID WwiseGUID_eggCageSpawningRtpc;
		[Serialize("eggCageSpawningRtpcMaxValue"                           )] public StringID eggCageSpawningRtpcMaxValue;
		[Serialize("nextRegionCameraSpeedToHideTelescopeButton"            )] public float nextRegionCameraSpeedToHideTelescopeButton;
		[Serialize("nextRegionCameraDoubleTapZoomOutAllowed"               )] public bool nextRegionCameraDoubleTapZoomOutAllowed;
		[Serialize("nextRegionCameraAutoZoomOutEndOfRitual"                )] public bool nextRegionCameraAutoZoomOutEndOfRitual;
		[Serialize("nextRegionCameraEggSelectionForceZoomIn"               )] public bool nextRegionCameraEggSelectionForceZoomIn;
		[Serialize("nextRegionCameraEggSelectionCancelledRestoreZoom"      )] public bool nextRegionCameraEggSelectionCancelledRestoreZoom;
		[Serialize("nextRegionCameraTelescopeRestoreZoom"                  )] public bool nextRegionCameraTelescopeRestoreZoom;
		[Serialize("nextRegionCaptainAnimStandVariationTimerMin"           )] public float nextRegionCaptainAnimStandVariationTimerMin;
		[Serialize("nextRegionCaptainAnimStandVariationTimerMax"           )] public float nextRegionCaptainAnimStandVariationTimerMax;
		[Serialize("pressCaptainToRevealTelescope"                         )] public bool pressCaptainToRevealTelescope;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maps));
			SerializeField(s, nameof(adventures));
			SerializeField(s, nameof(deprecatedMaps));
			SerializeField(s, nameof(deprecatedAdventures));
			SerializeField(s, nameof(MagnifyingGlassWeight));
			SerializeField(s, nameof(bonusMapRandRangeMin));
			SerializeField(s, nameof(bonusMapRandRangeMax));
			SerializeField(s, nameof(challengeMapRandRangeMin));
			SerializeField(s, nameof(challengeMapRandRangeMax));
			SerializeField(s, nameof(challengeMapActive));
			SerializeField(s, nameof(bonusMapActive));
			SerializeField(s, nameof(queenMapActive));
			SerializeField(s, nameof(findCharlieFrequency));
			SerializeField(s, nameof(findCharlieIntroduction));
			SerializeField(s, nameof(findCharlieSpawnChance));
			SerializeField(s, nameof(findCharlieTeaseDuration));
			SerializeField(s, nameof(findCharlieTeaseCountdownMin));
			SerializeField(s, nameof(findCharlieTeaseCountdownMax));
			SerializeField(s, nameof(RegionGfxConfig));
			SerializeField(s, nameof(defaultLineRootPrimitiveParam));
			SerializeField(s, nameof(useNextRegionSelection));
			SerializeField(s, nameof(nextRegionSelectionConfirmation));
			SerializeField(s, nameof(blowOnceIfMultipleRegionsToReval));
			SerializeField(s, nameof(delayAfterBlowing));
			SerializeField(s, nameof(nextRegionTravelMarkDistMinOldMarks));
			SerializeField(s, nameof(nextRegionTravelMarkDistMinEggCages));
			SerializeField(s, nameof(nextRegionTravelMarkDistMinRegionName));
			SerializeField(s, nameof(computeTravelMarkMaxTries));
			SerializeField(s, nameof(checkTravelMarkInsideShape));
			SerializeField(s, nameof(travelMarkFlipChance));
			SerializeField(s, nameof(travelMarkRotatePiChance));
			SerializeField(s, nameof(travelMarkRotateAngleMaxDegree));
			SerializeField(s, nameof(travelMarkMinScaleX));
			SerializeField(s, nameof(travelMarkMaxScaleX));
			SerializeField(s, nameof(travelMarkMinScaleY));
			SerializeField(s, nameof(travelMarkMaxScaleY));
			SerializeField(s, nameof(travelMarkMultiplyScaleXtoY));
			SerializeField(s, nameof(travelMarksApplyRegionNameColor));
			SerializeField(s, nameof(travelMarksNbMaxToDisplay));
			SerializeField(s, nameof(travelMarksNbMaxToDisplayByUnlockedRegionsNb));
			SerializeField(s, nameof(travelMarksCountdownNbFade));
			SerializeField(s, nameof(travelMarksPctFade));
			SerializeField(s, nameof(travelMarksAlphaMax));
			SerializeField(s, nameof(nextRegionEggCageSpawnZ));
			SerializeField(s, nameof(nextRegionEggCageForcedSpawningNb));
			SerializeField(s, nameof(nextRegionBoatSpawnZ));
			SerializeField(s, nameof(nextRegionBoatScale));
			SerializeField(s, nameof(nextRegionBoatShowDuration));
			SerializeField(s, nameof(nextRegionBoatSailingDuration));
			SerializeField(s, nameof(nextRegionBoatDisappearingDuration));
			SerializeField(s, nameof(nextRegionBoatSailingTangentSize));
			SerializeField(s, nameof(eggCageAnimSpawnFallEachTime));
			SerializeField(s, nameof(eggCageSelectionPath));
			SerializeField(s, nameof(cameraShowsEggCageSpawning));
			SerializeField(s, nameof(cameraShowsEggCageSpawningDelay));
			SerializeField(s, nameof(cameraShowsEggCageRevealing));
			SerializeField(s, nameof(cameraShowsEggCageRevealingDelay));
			SerializeField(s, nameof(nextRegionChoiceNb));
			SerializeField(s, nameof(NextRegionRandom_NewRegionRevealedForcedEggCageSpawnNb));
			SerializeField(s, nameof(NextRegionRandomWeight_NewRegionRevealed));
			SerializeField(s, nameof(NextRegionRandomWeight_Default));
			SerializeField(s, nameof(NextRegionRandomWeight_LastAdventureRegion));
			SerializeField(s, nameof(NextRegionRandomWeight_ChosenMultiplier));
			SerializeField(s, nameof(NextRegionEggSameRegionInARowCptToExcludeIt));
			SerializeField(s, nameof(MagnifyingGlassAppearanceAdventureNb));
			SerializeField(s, nameof(MagnifyingGlassTutorialForcedEggCageSpawnNb));
			SerializeField(s, nameof(DragTutoHandPath));
			SerializeField(s, nameof(DragTutoEggPath));
			SerializeField(s, nameof(DragTutoCirclePath));
			SerializeField(s, nameof(GraphicalFamilyTextLeftIcons));
			SerializeField(s, nameof(GraphicalFamilyTextRightIcons));
			SerializeField(s, nameof(TutoNewElixir3DPath));
			SerializeField(s, nameof(TutoIconGemPath));
			SerializeField(s, nameof(SmallTutoIconGemPath));
			SerializeField(s, nameof(TutoIconMapPath));
			SerializeField(s, nameof(TutoIconLevelPath));
			SerializeField(s, nameof(TutoIconLevelLumsPath));
			SerializeField(s, nameof(TutoIconLevelEnemyPath));
			SerializeField(s, nameof(TutoIconLevelExploPath));
			SerializeField(s, nameof(TutoIconLevelTimePath));
			SerializeField(s, nameof(TutoIconTreePath));
			SerializeField(s, nameof(TutoIconShopPath));
			SerializeField(s, nameof(TutoIconFoodPath));
			SerializeField(s, nameof(TutoIconMagnetPath));
			SerializeField(s, nameof(TutoIconShieldPath));
			SerializeField(s, nameof(TutoIconRadarPath));
			SerializeField(s, nameof(TutoIconSandclockPath));
			SerializeField(s, nameof(TutoIconGameCenterPath));
			SerializeField(s, nameof(TutoIconGameServicesPath));
			SerializeField(s, nameof(TutoIconGameCirclePath));
			SerializeField(s, nameof(TutoIconPlayAppleTVPath));
			SerializeField(s, nameof(TutoIconsForPad));
			SerializeField(s, nameof(TutoNextSteps));
			SerializeField(s, nameof(TutoIconFacebookPath));
			SerializeField(s, nameof(TutoIconFacebookSmallPath));
			SerializeField(s, nameof(TutoIconSinaweiboPath));
			SerializeField(s, nameof(TutoIconSinaWeiboSmallPath));
			SerializeField(s, nameof(TreeHandOnMapButtonAppearTimer));
			SerializeField(s, nameof(TreeHandOnMapButtonResetTimer));
			SerializeField(s, nameof(EggVisualConfigs));
			SerializeField(s, nameof(EveryPlayMetaDataKits));
			SerializeField(s, nameof(EveryPlayMetaDataMapTypes));
			SerializeField(s, nameof(EveryPlayMetaDataCostumes));
			SerializeField(s, nameof(WwiseGUID_NextRegion_Medieval));
			SerializeField(s, nameof(WwiseGUID_NextRegion_ToadStory));
			SerializeField(s, nameof(WwiseGUID_NextRegion_Greece));
			SerializeField(s, nameof(WwiseGUID_NextRegion_UnderWater));
			SerializeField(s, nameof(WwiseGUID_NextRegion_Shaolin));
			SerializeField(s, nameof(WwiseGUID_NextRegion_LandOfTheDead));
			SerializeField(s, nameof(WwiseGUID_NextRegion_Desert));
			SerializeField(s, nameof(BoatPath));
			SerializeField(s, nameof(BoatTeaseCountDownMin));
			SerializeField(s, nameof(BoatTeaseCountDownMax));
			SerializeField(s, nameof(ForcedGreeceFirstLevelPathRef));
			SerializeField(s, nameof(AdventureSequenceOnBoardingFinished));
			SerializeField(s, nameof(WwiseGUID_eggCageSpawningRtpc));
			SerializeField(s, nameof(eggCageSpawningRtpcMaxValue));
			SerializeField(s, nameof(nextRegionCameraSpeedToHideTelescopeButton));
			SerializeField(s, nameof(nextRegionCameraDoubleTapZoomOutAllowed));
			SerializeField(s, nameof(nextRegionCameraAutoZoomOutEndOfRitual));
			SerializeField(s, nameof(nextRegionCameraEggSelectionForceZoomIn));
			SerializeField(s, nameof(nextRegionCameraEggSelectionCancelledRestoreZoom));
			SerializeField(s, nameof(nextRegionCameraTelescopeRestoreZoom));
			SerializeField(s, nameof(nextRegionCaptainAnimStandVariationTimerMin));
			SerializeField(s, nameof(nextRegionCaptainAnimStandVariationTimerMax));
			SerializeField(s, nameof(pressCaptainToRevealTelescope));
		}
		public override uint? ClassCRC => 0xFA1ACAA2;
	}
}
