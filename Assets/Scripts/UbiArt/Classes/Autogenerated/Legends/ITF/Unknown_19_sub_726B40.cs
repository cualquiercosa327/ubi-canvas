using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_19_sub_726B40 : CSerializable {
		[Serialize("impulseForce_Ground"            )] public float impulseForce_Ground;
		[Serialize("impulseForce_Wall"              )] public float impulseForce_Wall;
		[Serialize("impulseForce_Hit"               )] public float impulseForce_Hit;
		[Serialize("impulseForce_ShotBasic"         )] public float impulseForce_ShotBasic;
		[Serialize("impulseForce_ShotCrush"         )] public float impulseForce_ShotCrush;
		[Serialize("impulseForce_ShotUp"            )] public float impulseForce_ShotUp;
		[Serialize("impulseForce_ShotCharge"        )] public float impulseForce_ShotCharge;
		[Serialize("impulseForce_EjectY"            )] public float impulseForce_EjectY;
		[Serialize("impulseForce_Pass"              )] public float impulseForce_Pass;
		[Serialize("bounceCoefMin_x"                )] public float bounceCoefMin_x;
		[Serialize("bounceCoefMin_y"                )] public float bounceCoefMin_y;
		[Serialize("bounceCoefFactor_x"             )] public float bounceCoefFactor_x;
		[Serialize("bounceCoefFactor_y"             )] public float bounceCoefFactor_y;
		[Serialize("bounceDotUpLimit"               )] public float bounceDotUpLimit;
		[Serialize("bounceDotDownLimit"             )] public float bounceDotDownLimit;
		[Serialize("bounceCoefMax_x"                )] public float bounceCoefMax_x;
		[Serialize("bounceCoefMax_y"                )] public float bounceCoefMax_y;
		[Serialize("ballMode_ShotBasic"             )] public Enum_ballMode_ShotBasic ballMode_ShotBasic;
		[Serialize("ballMode_ShotCrush"             )] public Enum_ballMode_ShotCrush ballMode_ShotCrush;
		[Serialize("ballMode_ShotUp"                )] public Enum_ballMode_ShotUp ballMode_ShotUp;
		[Serialize("ballMode_ShotCharge"            )] public Enum_ballMode_ShotCharge ballMode_ShotCharge;
		[Serialize("ballMode_EjectY"                )] public Enum_ballMode_EjectY ballMode_EjectY;
		[Serialize("ballMode_Pass"                  )] public Enum_ballMode_Pass ballMode_Pass;
		[Serialize("angleDir_ShotBasic"             )] public Angle angleDir_ShotBasic;
		[Serialize("angleDir_ShotCrush"             )] public Angle angleDir_ShotCrush;
		[Serialize("angleDir_ShotUp"                )] public Angle angleDir_ShotUp;
		[Serialize("angleDir_ShotCharge"            )] public Angle angleDir_ShotCharge;
		[Serialize("angleDir_EjectY"                )] public Angle angleDir_EjectY;
		[Serialize("angleDir_Pass"                  )] public Angle angleDir_Pass;
		[Serialize("angleDirAlt_ShotBasic"          )] public Angle angleDirAlt_ShotBasic;
		[Serialize("angleDirAlt_ShotCrush"          )] public Angle angleDirAlt_ShotCrush;
		[Serialize("angleDirAlt_ShotUp"             )] public Angle angleDirAlt_ShotUp;
		[Serialize("angleDirAlt_EjectY"             )] public Angle angleDirAlt_EjectY;
		[Serialize("angleDirAlt_Pass"               )] public Angle angleDirAlt_Pass;
		[Serialize("bounceCoefPass_x"               )] public float bounceCoefPass_x;
		[Serialize("bounceCoefPass_y"               )] public float bounceCoefPass_y;
		[Serialize("bounceCoefRoof"                 )] public float bounceCoefRoof;
		[Serialize("playerCol_Enabled"              )] public bool playerCol_Enabled;
		[Serialize("playerCol_ShapeRadius"          )] public float playerCol_ShapeRadius;
		[Serialize("playerCol_DisabledWhileHitting" )] public bool playerCol_DisabledWhileHitting;
		[Serialize("playerCol_AfterHitDisabledTimer")] public float playerCol_AfterHitDisabledTimer;
		[Serialize("isLethal_ShotBasic"             )] public bool isLethal_ShotBasic;
		[Serialize("isLethal_ShotCrush"             )] public bool isLethal_ShotCrush;
		[Serialize("isLethal_ShotUp"                )] public bool isLethal_ShotUp;
		[Serialize("isLethal_ShotCharge"            )] public bool isLethal_ShotCharge;
		[Serialize("isLethal_EjectY"                )] public bool isLethal_EjectY;
		[Serialize("isLethal_Pass"                  )] public bool isLethal_Pass;
		[Serialize("forceMin_x"                     )] public float forceMin_x;
		[Serialize("forceMax_x"                     )] public float forceMax_x;
		[Serialize("forceMin_y"                     )] public float forceMin_y;
		[Serialize("forceMax_y"                     )] public float forceMax_y;
		[Serialize("receivedHitType_ShotBasic"      )] public Enum_receivedHitType_ShotBasic receivedHitType_ShotBasic;
		[Serialize("receivedHitType_ShotCrush"      )] public Enum_receivedHitType_ShotCrush receivedHitType_ShotCrush;
		[Serialize("receivedHitType_ShotUp"         )] public Enum_receivedHitType_ShotUp receivedHitType_ShotUp;
		[Serialize("receivedHitType_ShotCharge"     )] public Enum_receivedHitType_ShotCharge receivedHitType_ShotCharge;
		[Serialize("receivedHitType_EjectY"         )] public Enum_receivedHitType_EjectY receivedHitType_EjectY;
		[Serialize("receivedHitType_Pass"           )] public Enum_receivedHitType_Pass receivedHitType_Pass;
		[Serialize("hitLevel_ShotBasic"             )] public uint hitLevel_ShotBasic;
		[Serialize("hitLevel_ShotCrush"             )] public uint hitLevel_ShotCrush;
		[Serialize("hitLevel_ShotUp"                )] public uint hitLevel_ShotUp;
		[Serialize("hitLevel_ShotCharge"            )] public uint hitLevel_ShotCharge;
		[Serialize("hitLevel_EjectY"                )] public uint hitLevel_EjectY;
		[Serialize("hitLevel_Pass"                  )] public uint hitLevel_Pass;
		[Serialize("hitDelay"                       )] public float hitDelay;
		[Serialize("blockingEdgeTimer"              )] public float blockingEdgeTimer;
		[Serialize("minTime_Pass"                   )] public float minTime_Pass;
		[Serialize("angleAltChoice_ShotBasic"       )] public Angle angleAltChoice_ShotBasic;
		[Serialize("angleAltChoice_ShotCrush"       )] public Angle angleAltChoice_ShotCrush;
		[Serialize("angleAltChoice_ShotUp"          )] public Angle angleAltChoice_ShotUp;
		[Serialize("angleAltChoice_ShotCharge"      )] public Angle angleAltChoice_ShotCharge;
		[Serialize("angleAltChoice_EjectY"          )] public Angle angleAltChoice_EjectY;
		[Serialize("angleAltChoice_Pass"            )] public Angle angleAltChoice_Pass;
		[Serialize("joyTrameMax"                    )] public uint joyTrameMax;
		[Serialize("impulseForceMegaHit_ShotBasic"  )] public float impulseForceMegaHit_ShotBasic;
		[Serialize("impulseForceMegaHit_ShotCrush"  )] public float impulseForceMegaHit_ShotCrush;
		[Serialize("impulseForceMegaHit_ShotUp"     )] public float impulseForceMegaHit_ShotUp;
		[Serialize("impulseForceMegaHit_ShotCharge" )] public float impulseForceMegaHit_ShotCharge;
		[Serialize("impulseForceMegaHit_EjectY"     )] public float impulseForceMegaHit_EjectY;
		[Serialize("impulseForceMegaHit_Pass"       )] public float impulseForceMegaHit_Pass;
		[Serialize("cameraRegisterDelay"            )] public float cameraRegisterDelay;
		[Serialize("megaHitCounterEnabled"          )] public bool megaHitCounterEnabled;
		[Serialize("buildMegaHitEnabled_ShotBasic"  )] public bool buildMegaHitEnabled_ShotBasic;
		[Serialize("buildMegaHitEnabled_ShotCrush"  )] public bool buildMegaHitEnabled_ShotCrush;
		[Serialize("buildMegaHitEnabled_ShotUp"     )] public bool buildMegaHitEnabled_ShotUp;
		[Serialize("buildMegaHitEnabled_ShotCharge" )] public bool buildMegaHitEnabled_ShotCharge;
		[Serialize("buildMegaHitEnabled_EjectY"     )] public bool buildMegaHitEnabled_EjectY;
		[Serialize("buildMegaHitEnabled_Pass"       )] public bool buildMegaHitEnabled_Pass;
		[Serialize("hitCountForMegaHit"             )] public uint hitCountForMegaHit;
		[Serialize("stretchAnimSpeedMin"            )] public float stretchAnimSpeedMin;
		[Serialize("animHaloTimer"                  )] public float animHaloTimer;
		[Serialize("crushGroundImmuneDuration"      )] public float crushGroundImmuneDuration;
		[Serialize("megaHitForce"                   )] public float megaHitForce;
		[Serialize("drcTapForce"                    )] public float drcTapForce;
		[Serialize("faction"                        )] public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(impulseForce_Ground));
			SerializeField(s, nameof(impulseForce_Wall));
			SerializeField(s, nameof(impulseForce_Hit));
			SerializeField(s, nameof(impulseForce_ShotBasic));
			SerializeField(s, nameof(impulseForce_ShotCrush));
			SerializeField(s, nameof(impulseForce_ShotUp));
			SerializeField(s, nameof(impulseForce_ShotCharge));
			SerializeField(s, nameof(impulseForce_EjectY));
			SerializeField(s, nameof(impulseForce_Pass));
			SerializeField(s, nameof(bounceCoefMin_x));
			SerializeField(s, nameof(bounceCoefMin_y));
			SerializeField(s, nameof(bounceCoefFactor_x));
			SerializeField(s, nameof(bounceCoefFactor_y));
			SerializeField(s, nameof(bounceDotUpLimit));
			SerializeField(s, nameof(bounceDotDownLimit));
			SerializeField(s, nameof(bounceCoefMax_x));
			SerializeField(s, nameof(bounceCoefMax_y));
			SerializeField(s, nameof(ballMode_ShotBasic));
			SerializeField(s, nameof(ballMode_ShotCrush));
			SerializeField(s, nameof(ballMode_ShotUp));
			SerializeField(s, nameof(ballMode_ShotCharge));
			SerializeField(s, nameof(ballMode_EjectY));
			SerializeField(s, nameof(ballMode_Pass));
			SerializeField(s, nameof(angleDir_ShotBasic));
			SerializeField(s, nameof(angleDir_ShotCrush));
			SerializeField(s, nameof(angleDir_ShotUp));
			SerializeField(s, nameof(angleDir_ShotCharge));
			SerializeField(s, nameof(angleDir_EjectY));
			SerializeField(s, nameof(angleDir_Pass));
			SerializeField(s, nameof(angleDirAlt_ShotBasic));
			SerializeField(s, nameof(angleDirAlt_ShotCrush));
			SerializeField(s, nameof(angleDirAlt_ShotUp));
			SerializeField(s, nameof(angleDirAlt_EjectY));
			SerializeField(s, nameof(angleDirAlt_Pass));
			SerializeField(s, nameof(bounceCoefPass_x));
			SerializeField(s, nameof(bounceCoefPass_y));
			SerializeField(s, nameof(bounceCoefRoof));
			SerializeField(s, nameof(playerCol_Enabled));
			SerializeField(s, nameof(playerCol_ShapeRadius));
			SerializeField(s, nameof(playerCol_DisabledWhileHitting));
			SerializeField(s, nameof(playerCol_AfterHitDisabledTimer));
			SerializeField(s, nameof(isLethal_ShotBasic));
			SerializeField(s, nameof(isLethal_ShotCrush));
			SerializeField(s, nameof(isLethal_ShotUp));
			SerializeField(s, nameof(isLethal_ShotCharge));
			SerializeField(s, nameof(isLethal_EjectY));
			SerializeField(s, nameof(isLethal_Pass));
			SerializeField(s, nameof(forceMin_x));
			SerializeField(s, nameof(forceMax_x));
			SerializeField(s, nameof(forceMin_y));
			SerializeField(s, nameof(forceMax_y));
			SerializeField(s, nameof(receivedHitType_ShotBasic));
			SerializeField(s, nameof(receivedHitType_ShotCrush));
			SerializeField(s, nameof(receivedHitType_ShotUp));
			SerializeField(s, nameof(receivedHitType_ShotCharge));
			SerializeField(s, nameof(receivedHitType_EjectY));
			SerializeField(s, nameof(receivedHitType_Pass));
			SerializeField(s, nameof(hitLevel_ShotBasic));
			SerializeField(s, nameof(hitLevel_ShotCrush));
			SerializeField(s, nameof(hitLevel_ShotUp));
			SerializeField(s, nameof(hitLevel_ShotCharge));
			SerializeField(s, nameof(hitLevel_EjectY));
			SerializeField(s, nameof(hitLevel_Pass));
			SerializeField(s, nameof(hitDelay));
			SerializeField(s, nameof(blockingEdgeTimer));
			SerializeField(s, nameof(minTime_Pass));
			SerializeField(s, nameof(angleAltChoice_ShotBasic));
			SerializeField(s, nameof(angleAltChoice_ShotCrush));
			SerializeField(s, nameof(angleAltChoice_ShotUp));
			SerializeField(s, nameof(angleAltChoice_ShotCharge));
			SerializeField(s, nameof(angleAltChoice_EjectY));
			SerializeField(s, nameof(angleAltChoice_Pass));
			SerializeField(s, nameof(joyTrameMax));
			SerializeField(s, nameof(impulseForceMegaHit_ShotBasic));
			SerializeField(s, nameof(impulseForceMegaHit_ShotCrush));
			SerializeField(s, nameof(impulseForceMegaHit_ShotUp));
			SerializeField(s, nameof(impulseForceMegaHit_ShotCharge));
			SerializeField(s, nameof(impulseForceMegaHit_EjectY));
			SerializeField(s, nameof(impulseForceMegaHit_Pass));
			SerializeField(s, nameof(cameraRegisterDelay));
			SerializeField(s, nameof(megaHitCounterEnabled));
			SerializeField(s, nameof(buildMegaHitEnabled_ShotBasic));
			SerializeField(s, nameof(buildMegaHitEnabled_ShotCrush));
			SerializeField(s, nameof(buildMegaHitEnabled_ShotUp));
			SerializeField(s, nameof(buildMegaHitEnabled_ShotCharge));
			SerializeField(s, nameof(buildMegaHitEnabled_EjectY));
			SerializeField(s, nameof(buildMegaHitEnabled_Pass));
			SerializeField(s, nameof(hitCountForMegaHit));
			SerializeField(s, nameof(stretchAnimSpeedMin));
			SerializeField(s, nameof(animHaloTimer));
			SerializeField(s, nameof(crushGroundImmuneDuration));
			SerializeField(s, nameof(megaHitForce));
			SerializeField(s, nameof(drcTapForce));
			SerializeField(s, nameof(faction));
		}
		public enum Enum_ballMode_ShotBasic {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_ballMode_Pass {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_receivedHitType_ShotBasic {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public override uint? ClassCRC => 0xEBD34823;
	}
}

