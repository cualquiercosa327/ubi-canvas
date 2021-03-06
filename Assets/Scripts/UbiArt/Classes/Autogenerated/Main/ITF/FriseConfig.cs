using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class FriseConfig : Actor_Template {
		[Serialize("gameMaterial"                  )] public Path gameMaterial;
		[Serialize("gameMaterialExtremityStart"    )] public Path gameMaterialExtremityStart;
		[Serialize("gameMaterialExtremityStop"     )] public Path gameMaterialExtremityStop;
		[Serialize("visualOffset"                  )] public float visualOffset;
		[Serialize("regionId"                      )] public StringID regionId;
		[Serialize("useFriezeFlipToFlipUV"         )] public bool useFriezeFlipToFlipUV;
		[Serialize("cornerFactor"                  )] public float cornerFactor;
		[Serialize("height"                        )] public float height;
		[Serialize("width"                         )] public float width;
		[Serialize("methode"                       )] public uint methode;
		[Serialize("snapCoeff"                     )] public float snapCoeff;
		[Serialize("snapCoeffUv"                   )] public float snapCoeffUv;
		[Serialize("flexibility"                   )] public float flexibility;
		[Serialize("wallAngle"                     )] public Angle wallAngle;
		[Serialize("isUvFlipX"                     )] public bool isUvFlipX;
		[Serialize("isUvFlipY"                     )] public bool isUvFlipY;
		[Serialize("isRatioFixed"                  )] public bool isRatioFixed;
		[Serialize("smoothFactorVisual"            )] public float smoothFactorVisual;
		[Serialize("scale"                         )] public float scale;
		[Serialize("density"                       )] public float density;
		[Serialize("collision"                     )] public CollisionFrieze collision;
		[Serialize("fill"                          )] public FillConfig fill;
		[Serialize("zExtrudeUp"                    )] public float zExtrudeUp;
		[Serialize("zExtrudeDown"                  )] public float zExtrudeDown;
		[Serialize("zExtrudeStop"                  )] public float zExtrudeStop;
		[Serialize("zExtrudeStart"                 )] public float zExtrudeStart;
		[Serialize("zExtrudeExtremityStart"        )] public float zExtrudeExtremityStart;
		[Serialize("zExtrudeExtremityStop"         )] public float zExtrudeExtremityStop;
		[Serialize("patchCoeffOffset"              )] public float patchCoeffOffset;
		[Serialize("patchScale"                    )] public float patchScale;
		[Serialize("patchOriented"                 )] public bool patchOriented;
		[Serialize("patchCornerFactorCollision"    )] public float patchCornerFactorCollision;
		[Serialize("patchAngleMin"                 )] public Angle patchAngleMin;
		[Serialize("ExtremityScale"                )] public Vector2 ExtremityScale;
		[Serialize("selfIllumColor"                )] public ColorInteger selfIllumColor;
		[Serialize("textureConfigs"                )] public CList<FriseTextureConfig> textureConfigs;
		[Serialize("gameMaterials"                 )] public CMap<StringID, Path> gameMaterials;
		[Serialize("VertexAnim"                    )] public VertexAnim VertexAnim;
		[Serialize("Fluid"                         )] public FluidConfig Fluid;
		[Serialize("mesh3D"                        )] public Mesh3dConfig mesh3D;
		[Serialize("invertMeshOrder"               )] public bool invertMeshOrder;
		[Serialize("skewAngle"                     )] public float skewAngle;
		[Serialize("isDigShape"                    )] public bool isDigShape;
		[Serialize("isLockedDigShape"              )] public bool isLockedDigShape;
		[Serialize("switchExtremityAuto"           )] public bool switchExtremityAuto;
		[Serialize("offsetExtremity"               )] public float offsetExtremity;
		[Serialize("slope_180"                     )] public StringID slope_180;
		[Serialize("slope_202"                     )] public StringID slope_202;
		[Serialize("slope_225"                     )] public StringID slope_225;
		[Serialize("slope_247"                     )] public StringID slope_247;
		[Serialize("slope_270"                     )] public StringID slope_270;
		[Serialize("slope_292"                     )] public StringID slope_292;
		[Serialize("slope_315"                     )] public StringID slope_315;
		[Serialize("slope_337"                     )] public StringID slope_337;
		[Serialize("slope_0"                       )] public StringID slope_0;
		[Serialize("slope_22"                      )] public StringID slope_22;
		[Serialize("slope_45"                      )] public StringID slope_45;
		[Serialize("slope_67"                      )] public StringID slope_67;
		[Serialize("slope_90"                      )] public StringID slope_90;
		[Serialize("slope_112"                     )] public StringID slope_112;
		[Serialize("slope_135"                     )] public StringID slope_135;
		[Serialize("slope_157"                     )] public StringID slope_157;
		[Serialize("idTexSwitch"                   )] public int idTexSwitch;
		[Serialize("cooked"                        )] public bool cooked;
		[Serialize("textureConfigIndexBySlope"     )] public CList<int> textureConfigIndexBySlope;
		[Serialize("textureConfigIndexByZone"      )] public CList<int> textureConfigIndexByZone;
		[Serialize("smoothVisual"                  )] public bool smoothVisual;
		[Serialize("PrimitiveParameters"           )] public GFXPrimitiveParam PrimitiveParameters;
		[Serialize("frieze3D"                      )] public Frieze3DConfig frieze3D;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RJR) {
				throw new Exception(s.Position + " - FriseConfig is internal/purebinary in RO version, but you can figure it out with RFR. TODO!");
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(gameMaterialExtremityStart));
				SerializeField(s, nameof(gameMaterialExtremityStop));
				SerializeField(s, nameof(visualOffset));
				SerializeField(s, nameof(regionId));
				SerializeField(s, nameof(useFriezeFlipToFlipUV));
				SerializeField(s, nameof(cornerFactor));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(methode));
				SerializeField(s, nameof(snapCoeff));
				SerializeField(s, nameof(snapCoeffUv));
				SerializeField(s, nameof(flexibility));
				SerializeField(s, nameof(wallAngle));
				SerializeField(s, nameof(isUvFlipX));
				SerializeField(s, nameof(isUvFlipY));
				SerializeField(s, nameof(isRatioFixed));
				SerializeField(s, nameof(smoothFactorVisual));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(density));
				SerializeField(s, nameof(collision));
				SerializeField(s, nameof(fill));
				SerializeField(s, nameof(zExtrudeUp));
				SerializeField(s, nameof(zExtrudeDown));
				SerializeField(s, nameof(zExtrudeStop));
				SerializeField(s, nameof(zExtrudeStart));
				SerializeField(s, nameof(zExtrudeExtremityStart));
				SerializeField(s, nameof(zExtrudeExtremityStop));
				SerializeField(s, nameof(patchCoeffOffset));
				SerializeField(s, nameof(patchScale));
				SerializeField(s, nameof(patchOriented));
				SerializeField(s, nameof(patchCornerFactorCollision));
				SerializeField(s, nameof(patchAngleMin));
				SerializeField(s, nameof(ExtremityScale));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(textureConfigs));
				SerializeField(s, nameof(VertexAnim));
				SerializeField(s, nameof(Fluid));
				SerializeField(s, nameof(skewAngle));
				SerializeField(s, nameof(isDigShape));
				SerializeField(s, nameof(isLockedDigShape));
				SerializeField(s, nameof(switchExtremityAuto));
				SerializeField(s, nameof(offsetExtremity));
				if (s.HasFlags(SerializeFlags.Flags9)) {
					SerializeField(s, nameof(slope_180));
					SerializeField(s, nameof(slope_202));
					SerializeField(s, nameof(slope_225));
					SerializeField(s, nameof(slope_247));
					SerializeField(s, nameof(slope_270));
					SerializeField(s, nameof(slope_292));
					SerializeField(s, nameof(slope_315));
					SerializeField(s, nameof(slope_337));
					SerializeField(s, nameof(slope_0));
					SerializeField(s, nameof(slope_22));
					SerializeField(s, nameof(slope_45));
					SerializeField(s, nameof(slope_67));
					SerializeField(s, nameof(slope_90));
					SerializeField(s, nameof(slope_112));
					SerializeField(s, nameof(slope_135));
					SerializeField(s, nameof(slope_157));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(idTexSwitch));
					SerializeField(s, nameof(cooked));
					SerializeField(s, nameof(textureConfigIndexBySlope));
					SerializeField(s, nameof(textureConfigIndexByZone));
					SerializeField(s, nameof(smoothVisual));
				}
				SerializeField(s, nameof(PrimitiveParameters));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(gameMaterialExtremityStart));
				SerializeField(s, nameof(gameMaterialExtremityStop));
				SerializeField(s, nameof(visualOffset));
				SerializeField(s, nameof(regionId));
				SerializeField(s, nameof(useFriezeFlipToFlipUV), boolAsByte: true);
				SerializeField(s, nameof(cornerFactor));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(methode));
				SerializeField(s, nameof(snapCoeff));
				SerializeField(s, nameof(snapCoeffUv));
				SerializeField(s, nameof(flexibility));
				SerializeField(s, nameof(wallAngle));
				SerializeField(s, nameof(isUvFlipX), boolAsByte: true);
				SerializeField(s, nameof(isUvFlipY), boolAsByte: true);
				SerializeField(s, nameof(isRatioFixed), boolAsByte: true);
				SerializeField(s, nameof(smoothFactorVisual));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(density));
				SerializeField(s, nameof(collision));
				SerializeField(s, nameof(fill));
				SerializeField(s, nameof(zExtrudeUp));
				SerializeField(s, nameof(zExtrudeDown));
				SerializeField(s, nameof(zExtrudeStop));
				SerializeField(s, nameof(zExtrudeStart));
				SerializeField(s, nameof(zExtrudeExtremityStart));
				SerializeField(s, nameof(zExtrudeExtremityStop));
				SerializeField(s, nameof(patchCoeffOffset));
				SerializeField(s, nameof(patchScale));
				SerializeField(s, nameof(patchOriented));
				SerializeField(s, nameof(patchCornerFactorCollision));
				SerializeField(s, nameof(patchAngleMin));
				SerializeField(s, nameof(ExtremityScale));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(textureConfigs));
				SerializeField(s, nameof(VertexAnim));
				SerializeField(s, nameof(Fluid));
				SerializeField(s, nameof(skewAngle));
				SerializeField(s, nameof(isDigShape), boolAsByte: true);
				SerializeField(s, nameof(isLockedDigShape), boolAsByte: true);
				SerializeField(s, nameof(switchExtremityAuto));
				SerializeField(s, nameof(offsetExtremity));
				if (s.HasFlags(SerializeFlags.Flags9)) {
					SerializeField(s, nameof(slope_180));
					SerializeField(s, nameof(slope_202));
					SerializeField(s, nameof(slope_225));
					SerializeField(s, nameof(slope_247));
					SerializeField(s, nameof(slope_270));
					SerializeField(s, nameof(slope_292));
					SerializeField(s, nameof(slope_315));
					SerializeField(s, nameof(slope_337));
					SerializeField(s, nameof(slope_0));
					SerializeField(s, nameof(slope_22));
					SerializeField(s, nameof(slope_45));
					SerializeField(s, nameof(slope_67));
					SerializeField(s, nameof(slope_90));
					SerializeField(s, nameof(slope_112));
					SerializeField(s, nameof(slope_135));
					SerializeField(s, nameof(slope_157));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(idTexSwitch));
					SerializeField(s, nameof(cooked), boolAsByte: true);
					SerializeField(s, nameof(textureConfigIndexBySlope));
					SerializeField(s, nameof(textureConfigIndexByZone));
					SerializeField(s, nameof(smoothVisual), boolAsByte: true);
				}
				SerializeField(s, nameof(PrimitiveParameters));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(gameMaterialExtremityStart));
				SerializeField(s, nameof(gameMaterialExtremityStop));
				SerializeField(s, nameof(visualOffset));
				SerializeField(s, nameof(regionId));
				SerializeField(s, nameof(useFriezeFlipToFlipUV));
				SerializeField(s, nameof(cornerFactor));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(methode));
				SerializeField(s, nameof(snapCoeff));
				SerializeField(s, nameof(snapCoeffUv));
				SerializeField(s, nameof(flexibility));
				SerializeField(s, nameof(wallAngle));
				SerializeField(s, nameof(isUvFlipX));
				SerializeField(s, nameof(isUvFlipY));
				SerializeField(s, nameof(isRatioFixed));
				SerializeField(s, nameof(smoothFactorVisual));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(density));
				SerializeField(s, nameof(collision));
				SerializeField(s, nameof(fill));
				SerializeField(s, nameof(zExtrudeUp));
				SerializeField(s, nameof(zExtrudeDown));
				SerializeField(s, nameof(zExtrudeStop));
				SerializeField(s, nameof(zExtrudeStart));
				SerializeField(s, nameof(zExtrudeExtremityStart));
				SerializeField(s, nameof(zExtrudeExtremityStop));
				SerializeField(s, nameof(patchCoeffOffset));
				SerializeField(s, nameof(patchScale));
				SerializeField(s, nameof(patchOriented));
				SerializeField(s, nameof(patchCornerFactorCollision));
				SerializeField(s, nameof(patchAngleMin));
				SerializeField(s, nameof(ExtremityScale));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(textureConfigs));
				SerializeField(s, nameof(VertexAnim));
				SerializeField(s, nameof(Fluid));
				SerializeField(s, nameof(mesh3D));
				SerializeField(s, nameof(invertMeshOrder));
				SerializeField(s, nameof(skewAngle));
				SerializeField(s, nameof(isDigShape));
				SerializeField(s, nameof(isLockedDigShape));
				SerializeField(s, nameof(switchExtremityAuto));
				SerializeField(s, nameof(offsetExtremity));
				if (s.HasFlags(SerializeFlags.Flags9)) {
					SerializeField(s, nameof(slope_180));
					SerializeField(s, nameof(slope_202));
					SerializeField(s, nameof(slope_225));
					SerializeField(s, nameof(slope_247));
					SerializeField(s, nameof(slope_270));
					SerializeField(s, nameof(slope_292));
					SerializeField(s, nameof(slope_315));
					SerializeField(s, nameof(slope_337));
					SerializeField(s, nameof(slope_0));
					SerializeField(s, nameof(slope_22));
					SerializeField(s, nameof(slope_45));
					SerializeField(s, nameof(slope_67));
					SerializeField(s, nameof(slope_90));
					SerializeField(s, nameof(slope_112));
					SerializeField(s, nameof(slope_135));
					SerializeField(s, nameof(slope_157));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(idTexSwitch));
					SerializeField(s, nameof(cooked));
					SerializeField(s, nameof(textureConfigIndexBySlope));
					SerializeField(s, nameof(textureConfigIndexByZone));
					SerializeField(s, nameof(smoothVisual));
				}
				SerializeField(s, nameof(PrimitiveParameters));
				SerializeField(s, nameof(frieze3D));
			} else {
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(gameMaterialExtremityStart));
				SerializeField(s, nameof(gameMaterialExtremityStop));
				SerializeField(s, nameof(visualOffset));
				SerializeField(s, nameof(regionId));
				SerializeField(s, nameof(useFriezeFlipToFlipUV));
				SerializeField(s, nameof(cornerFactor));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(methode));
				SerializeField(s, nameof(snapCoeff));
				SerializeField(s, nameof(snapCoeffUv));
				SerializeField(s, nameof(flexibility));
				SerializeField(s, nameof(wallAngle));
				SerializeField(s, nameof(isUvFlipX));
				SerializeField(s, nameof(isUvFlipY));
				SerializeField(s, nameof(isRatioFixed));
				SerializeField(s, nameof(smoothFactorVisual));
				SerializeField(s, nameof(scale));
				SerializeField(s, nameof(density));
				SerializeField(s, nameof(collision));
				SerializeField(s, nameof(fill));
				SerializeField(s, nameof(zExtrudeUp));
				SerializeField(s, nameof(zExtrudeDown));
				SerializeField(s, nameof(zExtrudeStop));
				SerializeField(s, nameof(zExtrudeStart));
				SerializeField(s, nameof(zExtrudeExtremityStart));
				SerializeField(s, nameof(zExtrudeExtremityStop));
				SerializeField(s, nameof(patchCoeffOffset));
				SerializeField(s, nameof(patchScale));
				SerializeField(s, nameof(patchOriented));
				SerializeField(s, nameof(patchCornerFactorCollision));
				SerializeField(s, nameof(patchAngleMin));
				SerializeField(s, nameof(ExtremityScale));
				SerializeField(s, nameof(selfIllumColor));
				SerializeField(s, nameof(textureConfigs));
				SerializeField(s, nameof(gameMaterials));
				SerializeField(s, nameof(VertexAnim));
				SerializeField(s, nameof(Fluid));
				SerializeField(s, nameof(mesh3D));
				SerializeField(s, nameof(invertMeshOrder));
				SerializeField(s, nameof(skewAngle));
				SerializeField(s, nameof(isDigShape));
				SerializeField(s, nameof(isLockedDigShape));
				SerializeField(s, nameof(switchExtremityAuto));
				SerializeField(s, nameof(offsetExtremity));
				if (s.HasFlags(SerializeFlags.Flags9)) {
					SerializeField(s, nameof(slope_180));
					SerializeField(s, nameof(slope_202));
					SerializeField(s, nameof(slope_225));
					SerializeField(s, nameof(slope_247));
					SerializeField(s, nameof(slope_270));
					SerializeField(s, nameof(slope_292));
					SerializeField(s, nameof(slope_315));
					SerializeField(s, nameof(slope_337));
					SerializeField(s, nameof(slope_0));
					SerializeField(s, nameof(slope_22));
					SerializeField(s, nameof(slope_45));
					SerializeField(s, nameof(slope_67));
					SerializeField(s, nameof(slope_90));
					SerializeField(s, nameof(slope_112));
					SerializeField(s, nameof(slope_135));
					SerializeField(s, nameof(slope_157));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(idTexSwitch));
					SerializeField(s, nameof(cooked));
					SerializeField(s, nameof(textureConfigIndexBySlope));
					SerializeField(s, nameof(textureConfigIndexByZone));
					SerializeField(s, nameof(smoothVisual));
				}
				SerializeField(s, nameof(PrimitiveParameters));
				SerializeField(s, nameof(frieze3D));
			}
		}
		public override uint? ClassCRC => 0xFEEFD98D;
	}
}

