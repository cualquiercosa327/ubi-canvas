using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class RO2_GeyserPlatformAIComponent_Template : GraphicComponent_Template {
		[Serialize("attachBone"              )] public StringID attachBone;
		[Serialize("ignoreActorScale"        )] public bool ignoreActorScale;
		[Serialize("length"                  )] public float length;
		[Serialize("lockLength"              )] public bool lockLength;
		[Serialize("lockAngle"               )] public bool lockAngle;
		[Serialize("lockWidth"               )] public bool lockWidth;
		[Serialize("growTargetSmoothFactor"  )] public float growTargetSmoothFactor;
		[Serialize("growSmoothFactor"        )] public float growSmoothFactor;
		[Serialize("shrinkTargetSmoothFactor")] public float shrinkTargetSmoothFactor;
		[Serialize("shrinkSmoothFactor"      )] public float shrinkSmoothFactor;
		[Serialize("lengthVariationAmplitude")] public float lengthVariationAmplitude;
		[Serialize("lengthVariationFrequency")] public float lengthVariationFrequency;
		[Serialize("jumpThreshold"           )] public float jumpThreshold;
		[Serialize("triggerOnHit"            )] public bool triggerOnHit;
		[Serialize("triggerOnHitDelay"       )] public float triggerOnHitDelay;
		[Serialize("autoCloseDelay"          )] public float autoCloseDelay;
		[Serialize("startOpen"               )] public bool startOpen;
		[Serialize("changeStateOnTrigger"    )] public bool changeStateOnTrigger;
		[Serialize("closeOnTap"              )] public bool closeOnTap;
		[Serialize("closeOnTapDuration"      )] public float closeOnTapDuration;
		[Serialize("material"                )] public GFXMaterialSerializable material;
		[Serialize("patchStartOffset"        )] public float patchStartOffset;
		[Serialize("patchLengthOffset"       )] public float patchLengthOffset;
		[Serialize("patchLengthMultiplier"   )] public float patchLengthMultiplier;
		[Serialize("patchWidthBottom"        )] public float patchWidthBottom;
		[Serialize("patchWidthTop"           )] public float patchWidthTop;
		[Serialize("tileLength"              )] public float tileLength;
		[Serialize("tileWidth"               )] public float tileWidth;
		[Serialize("uvScrollSpeed"           )] public Vector2 uvScrollSpeed;
		[Serialize("patchFadeInLength"       )] public float patchFadeInLength;
		[Serialize("patchFadeOutLength"      )] public float patchFadeOutLength;
		[Serialize("zOffset"                 )] public float zOffset;
		[Serialize("tessellationLength"      )] public float tessellationLength;
		[Serialize("forceModifier"           )] public PhysForceModifierPolygon_Template forceModifier;
		[Serialize("forceDirection"          )] public Vector2 forceDirection;
		[Serialize("forceLengthOffset"       )] public float forceLengthOffset;
		[Serialize("forceLengthMultiplier"   )] public float forceLengthMultiplier;
		[Serialize("forceWidthBottom"        )] public float forceWidthBottom;
		[Serialize("forceWidthTop"           )] public float forceWidthTop;
		[Serialize("forceFadeOutLength"      )] public float forceFadeOutLength;
		[Serialize("overrideDisableForce"    )] public bool overrideDisableForce;
		[Serialize("usePlatform"             )] public bool usePlatform;
		[Serialize("platformMaterial"        )] public Path platformMaterial;
		[Serialize("platformWidth"           )] public float platformWidth;
		[Serialize("platformBone"            )] public StringID platformBone;
		[Serialize("platformPolyline"        )] public StringID platformPolyline;
		[Serialize("platformLengthMultiplier")] public float platformLengthMultiplier;
		[Serialize("platformLengthOffset"    )] public float platformLengthOffset;
		[Serialize("platformHeightSink"      )] public float platformHeightSink;
		[Serialize("fx"                      )] public StringID fx;
		[Serialize("fxUseTransform"          )] public bool fxUseTransform;
		[Serialize("fxGeneratorType"         )] public GeneratorType_B fxGeneratorType;
		[Serialize("fxGenerators"            )] public CList<StringID> fxGenerators;
		[Serialize("fxLengthOffset"          )] public float fxLengthOffset;
		[Serialize("fxLengthMultiplier"      )] public float fxLengthMultiplier;
		[Serialize("fxWidth"                 )] public float fxWidth;
		[Serialize("fxLifetimeOffset"        )] public float fxLifetimeOffset;
		[Serialize("fxLifetimeMultiplier"    )] public float fxLifetimeMultiplier;
		[Serialize("fxCollision"             )] public StringID fxCollision;
		[Serialize("fxOnClose"               )] public StringID fxOnClose;
		[Serialize("fxOnCloseThreshold"      )] public float fxOnCloseThreshold;
		[Serialize("animOpened"              )] public StringID animOpened;
		[Serialize("animClosed"              )] public StringID animClosed;
		[Serialize("animOpenToClose"         )] public StringID animOpenToClose;
		[Serialize("useStim"                 )] public bool useStim;
		[Serialize("jumpToPlatform"          )] public bool jumpToPlatform;
		[Serialize("faction"                 )] public uint faction;
		[Serialize("registerToAIManager"     )] public bool registerToAIManager;
		[Serialize("windTunnelLevel"         )] public uint windTunnelLevel;
		[Serialize("regions"                 )] public CList<RO2_GeyserPlatformAIComponent_Template.RegionData> regions;
		[Serialize("isGeyserBehavior"        )] public bool isGeyserBehavior;
		[Serialize("widthReductionSpeed"     )] public float widthReductionSpeed;
		[Serialize("fxGeneratorType"         )] public Enum_fxGeneratorType fxGeneratorType;
		[Serialize("minAngle"                )] public Angle minAngle;
		[Serialize("maxAngle"                )] public Angle maxAngle;
		[Serialize("debugForce"              )] public int debugForce;
		[Serialize("debugPatch"              )] public int debugPatch;
		[Serialize("debugFx"                 )] public int debugFx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(attachBone));
				SerializeField(s, nameof(ignoreActorScale));
				SerializeField(s, nameof(length));
				SerializeField(s, nameof(lockLength), boolAsByte: true);
				SerializeField(s, nameof(lockAngle), boolAsByte: true);
				SerializeField(s, nameof(lockWidth), boolAsByte: true);
				SerializeField(s, nameof(growTargetSmoothFactor));
				SerializeField(s, nameof(growSmoothFactor));
				SerializeField(s, nameof(shrinkTargetSmoothFactor));
				SerializeField(s, nameof(shrinkSmoothFactor));
				SerializeField(s, nameof(lengthVariationAmplitude));
				SerializeField(s, nameof(lengthVariationFrequency));
				SerializeField(s, nameof(jumpThreshold));
				SerializeField(s, nameof(triggerOnHit), boolAsByte: true);
				SerializeField(s, nameof(triggerOnHitDelay));
				SerializeField(s, nameof(autoCloseDelay));
				SerializeField(s, nameof(startOpen), boolAsByte: true);
				SerializeField(s, nameof(changeStateOnTrigger), boolAsByte: true);
				SerializeField(s, nameof(closeOnTap), boolAsByte: true);
				SerializeField(s, nameof(closeOnTapDuration));
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(patchStartOffset));
				SerializeField(s, nameof(patchLengthOffset));
				SerializeField(s, nameof(patchLengthMultiplier));
				SerializeField(s, nameof(patchWidthBottom));
				SerializeField(s, nameof(patchWidthTop));
				SerializeField(s, nameof(tileLength));
				SerializeField(s, nameof(tileWidth));
				SerializeField(s, nameof(uvScrollSpeed));
				SerializeField(s, nameof(patchFadeInLength));
				SerializeField(s, nameof(patchFadeOutLength));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(tessellationLength));
				SerializeField(s, nameof(forceModifier));
				SerializeField(s, nameof(forceDirection));
				SerializeField(s, nameof(forceLengthOffset));
				SerializeField(s, nameof(forceLengthMultiplier));
				SerializeField(s, nameof(forceWidthBottom));
				SerializeField(s, nameof(forceWidthTop));
				SerializeField(s, nameof(forceFadeOutLength));
				SerializeField(s, nameof(overrideDisableForce));
				SerializeField(s, nameof(usePlatform), boolAsByte: true);
				SerializeField(s, nameof(platformMaterial));
				SerializeField(s, nameof(platformWidth));
				SerializeField(s, nameof(platformBone));
				SerializeField(s, nameof(platformPolyline));
				SerializeField(s, nameof(platformLengthMultiplier));
				SerializeField(s, nameof(platformLengthOffset));
				SerializeField(s, nameof(platformHeightSink));
				SerializeField(s, nameof(fxUseTransform), boolAsByte: true);
				SerializeField(s, nameof(fxGeneratorType));
				SerializeField(s, nameof(fxGenerators));
				SerializeField(s, nameof(fxLengthOffset));
				SerializeField(s, nameof(fxLengthMultiplier));
				SerializeField(s, nameof(fxWidth));
				SerializeField(s, nameof(fxLifetimeOffset));
				SerializeField(s, nameof(fxLifetimeMultiplier));
				SerializeField(s, nameof(fxCollision));
				SerializeField(s, nameof(fxOnClose));
				SerializeField(s, nameof(fxOnCloseThreshold));
				SerializeField(s, nameof(animOpened));
				SerializeField(s, nameof(animClosed));
				SerializeField(s, nameof(animOpenToClose));
				SerializeField(s, nameof(useStim), boolAsByte: true);
				SerializeField(s, nameof(jumpToPlatform), boolAsByte: true);
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(registerToAIManager), boolAsByte: true);
				SerializeField(s, nameof(windTunnelLevel));
				SerializeField(s, nameof(regions));
				SerializeField(s, nameof(isGeyserBehavior), boolAsByte: true);
				SerializeField(s, nameof(widthReductionSpeed));
				if (s.HasFlags(SerializeFlags.Flags9)) {
					SerializeField(s, nameof(minAngle));
					SerializeField(s, nameof(maxAngle));
					SerializeField(s, nameof(debugForce));
					SerializeField(s, nameof(debugPatch));
					SerializeField(s, nameof(debugFx));
				}
			} else {
				SerializeField(s, nameof(attachBone));
				SerializeField(s, nameof(ignoreActorScale));
				SerializeField(s, nameof(length));
				SerializeField(s, nameof(lockLength));
				SerializeField(s, nameof(lockAngle));
				SerializeField(s, nameof(lockWidth));
				SerializeField(s, nameof(growTargetSmoothFactor));
				SerializeField(s, nameof(growSmoothFactor));
				SerializeField(s, nameof(shrinkTargetSmoothFactor));
				SerializeField(s, nameof(shrinkSmoothFactor));
				SerializeField(s, nameof(lengthVariationAmplitude));
				SerializeField(s, nameof(lengthVariationFrequency));
				SerializeField(s, nameof(jumpThreshold));
				SerializeField(s, nameof(triggerOnHit));
				SerializeField(s, nameof(triggerOnHitDelay));
				SerializeField(s, nameof(autoCloseDelay));
				SerializeField(s, nameof(startOpen));
				SerializeField(s, nameof(changeStateOnTrigger));
				SerializeField(s, nameof(closeOnTap));
				SerializeField(s, nameof(closeOnTapDuration));
				SerializeField(s, nameof(material));
				SerializeField(s, nameof(patchStartOffset));
				SerializeField(s, nameof(patchLengthOffset));
				SerializeField(s, nameof(patchLengthMultiplier));
				SerializeField(s, nameof(patchWidthBottom));
				SerializeField(s, nameof(patchWidthTop));
				SerializeField(s, nameof(tileLength));
				SerializeField(s, nameof(tileWidth));
				SerializeField(s, nameof(uvScrollSpeed));
				SerializeField(s, nameof(patchFadeInLength));
				SerializeField(s, nameof(patchFadeOutLength));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(tessellationLength));
				SerializeField(s, nameof(forceModifier));
				SerializeField(s, nameof(forceDirection));
				SerializeField(s, nameof(forceLengthOffset));
				SerializeField(s, nameof(forceLengthMultiplier));
				SerializeField(s, nameof(forceWidthBottom));
				SerializeField(s, nameof(forceWidthTop));
				SerializeField(s, nameof(forceFadeOutLength));
				SerializeField(s, nameof(overrideDisableForce));
				SerializeField(s, nameof(usePlatform));
				SerializeField(s, nameof(platformMaterial));
				SerializeField(s, nameof(platformWidth));
				SerializeField(s, nameof(platformBone));
				SerializeField(s, nameof(platformPolyline));
				SerializeField(s, nameof(platformLengthMultiplier));
				SerializeField(s, nameof(platformLengthOffset));
				SerializeField(s, nameof(platformHeightSink));
				SerializeField(s, nameof(fx));
				SerializeField(s, nameof(fxUseTransform));
				SerializeField(s, nameof(fxGeneratorType));
				SerializeField(s, nameof(fxGenerators));
				SerializeField(s, nameof(fxLengthOffset));
				SerializeField(s, nameof(fxLengthMultiplier));
				SerializeField(s, nameof(fxWidth));
				SerializeField(s, nameof(fxLifetimeOffset));
				SerializeField(s, nameof(fxLifetimeMultiplier));
				SerializeField(s, nameof(fxCollision));
				SerializeField(s, nameof(fxOnClose));
				SerializeField(s, nameof(fxOnCloseThreshold));
				SerializeField(s, nameof(animOpened));
				SerializeField(s, nameof(animClosed));
				SerializeField(s, nameof(animOpenToClose));
				SerializeField(s, nameof(useStim));
				SerializeField(s, nameof(jumpToPlatform));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(registerToAIManager));
				SerializeField(s, nameof(windTunnelLevel));
				SerializeField(s, nameof(regions));
				SerializeField(s, nameof(isGeyserBehavior));
				SerializeField(s, nameof(widthReductionSpeed));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class RegionData : CSerializable {
			[Serialize("widthOffset" )] public float widthOffset;
			[Serialize("heightOffset")] public float heightOffset;
			[Serialize("id"          )] public StringID id;
			[Serialize("gameMaterial")] public Path gameMaterial;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(widthOffset));
				SerializeField(s, nameof(heightOffset));
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(gameMaterial));
			}
		}
		public enum GeneratorType_B {
			[Serialize("GeneratorType_Ballistic")] allistic = 0,
			[Serialize("GeneratorType_Box"      )] ox = 1,
		}
		public enum Enum_fxGeneratorType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xBA0DBA79;
	}
}

