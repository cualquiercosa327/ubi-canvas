using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class GroundAIControllerComponent_Template : BaseAIControllerComponent_Template {
		[Serialize("walkForce"                         )] public float walkForce;
		[Serialize("walkEfficiencyMaxSpeed"            )] public float walkEfficiencyMaxSpeed;
		[Serialize("walkEfficiencyMinGroundAngle"      )] public Angle walkEfficiencyMinGroundAngle;
		[Serialize("walkEfficiencyMaxGroundAngle"      )] public Angle walkEfficiencyMaxGroundAngle;
		[Serialize("walkEfficiencyMinAngleMultiplier"  )] public float walkEfficiencyMinAngleMultiplier;
		[Serialize("walkEfficiencyMaxAngleMultiplier"  )] public float walkEfficiencyMaxAngleMultiplier;
		[Serialize("walkMoveTargetMultiplierMin"       )] public float walkMoveTargetMultiplierMin;
		[Serialize("walkMoveTargetMultiplierMax"       )] public float walkMoveTargetMultiplierMax;
		[Serialize("walkMoveTargetBlendTime"           )] public float walkMoveTargetBlendTime;
		[Serialize("airForce"                          )] public float airForce;
		[Serialize("airTopSpeed"                       )] public float airTopSpeed;
		[Serialize("airFriction"                       )] public float airFriction;
		[Serialize("airSuspensionMinYSpeed"            )] public float airSuspensionMinYSpeed;
		[Serialize("airSuspensionMaxYSpeed"            )] public float airSuspensionMaxYSpeed;
		[Serialize("airSuspensionMinMultiplier"        )] public float airSuspensionMinMultiplier;
		[Serialize("airSuspensionMaxMultiplier"        )] public float airSuspensionMaxMultiplier;
		[Serialize("swimWaterResistMinSpeed"           )] public float swimWaterResistMinSpeed;
		[Serialize("swimWaterResistMaxSpeed"           )] public float swimWaterResistMaxSpeed;
		[Serialize("swimWaterResistMaxMultiplier"      )] public float swimWaterResistMaxMultiplier;
		[Serialize("swimJumpRange"                     )] public float swimJumpRange;
		[Serialize("swimInertiaSpeed"                  )] public float swimInertiaSpeed;
		[Serialize("swimTopSpeed"                      )] public float swimTopSpeed;
		[Serialize("swimTurnDistanceMultiplier"        )] public float swimTurnDistanceMultiplier;
		[Serialize("swimTurnSpeedMultiplier"           )] public float swimTurnSpeedMultiplier;
		[Serialize("swimDisableRotation"               )] public bool swimDisableRotation;
		[Serialize("flyInertiaSpeed"                   )] public float flyInertiaSpeed;
		[Serialize("flyTopSpeed"                       )] public float flyTopSpeed;
		[Serialize("jumpForce"                         )] public float jumpForce;
		[Serialize("jumpToActorYFuncPoint0Dist"        )] public float jumpToActorYFuncPoint0Dist;
		[Serialize("jumpToActorYFuncPoint1Dist"        )] public float jumpToActorYFuncPoint1Dist;
		[Serialize("jumpToActorXZFuncPoint0T"          )] public float jumpToActorXZFuncPoint0T;
		[Serialize("jumpToActorXZFuncPoint1T"          )] public float jumpToActorXZFuncPoint1T;
		[Serialize("jumpToActorSpeed"                  )] public float jumpToActorSpeed;
		[Serialize("jumpToActorMinTime"                )] public float jumpToActorMinTime;
		[Serialize("avoidanceRadius"                   )] public float avoidanceRadius;
		[Serialize("minVariation"                      )] public float minVariation;
		[Serialize("maxVariation"                      )] public float maxVariation;
		[Serialize("sprintWalkForceMultiplier"         )] public float sprintWalkForceMultiplier;
		[Serialize("sprintEfficiencyMaxSpeedMultiplier")] public float sprintEfficiencyMaxSpeedMultiplier;
		[Serialize("sprintAccelerationDuration"        )] public float sprintAccelerationDuration;
		[Serialize("dashSpeed"                         )] public float dashSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(walkForce));
				SerializeField(s, nameof(walkEfficiencyMaxSpeed));
				SerializeField(s, nameof(walkEfficiencyMinGroundAngle));
				SerializeField(s, nameof(walkEfficiencyMaxGroundAngle));
				SerializeField(s, nameof(walkEfficiencyMinAngleMultiplier));
				SerializeField(s, nameof(walkEfficiencyMaxAngleMultiplier));
				SerializeField(s, nameof(walkMoveTargetMultiplierMin));
				SerializeField(s, nameof(walkMoveTargetMultiplierMax));
				SerializeField(s, nameof(walkMoveTargetBlendTime));
				SerializeField(s, nameof(airForce));
				SerializeField(s, nameof(airTopSpeed));
				SerializeField(s, nameof(airFriction));
				SerializeField(s, nameof(airSuspensionMinYSpeed));
				SerializeField(s, nameof(airSuspensionMaxYSpeed));
				SerializeField(s, nameof(airSuspensionMinMultiplier));
				SerializeField(s, nameof(airSuspensionMaxMultiplier));
				SerializeField(s, nameof(swimWaterResistMinSpeed));
				SerializeField(s, nameof(swimWaterResistMaxSpeed));
				SerializeField(s, nameof(swimWaterResistMaxMultiplier));
				SerializeField(s, nameof(swimJumpRange));
				SerializeField(s, nameof(swimInertiaSpeed));
				SerializeField(s, nameof(swimTopSpeed));
				SerializeField(s, nameof(swimTurnDistanceMultiplier));
				SerializeField(s, nameof(swimTurnSpeedMultiplier));
				SerializeField(s, nameof(jumpForce));
				SerializeField(s, nameof(jumpToActorYFuncPoint0Dist));
				SerializeField(s, nameof(jumpToActorYFuncPoint1Dist));
				SerializeField(s, nameof(jumpToActorXZFuncPoint0T));
				SerializeField(s, nameof(jumpToActorXZFuncPoint1T));
				SerializeField(s, nameof(jumpToActorSpeed));
				SerializeField(s, nameof(jumpToActorMinTime));
				SerializeField(s, nameof(avoidanceRadius));
				SerializeField(s, nameof(minVariation));
				SerializeField(s, nameof(maxVariation));
				SerializeField(s, nameof(sprintWalkForceMultiplier));
				SerializeField(s, nameof(sprintEfficiencyMaxSpeedMultiplier));
				SerializeField(s, nameof(sprintAccelerationDuration));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(walkForce));
				SerializeField(s, nameof(walkEfficiencyMaxSpeed));
				SerializeField(s, nameof(walkEfficiencyMinGroundAngle));
				SerializeField(s, nameof(walkEfficiencyMaxGroundAngle));
				SerializeField(s, nameof(walkEfficiencyMinAngleMultiplier));
				SerializeField(s, nameof(walkEfficiencyMaxAngleMultiplier));
				SerializeField(s, nameof(walkMoveTargetMultiplierMin));
				SerializeField(s, nameof(walkMoveTargetMultiplierMax));
				SerializeField(s, nameof(walkMoveTargetBlendTime));
				SerializeField(s, nameof(airForce));
				SerializeField(s, nameof(airTopSpeed));
				SerializeField(s, nameof(airFriction));
				SerializeField(s, nameof(airSuspensionMinYSpeed));
				SerializeField(s, nameof(airSuspensionMaxYSpeed));
				SerializeField(s, nameof(airSuspensionMinMultiplier));
				SerializeField(s, nameof(airSuspensionMaxMultiplier));
				SerializeField(s, nameof(swimWaterResistMinSpeed));
				SerializeField(s, nameof(swimWaterResistMaxSpeed));
				SerializeField(s, nameof(swimWaterResistMaxMultiplier));
				SerializeField(s, nameof(swimJumpRange));
				SerializeField(s, nameof(swimInertiaSpeed));
				SerializeField(s, nameof(swimTopSpeed));
				SerializeField(s, nameof(swimTurnDistanceMultiplier));
				SerializeField(s, nameof(swimTurnSpeedMultiplier));
				SerializeField(s, nameof(swimDisableRotation));
				SerializeField(s, nameof(flyInertiaSpeed));
				SerializeField(s, nameof(flyTopSpeed));
				SerializeField(s, nameof(jumpForce));
				SerializeField(s, nameof(jumpToActorYFuncPoint0Dist));
				SerializeField(s, nameof(jumpToActorYFuncPoint1Dist));
				SerializeField(s, nameof(jumpToActorXZFuncPoint0T));
				SerializeField(s, nameof(jumpToActorXZFuncPoint1T));
				SerializeField(s, nameof(jumpToActorSpeed));
				SerializeField(s, nameof(jumpToActorMinTime));
				SerializeField(s, nameof(avoidanceRadius));
				SerializeField(s, nameof(minVariation));
				SerializeField(s, nameof(maxVariation));
				SerializeField(s, nameof(sprintWalkForceMultiplier));
				SerializeField(s, nameof(sprintEfficiencyMaxSpeedMultiplier));
				SerializeField(s, nameof(sprintAccelerationDuration));
			} else {
				SerializeField(s, nameof(walkForce));
				SerializeField(s, nameof(walkEfficiencyMaxSpeed));
				SerializeField(s, nameof(walkEfficiencyMinGroundAngle));
				SerializeField(s, nameof(walkEfficiencyMaxGroundAngle));
				SerializeField(s, nameof(walkEfficiencyMinAngleMultiplier));
				SerializeField(s, nameof(walkEfficiencyMaxAngleMultiplier));
				SerializeField(s, nameof(walkMoveTargetMultiplierMin));
				SerializeField(s, nameof(walkMoveTargetMultiplierMax));
				SerializeField(s, nameof(walkMoveTargetBlendTime));
				SerializeField(s, nameof(airForce));
				SerializeField(s, nameof(airTopSpeed));
				SerializeField(s, nameof(airFriction));
				SerializeField(s, nameof(airSuspensionMinYSpeed));
				SerializeField(s, nameof(airSuspensionMaxYSpeed));
				SerializeField(s, nameof(airSuspensionMinMultiplier));
				SerializeField(s, nameof(airSuspensionMaxMultiplier));
				SerializeField(s, nameof(swimWaterResistMinSpeed));
				SerializeField(s, nameof(swimWaterResistMaxSpeed));
				SerializeField(s, nameof(swimWaterResistMaxMultiplier));
				SerializeField(s, nameof(swimJumpRange));
				SerializeField(s, nameof(swimInertiaSpeed));
				SerializeField(s, nameof(swimTopSpeed));
				SerializeField(s, nameof(swimTurnDistanceMultiplier));
				SerializeField(s, nameof(swimTurnSpeedMultiplier));
				SerializeField(s, nameof(swimDisableRotation));
				SerializeField(s, nameof(flyInertiaSpeed));
				SerializeField(s, nameof(flyTopSpeed));
				SerializeField(s, nameof(jumpForce));
				SerializeField(s, nameof(jumpToActorYFuncPoint0Dist));
				SerializeField(s, nameof(jumpToActorYFuncPoint1Dist));
				SerializeField(s, nameof(jumpToActorXZFuncPoint0T));
				SerializeField(s, nameof(jumpToActorXZFuncPoint1T));
				SerializeField(s, nameof(jumpToActorSpeed));
				SerializeField(s, nameof(jumpToActorMinTime));
				SerializeField(s, nameof(avoidanceRadius));
				SerializeField(s, nameof(minVariation));
				SerializeField(s, nameof(maxVariation));
				SerializeField(s, nameof(sprintWalkForceMultiplier));
				SerializeField(s, nameof(sprintEfficiencyMaxSpeedMultiplier));
				SerializeField(s, nameof(sprintAccelerationDuration));
				SerializeField(s, nameof(dashSpeed));
			}
		}
		public override uint? ClassCRC => 0x4530E988;
	}
}

