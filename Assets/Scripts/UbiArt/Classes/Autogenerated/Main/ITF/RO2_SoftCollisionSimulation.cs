using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SoftCollisionSimulation : CSerializable {
		[Serialize("ParticlesCanHit"             )] public bool ParticlesCanHit;
		[Serialize("GridWidth"                   )] public int GridWidth;
		[Serialize("GridHeight"                  )] public int GridHeight;
		[Serialize("StaticCollision"             )] public bool StaticCollision;
		[Serialize("Density"                     )] public float Density;
		[Serialize("GroundReboudCoeff"           )] public float GroundReboudCoeff;
		[Serialize("RotationCoeff"               )] public float RotationCoeff;
		[Serialize("GroundFriction"              )] public float GroundFriction;
		[Serialize("SpeedLimit_X"                )] public float SpeedLimit_X;
		[Serialize("SpeedLimit_Y_Up"             )] public float SpeedLimit_Y_Up;
		[Serialize("SpeedLimit_Y_Down"           )] public float SpeedLimit_Y_Down;
		[Serialize("AllowWorldPerturbation"      )] public bool AllowWorldPerturbation;
		[Serialize("PerturbationPower"           )] public float PerturbationPower;
		[Serialize("VisualScaleMultiplier"       )] public float VisualScaleMultiplier;
		[Serialize("SwarmRadiusPercent"          )] public float SwarmRadiusPercent;
		[Serialize("SwarmNoisePercent"           )] public float SwarmNoisePercent;
		[Serialize("SwarmNoiseMoveCoeff"         )] public float SwarmNoiseMoveCoeff;
		[Serialize("DRC_MaxCatchNb"              )] public uint DRC_MaxCatchNb;
		[Serialize("DRC_AttractionRadius"        )] public float DRC_AttractionRadius;
		[Serialize("PHYSIC_OverlapCollisionCoeff")] public float PHYSIC_OverlapCollisionCoeff;
		[Serialize("GridWidth"                   )] public bool GridWidth;
		[Serialize("GridHeight"                  )] public bool GridHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ParticlesCanHit));
					SerializeField(s, nameof(GridWidth));
					SerializeField(s, nameof(GridHeight));
					SerializeField(s, nameof(StaticCollision));
					SerializeField(s, nameof(Density));
					SerializeField(s, nameof(GroundReboudCoeff));
					SerializeField(s, nameof(RotationCoeff));
					SerializeField(s, nameof(GroundFriction));
					SerializeField(s, nameof(SpeedLimit_X));
					SerializeField(s, nameof(SpeedLimit_Y_Up));
					SerializeField(s, nameof(SpeedLimit_Y_Down));
					SerializeField(s, nameof(AllowWorldPerturbation));
					SerializeField(s, nameof(PerturbationPower));
					SerializeField(s, nameof(VisualScaleMultiplier));
					SerializeField(s, nameof(SwarmRadiusPercent));
					SerializeField(s, nameof(SwarmNoisePercent));
					SerializeField(s, nameof(SwarmNoiseMoveCoeff));
					SerializeField(s, nameof(DRC_MaxCatchNb));
					SerializeField(s, nameof(DRC_AttractionRadius));
					SerializeField(s, nameof(PHYSIC_OverlapCollisionCoeff));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(ParticlesCanHit));
					SerializeField(s, nameof(GridWidth));
					SerializeField(s, nameof(GridHeight));
					SerializeField(s, nameof(StaticCollision));
					SerializeField(s, nameof(Density));
					SerializeField(s, nameof(GroundReboudCoeff));
					SerializeField(s, nameof(RotationCoeff));
					SerializeField(s, nameof(GroundFriction));
					SerializeField(s, nameof(SpeedLimit_X));
					SerializeField(s, nameof(SpeedLimit_Y_Up));
					SerializeField(s, nameof(SpeedLimit_Y_Down));
					SerializeField(s, nameof(AllowWorldPerturbation));
					SerializeField(s, nameof(PerturbationPower));
					SerializeField(s, nameof(VisualScaleMultiplier));
					SerializeField(s, nameof(SwarmRadiusPercent));
					SerializeField(s, nameof(SwarmNoisePercent));
					SerializeField(s, nameof(SwarmNoiseMoveCoeff));
					SerializeField(s, nameof(DRC_MaxCatchNb));
					SerializeField(s, nameof(DRC_AttractionRadius));
					SerializeField(s, nameof(PHYSIC_OverlapCollisionCoeff));
				}
			}
		}
		public override uint? ClassCRC => 0x801D0639;
	}
}

