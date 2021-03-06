using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_124_sub_6F5A50 : ActorComponent_Template {
		[Serialize("DrawParticleNb"              )] public int DrawParticleNb;
		[Serialize("DrawBezier"                  )] public int DrawBezier;
		[Serialize("DrawAppear"                  )] public int DrawAppear;
		[Serialize("DrawTransition"              )] public int DrawTransition;
		[Serialize("DrawSpeed"                   )] public int DrawSpeed;
		[Serialize("DrawHit"                     )] public int DrawHit;
		[Serialize("DrawAttack"                  )] public int DrawAttack;
		[Serialize("TimeBeforeTransition"        )] public float TimeBeforeTransition;
		[Serialize("DestructionAccelerationCoeff")] public float DestructionAccelerationCoeff;
		[Serialize("CreatureBaseRadius"          )] public float CreatureBaseRadius;
		[Serialize("CreatureRadiusSeeder"        )] public float CreatureRadiusSeeder;
		[Serialize("CreatureNbCoeff"             )] public float CreatureNbCoeff;
		[Serialize("OnBoneData"                  )] public CList<Unknown_RL_20717_sub_6E6EE0> OnBoneData;
		[Serialize("EyeBoneList"                 )] public CList<StringID> EyeBoneList;
		[Serialize("ApplyAnimMod"                )] public int ApplyAnimMod;
		[Serialize("TailBone"                    )] public StringID TailBone;
		[Serialize("HeadBone"                    )] public StringID HeadBone;
		[Serialize("lightResolver"               )] public Path lightResolver;
		[Serialize("AnimStand"                   )] public StringID AnimStand;
		[Serialize("AnimHit"                     )] public StringID AnimHit;
		[Serialize("AnimRegroup"                 )] public StringID AnimRegroup;
		[Serialize("AnimScared"                  )] public StringID AnimScared;
		[Serialize("AnimBlood"                   )] public StringID AnimBlood;
		[Serialize("AnimEye"                     )] public StringID AnimEye;
		[Serialize("AnimDie"                     )] public StringID AnimDie;
		[Serialize("MinBurningTime"              )] public float MinBurningTime;
		[Serialize("MaxBurningTime"              )] public float MaxBurningTime;
		[Serialize("MinTimeToDie"                )] public float MinTimeToDie;
		[Serialize("MaxTimeToDie"                )] public float MaxTimeToDie;
		[Serialize("MinRegenTime"                )] public float MinRegenTime;
		[Serialize("MaxRegenTime"                )] public float MaxRegenTime;
		[Serialize("AirFriction"                 )] public float AirFriction;
		[Serialize("Gravity"                     )] public float Gravity;
		[Serialize("ExplosionForceMultiplier"    )] public float ExplosionForceMultiplier;
		[Serialize("ExplosionInitialSpeed"       )] public float ExplosionInitialSpeed;
		[Serialize("PunchExplosionRadius"        )] public CList<float> PunchExplosionRadius;
		[Serialize("PunchPercentageValidation"   )] public float PunchPercentageValidation;
		[Serialize("TimeToVanish"                )] public float TimeToVanish;
		[Serialize("RotationCoeff"               )] public float RotationCoeff;
		[Serialize("RegroupSpeed"                )] public float RegroupSpeed;
		[Serialize("RegroupAirFriction"          )] public float RegroupAirFriction;
		[Serialize("RegroupForce"                )] public float RegroupForce;
		[Serialize("RegroupMinTime"              )] public float RegroupMinTime;
		[Serialize("RegroupMaxTime"              )] public float RegroupMaxTime;
		[Serialize("SoundFX_Idle"                )] public StringID SoundFX_Idle;
		[Serialize("SoundFX_Hit"                 )] public StringID SoundFX_Hit;
		[Serialize("SounfFX_Respawn"             )] public StringID SounfFX_Respawn;
		[Serialize("SoundFX_Destroy"             )] public StringID SoundFX_Destroy;
		[Serialize("SoundFX_Appear"              )] public StringID SoundFX_Appear;
		[Serialize("AttackAnimAllowed"           )] public int AttackAnimAllowed;
		[Serialize("AttackAnimDistance"          )] public float AttackAnimDistance;
		[Serialize("RandomLaughAllowed"          )] public int RandomLaughAllowed;
		[Serialize("RandomLaughMinTime"          )] public float RandomLaughMinTime;
		[Serialize("RandomLaughMaxTime"          )] public float RandomLaughMaxTime;
		[Serialize("UseFinalExplosion"           )] public int UseFinalExplosion;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DrawParticleNb));
			SerializeField(s, nameof(DrawBezier));
			SerializeField(s, nameof(DrawAppear));
			SerializeField(s, nameof(DrawTransition));
			SerializeField(s, nameof(DrawSpeed));
			SerializeField(s, nameof(DrawHit));
			SerializeField(s, nameof(DrawAttack));
			SerializeField(s, nameof(TimeBeforeTransition));
			SerializeField(s, nameof(DestructionAccelerationCoeff));
			SerializeField(s, nameof(CreatureBaseRadius));
			SerializeField(s, nameof(CreatureRadiusSeeder));
			SerializeField(s, nameof(CreatureNbCoeff));
			SerializeField(s, nameof(OnBoneData));
			SerializeField(s, nameof(EyeBoneList));
			SerializeField(s, nameof(ApplyAnimMod));
			SerializeField(s, nameof(TailBone));
			SerializeField(s, nameof(HeadBone));
			SerializeField(s, nameof(lightResolver));
			SerializeField(s, nameof(AnimStand));
			SerializeField(s, nameof(AnimHit));
			SerializeField(s, nameof(AnimRegroup));
			SerializeField(s, nameof(AnimScared));
			SerializeField(s, nameof(AnimBlood));
			SerializeField(s, nameof(AnimEye));
			SerializeField(s, nameof(AnimDie));
			SerializeField(s, nameof(MinBurningTime));
			SerializeField(s, nameof(MaxBurningTime));
			SerializeField(s, nameof(MinTimeToDie));
			SerializeField(s, nameof(MaxTimeToDie));
			SerializeField(s, nameof(MinRegenTime));
			SerializeField(s, nameof(MaxRegenTime));
			SerializeField(s, nameof(AirFriction));
			SerializeField(s, nameof(Gravity));
			SerializeField(s, nameof(ExplosionForceMultiplier));
			SerializeField(s, nameof(ExplosionInitialSpeed));
			SerializeField(s, nameof(PunchExplosionRadius));
			SerializeField(s, nameof(PunchPercentageValidation));
			SerializeField(s, nameof(TimeToVanish));
			SerializeField(s, nameof(RotationCoeff));
			SerializeField(s, nameof(RegroupSpeed));
			SerializeField(s, nameof(RegroupAirFriction));
			SerializeField(s, nameof(RegroupForce));
			SerializeField(s, nameof(RegroupMinTime));
			SerializeField(s, nameof(RegroupMaxTime));
			SerializeField(s, nameof(SoundFX_Idle));
			SerializeField(s, nameof(SoundFX_Hit));
			SerializeField(s, nameof(SounfFX_Respawn));
			SerializeField(s, nameof(SoundFX_Destroy));
			SerializeField(s, nameof(SoundFX_Appear));
			SerializeField(s, nameof(AttackAnimAllowed));
			SerializeField(s, nameof(AttackAnimDistance));
			SerializeField(s, nameof(RandomLaughAllowed));
			SerializeField(s, nameof(RandomLaughMinTime));
			SerializeField(s, nameof(RandomLaughMaxTime));
			SerializeField(s, nameof(UseFinalExplosion));
		}
		public override uint? ClassCRC => 0x6AAD0104;

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_20717_sub_6E6EE0 : CSerializable {
			[Serialize("BoneName"   )] public StringID BoneName;
			[Serialize("CreatureNb" )] public uint CreatureNb;
			[Serialize("Scale"      )] public float Scale;
			[Serialize("Radius"     )] public float Radius;
			[Serialize("IsFlat"     )] public int IsFlat;
			[Serialize("FlatBoneOne")] public StringID FlatBoneOne;
			[Serialize("FlatBoneTwo")] public StringID FlatBoneTwo;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(BoneName));
				SerializeField(s, nameof(CreatureNb));
				SerializeField(s, nameof(Scale));
				SerializeField(s, nameof(Radius));
				SerializeField(s, nameof(IsFlat));
				SerializeField(s, nameof(FlatBoneOne));
				SerializeField(s, nameof(FlatBoneTwo));
			}
		}
	}
}

