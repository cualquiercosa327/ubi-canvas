using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_376_sub_AE4070 : CSerializable {
		[Serialize("handForwardSpeed"       )] public float handForwardSpeed;
		[Serialize("handBackwardSpeed"      )] public float handBackwardSpeed;
		[Serialize("handEscapeSpeed"        )] public float handEscapeSpeed;
		[Serialize("handAcceleration"       )] public float handAcceleration;
		[Serialize("bezierRenderer"         )] public Placeholder bezierRenderer;
		[Serialize("zOffset"                )] public float zOffset;
		[Serialize("detectionShape"         )] public Placeholder detectionShape;
		[Serialize("handLightDistance"      )] public float handLightDistance;
		[Serialize("handRotationSpeed"      )] public Angle handRotationSpeed;
		[Serialize("endCurveBoneName"       )] public StringID endCurveBoneName;
		[Serialize("stimDelay"              )] public float stimDelay;
		[Serialize("stimDistance"           )] public float stimDistance;
		[Serialize("idleMinTime"            )] public float idleMinTime;
		[Serialize("rootTangentFactor"      )] public float rootTangentFactor;
		[Serialize("handTangentFactor"      )] public float handTangentFactor;
		[Serialize("tangentMaxFactorLength" )] public float tangentMaxFactorLength;
		[Serialize("tangentNullFactorLength")] public float tangentNullFactorLength;
		[Serialize("drc_retractLengthRatio" )] public float drc_retractLengthRatio;
		[Serialize("drc_retractSpeedSmooth" )] public float drc_retractSpeedSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(handForwardSpeed));
			SerializeField(s, nameof(handBackwardSpeed));
			SerializeField(s, nameof(handEscapeSpeed));
			SerializeField(s, nameof(handAcceleration));
			SerializeField(s, nameof(bezierRenderer));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(detectionShape));
			SerializeField(s, nameof(handLightDistance));
			SerializeField(s, nameof(handRotationSpeed));
			SerializeField(s, nameof(endCurveBoneName));
			SerializeField(s, nameof(stimDelay));
			SerializeField(s, nameof(stimDistance));
			SerializeField(s, nameof(idleMinTime));
			SerializeField(s, nameof(rootTangentFactor));
			SerializeField(s, nameof(handTangentFactor));
			SerializeField(s, nameof(tangentMaxFactorLength));
			SerializeField(s, nameof(tangentNullFactorLength));
			SerializeField(s, nameof(drc_retractLengthRatio));
			SerializeField(s, nameof(drc_retractSpeedSmooth));
		}
		public override uint? ClassCRC => 0xB709B48A;
	}
}

