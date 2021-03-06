using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CreatureWH_BulbComponent_Template : RO2_AIComponent_Template {
		// v From RO2_BezierTree_Template
		[Serialize("sampleCount"      )] public uint sampleCount;
		[Serialize("widthForAABB"     )] public float widthForAABB;
		[Serialize("linkMainBranch"   )] public RO2_BezierTree_Template.LinkMode linkMainBranch;
		[Serialize("branchComponents" )] public CArray<Generic<RO2_BezierBranchComponent_Template>> branchComponents;
		[Serialize("tweenInterpreter" )] public TweenInterpreter_Template tweenInterpreter;
		[Serialize("lengthCursorInput")] public StringID lengthCursorInput;
		// ^ From RO2_BezierTree_Template
		[Serialize("attackRadius"               )] public float attackRadius;
		[Serialize("reflexAttackRadius"         )] public float reflexAttackRadius;
		[Serialize("speedAttack"                )] public float speedAttack;
		[Serialize("speedReturn"                )] public float speedReturn;
		[Serialize("chargeAnticipDist"          )] public float chargeAnticipDist;
		[Serialize("chargeDashDist"             )] public float chargeDashDist;
		[Serialize("reflexAttackSpeed"          )] public float reflexAttackSpeed;
		[Serialize("reflexAttackDuration"       )] public float reflexAttackDuration;
		[Serialize("reflexAttackInertiaDist"    )] public float reflexAttackInertiaDist;
		[Serialize("eatPos"                     )] public Vector2 eatPos;
		[Serialize("useEatAnim"                 )] public bool useEatAnim;
		[Serialize("timeAnticip"                )] public float timeAnticip;
		[Serialize("timeWaitOnPlayerEscape"     )] public float timeWaitOnPlayerEscape;
		[Serialize("timeWaitAfterCatch"         )] public float timeWaitAfterCatch;
		[Serialize("timeWaitAfterMiss"          )] public float timeWaitAfterMiss;
		[Serialize("timeWaitAfterEat"           )] public float timeWaitAfterEat;
		[Serialize("timeDeploy"                 )] public float timeDeploy;
		[Serialize("timeRetract"                )] public float timeRetract;
		[Serialize("sinXMin"                    )] public float sinXMin;
		[Serialize("sinXMax"                    )] public float sinXMax;
		[Serialize("sinYMin"                    )] public float sinYMin;
		[Serialize("sinYMax"                    )] public float sinYMax;
		[Serialize("childBone"                  )] public StringID childBone;
		[Serialize("childAttachOffset"          )] public Vector2 childAttachOffset;
		[Serialize("parentBones"                )] public CList<StringID> parentBones;
		[Serialize("handOffset"                 )] public float handOffset;
		[Serialize("collisionRadiusWhileMoving" )] public float collisionRadiusWhileMoving;
		[Serialize("collisionRadiusMin"         )] public float collisionRadiusMin;
		[Serialize("collisionRadiusMax"         )] public float collisionRadiusMax;
		[Serialize("collisionAcceleration"      )] public float collisionAcceleration;
		[Serialize("collisionRetractSpeed"      )] public float collisionRetractSpeed;
		[Serialize("collisionRetractMinDuration")] public float collisionRetractMinDuration;
		[Serialize("collisionWaitDuration"      )] public float collisionWaitDuration;
		[Serialize("collisionDeploySpeed"       )] public float collisionDeploySpeed;
		[Serialize("collisionDeployMinDuration" )] public float collisionDeployMinDuration;
		[Serialize("tapRadius"                  )] public float tapRadius;
		[Serialize("tapRetractDistance"         )] public float tapRetractDistance;
		[Serialize("tapRetractSpeedSmoothA"     )] public float tapRetractSpeedSmoothA;
		[Serialize("tapRetractSpeedSmoothB"     )] public float tapRetractSpeedSmoothB;
		[Serialize("tapCooldown"                )] public float tapCooldown;
		[Serialize("collisionShape"             )] public Generic<PhysShape> collisionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sampleCount));
			SerializeField(s, nameof(widthForAABB));
			SerializeField(s, nameof(linkMainBranch));
			SerializeField(s, nameof(branchComponents));
			SerializeField(s, nameof(tweenInterpreter));
			SerializeField(s, nameof(lengthCursorInput));
			SerializeField(s, nameof(attackRadius));
			SerializeField(s, nameof(reflexAttackRadius));
			SerializeField(s, nameof(speedAttack));
			SerializeField(s, nameof(speedReturn));
			SerializeField(s, nameof(chargeAnticipDist));
			SerializeField(s, nameof(chargeDashDist));
			SerializeField(s, nameof(reflexAttackSpeed));
			SerializeField(s, nameof(reflexAttackDuration));
			SerializeField(s, nameof(reflexAttackInertiaDist));
			SerializeField(s, nameof(eatPos));
			SerializeField(s, nameof(useEatAnim));
			SerializeField(s, nameof(timeAnticip));
			SerializeField(s, nameof(timeWaitOnPlayerEscape));
			SerializeField(s, nameof(timeWaitAfterCatch));
			SerializeField(s, nameof(timeWaitAfterMiss));
			SerializeField(s, nameof(timeWaitAfterEat));
			SerializeField(s, nameof(timeDeploy));
			SerializeField(s, nameof(timeRetract));
			SerializeField(s, nameof(sinXMin));
			SerializeField(s, nameof(sinXMax));
			SerializeField(s, nameof(sinYMin));
			SerializeField(s, nameof(sinYMax));
			SerializeField(s, nameof(childBone));
			SerializeField(s, nameof(childAttachOffset));
			SerializeField(s, nameof(parentBones));
			SerializeField(s, nameof(handOffset));
			SerializeField(s, nameof(collisionRadiusWhileMoving));
			SerializeField(s, nameof(collisionRadiusMin));
			SerializeField(s, nameof(collisionRadiusMax));
			SerializeField(s, nameof(collisionAcceleration));
			SerializeField(s, nameof(collisionRetractSpeed));
			SerializeField(s, nameof(collisionRetractMinDuration));
			SerializeField(s, nameof(collisionWaitDuration));
			SerializeField(s, nameof(collisionDeploySpeed));
			SerializeField(s, nameof(collisionDeployMinDuration));
			SerializeField(s, nameof(tapRadius));
			SerializeField(s, nameof(tapRetractDistance));
			SerializeField(s, nameof(tapRetractSpeedSmoothA));
			SerializeField(s, nameof(tapRetractSpeedSmoothB));
			SerializeField(s, nameof(tapCooldown));
			SerializeField(s, nameof(collisionShape));
		}
		public override uint? ClassCRC => 0xABE470E1;
		
	}
}

