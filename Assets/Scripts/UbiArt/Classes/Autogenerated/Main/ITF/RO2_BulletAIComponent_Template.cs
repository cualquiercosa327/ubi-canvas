using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BulletAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("launchBehavior"                          )] public Generic<TemplateAIBehavior> launchBehavior;
		[Serialize("genericBehavior"                         )] public Generic<TemplateAIBehavior> genericBehavior;
		[Serialize("deathBehavior"                           )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("deathNoStimBehavior"                     )] public Generic<TemplateAIBehavior> deathNoStimBehavior;
		[Serialize("sleepingBehavior"                        )] public Generic<TemplateAIBehavior> sleepingBehavior;
		[Serialize("appearBehavior"                          )] public Generic<TemplateAIBehavior> appearBehavior;
		[Serialize("delayKillBehavior"                       )] public Generic<TemplateAIBehavior> delayKillBehavior;
		[Serialize("speed"                                   )] public float speed;
		[Serialize("lifeTime"                                )] public float lifeTime;
		[Serialize("collideWithEnvironment"                  )] public bool collideWithEnvironment;
		[Serialize("collideWithPhantoms"                     )] public bool collideWithPhantoms;
		[Serialize("filterEnvironmentCollisionWithSpeed"     )] public bool filterEnvironmentCollisionWithSpeed;
		[Serialize("filterEnvironmentCollisionWithDirection" )] public bool filterEnvironmentCollisionWithDirection;
		[Serialize("activateNoCollDuration"                  )] public float activateNoCollDuration;
		[Serialize("collisionOffset"                         )] public float collisionOffset;
		[Serialize("collisionRadius"                         )] public float collisionRadius;
		[Serialize("sendDeathStim"                           )] public bool sendDeathStim;
		[Serialize("explodeOnDeathStim"                      )] public bool explodeOnDeathStim;
		[Serialize("isCameraRelative"                        )] public bool isCameraRelative;
		[Serialize("collideWithSolidEdges"                   )] public bool collideWithSolidEdges;
		[Serialize("disablePolylineOnDeath"                  )] public bool disablePolylineOnDeath;
		[Serialize("destroyOnExitScreen"                     )] public bool destroyOnExitScreen;
		[Serialize("destroyOnBecomeInactive"                 )] public bool destroyOnBecomeInactive;
		[Serialize("dragForceWeight_Left"                    )] public float dragForceWeight_Left;
		[Serialize("dragForceWeight_Right"                   )] public float dragForceWeight_Right;
		[Serialize("dragForceWeight_Up"                      )] public float dragForceWeight_Up;
		[Serialize("dragForceWeight_Down"                    )] public float dragForceWeight_Down;
		[Serialize("dragForceDistance"                       )] public float dragForceDistance;
		[Serialize("dragForceFadeWeight"                     )] public float dragForceFadeWeight;
		[Serialize("dragForceMaxAngle"                       )] public Angle dragForceMaxAngle;
		[Serialize("dragKeepDirection"                       )] public bool dragKeepDirection;
		[Serialize("dragForceSpeedRelated"                   )] public bool dragForceSpeedRelated;
		[Serialize("hitReceivedFriendlyFire"                 )] public bool hitReceivedFriendlyFire;
		[Serialize("checkNoseFriendlyFire"                   )] public bool checkNoseFriendlyFire;
		[Serialize("checkPhantomAllowed"                     )] public bool checkPhantomAllowed;
		[Serialize("explodeOnContact"                        )] public bool explodeOnContact;
		[Serialize("useSleepingBehavior"                     )] public bool useSleepingBehavior;
		[Serialize("useLifeTime"                             )] public bool useLifeTime;
		[Serialize("dragOffsetLeft"                          )] public Vector2 dragOffsetLeft;
		[Serialize("dragOffsetRight"                         )] public Vector2 dragOffsetRight;
		[Serialize("dragOffsetUp"                            )] public float dragOffsetUp;
		[Serialize("registerToCamera"                        )] public bool registerToCamera;
		[Serialize("immuneToHit"                             )] public bool immuneToHit;
		[Serialize("appearAfterCameraOut"                    )] public bool appearAfterCameraOut;
		[Serialize("dieOnTrigger"                            )] public bool dieOnTrigger;
		[Serialize("outCameraMaxTime"                        )] public float outCameraMaxTime;
		[Serialize("driveCameraAlways"                       )] public bool driveCameraAlways;
		[Serialize("dieOnWaterContact"                       )] public bool dieOnWaterContact;
		[Serialize("resetToInitPos"                          )] public bool resetToInitPos;
		[Serialize("basicDelayKillDuration"                  )] public float basicDelayKillDuration;
		[Serialize("delayKillGravityFactor"                  )] public float delayKillGravityFactor;
		[Serialize("cameraRegisterDelay"                     )] public float cameraRegisterDelay;
		[Serialize("spawnSmokeOnDelayKill"                   )] public bool spawnSmokeOnDelayKill;
		[Serialize("prisonerAttachBone"                      )] public StringID prisonerAttachBone;
		[Serialize("avoidRoofColl"                           )] public bool avoidRoofColl;
		[Serialize("blockOnNPC"                              )] public bool blockOnNPC;
		[Serialize("roofShape"                               )] public Generic<PhysShape> roofShape;
		[Serialize("blockOnNPCShape"                         )] public Generic<PhysShape> blockOnNPCShape;
		[Serialize("blockOnNPCCoefToMinRadius"               )] public float blockOnNPCCoefToMinRadius;
		[Serialize("roofCoefToMinRadius"                     )] public float roofCoefToMinRadius;
		[Serialize("deathOnRelease"                          )] public bool deathOnRelease;
		[Serialize("deathTimer"                              )] public float deathTimer;
		[Serialize("snapPlayer"                              )] public bool snapPlayer;
		[Serialize("snapPlayerOffset"                        )] public float snapPlayerOffset;
		[Serialize("snapBone"                                )] public StringID snapBone;
		[Serialize("explodeOnEnemy"                          )] public bool explodeOnEnemy;
		[Serialize("KillEnemy"                               )] public bool KillEnemy;
		[Serialize("offScreenOffset"                         )] public float offScreenOffset;
		[Serialize("useShieldGlobalSystem"                   )] public bool useShieldGlobalSystem;
		[Serialize("useHitReaction"                          )] public bool useHitReaction;
		[Serialize("usePlayerInShape"                        )] public bool usePlayerInShape;
		[Serialize("playerInShape"                           )] public Generic<PhysShape> playerInShape;
		[Serialize("useFadeWhenDie"                          )] public bool useFadeWhenDie;
		[Serialize("fadeDuration"                            )] public float fadeDuration;
		[Serialize("useSpecificNoseShape"                    )] public bool useSpecificNoseShape;
		[Serialize("specificNoseShape"                       )] public Generic<PhysShape> specificNoseShape;
		[Serialize("acceptEventUpdateRegisteredSubjectStatus")] public bool acceptEventUpdateRegisteredSubjectStatus;
		[Serialize("allowTouchScreenInputDisabled"           )] public bool allowTouchScreenInputDisabled;
		[Serialize("dragEnabled"                             )] public bool dragEnabled;
		[Serialize("sendTriggerOnDrcEventEnabled"            )] public bool sendTriggerOnDrcEventEnabled;
		[Serialize("autoStart"                               )] public bool autoStart;
		[Serialize("drcEventEnabled"                         )] public bool drcEventEnabled;
		[Serialize("reactToFlyingPlatform"                   )] public bool reactToFlyingPlatform;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(launchBehavior));
			SerializeField(s, nameof(genericBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(deathNoStimBehavior));
			SerializeField(s, nameof(sleepingBehavior));
			SerializeField(s, nameof(appearBehavior));
			SerializeField(s, nameof(delayKillBehavior));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(lifeTime));
			SerializeField(s, nameof(collideWithEnvironment));
			SerializeField(s, nameof(collideWithPhantoms));
			SerializeField(s, nameof(filterEnvironmentCollisionWithSpeed));
			SerializeField(s, nameof(filterEnvironmentCollisionWithDirection));
			SerializeField(s, nameof(activateNoCollDuration));
			SerializeField(s, nameof(collisionOffset));
			SerializeField(s, nameof(collisionRadius));
			SerializeField(s, nameof(sendDeathStim));
			SerializeField(s, nameof(explodeOnDeathStim));
			SerializeField(s, nameof(isCameraRelative));
			SerializeField(s, nameof(collideWithSolidEdges));
			SerializeField(s, nameof(disablePolylineOnDeath));
			SerializeField(s, nameof(destroyOnExitScreen));
			SerializeField(s, nameof(destroyOnBecomeInactive));
			SerializeField(s, nameof(dragForceWeight_Left));
			SerializeField(s, nameof(dragForceWeight_Right));
			SerializeField(s, nameof(dragForceWeight_Up));
			SerializeField(s, nameof(dragForceWeight_Down));
			SerializeField(s, nameof(dragForceDistance));
			SerializeField(s, nameof(dragForceFadeWeight));
			SerializeField(s, nameof(dragForceMaxAngle));
			SerializeField(s, nameof(dragKeepDirection));
			SerializeField(s, nameof(dragForceSpeedRelated));
			SerializeField(s, nameof(hitReceivedFriendlyFire));
			SerializeField(s, nameof(checkNoseFriendlyFire));
			SerializeField(s, nameof(checkPhantomAllowed));
			SerializeField(s, nameof(explodeOnContact));
			SerializeField(s, nameof(useSleepingBehavior));
			SerializeField(s, nameof(useLifeTime));
			SerializeField(s, nameof(dragOffsetLeft));
			SerializeField(s, nameof(dragOffsetRight));
			SerializeField(s, nameof(dragOffsetUp));
			SerializeField(s, nameof(registerToCamera));
			SerializeField(s, nameof(immuneToHit));
			SerializeField(s, nameof(appearAfterCameraOut));
			SerializeField(s, nameof(dieOnTrigger));
			SerializeField(s, nameof(outCameraMaxTime));
			SerializeField(s, nameof(driveCameraAlways));
			SerializeField(s, nameof(dieOnWaterContact));
			SerializeField(s, nameof(resetToInitPos));
			SerializeField(s, nameof(basicDelayKillDuration));
			SerializeField(s, nameof(delayKillGravityFactor));
			SerializeField(s, nameof(cameraRegisterDelay));
			SerializeField(s, nameof(spawnSmokeOnDelayKill));
			SerializeField(s, nameof(prisonerAttachBone));
			SerializeField(s, nameof(avoidRoofColl));
			SerializeField(s, nameof(blockOnNPC));
			SerializeField(s, nameof(roofShape));
			SerializeField(s, nameof(blockOnNPCShape));
			SerializeField(s, nameof(blockOnNPCCoefToMinRadius));
			SerializeField(s, nameof(roofCoefToMinRadius));
			SerializeField(s, nameof(deathOnRelease));
			SerializeField(s, nameof(deathTimer));
			SerializeField(s, nameof(snapPlayer));
			SerializeField(s, nameof(snapPlayerOffset));
			SerializeField(s, nameof(snapBone));
			SerializeField(s, nameof(explodeOnEnemy));
			SerializeField(s, nameof(KillEnemy));
			SerializeField(s, nameof(offScreenOffset));
			SerializeField(s, nameof(useShieldGlobalSystem));
			SerializeField(s, nameof(useHitReaction));
			SerializeField(s, nameof(usePlayerInShape));
			SerializeField(s, nameof(playerInShape));
			SerializeField(s, nameof(useFadeWhenDie));
			SerializeField(s, nameof(fadeDuration));
			SerializeField(s, nameof(useSpecificNoseShape));
			SerializeField(s, nameof(specificNoseShape));
			SerializeField(s, nameof(acceptEventUpdateRegisteredSubjectStatus));
			SerializeField(s, nameof(allowTouchScreenInputDisabled));
			SerializeField(s, nameof(dragEnabled));
			SerializeField(s, nameof(sendTriggerOnDrcEventEnabled));
			SerializeField(s, nameof(autoStart));
			SerializeField(s, nameof(drcEventEnabled));
			SerializeField(s, nameof(reactToFlyingPlatform));
		}
		public override uint? ClassCRC => 0xBAA3F606;
	}
}

