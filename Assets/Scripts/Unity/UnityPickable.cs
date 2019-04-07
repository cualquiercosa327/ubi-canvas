﻿using UnityEngine;
using UbiArt;
using UbiArt.ITF;
using System.Linq;

public class UnityPickable : MonoBehaviour {
	public Pickable pickable;
	private SpriteRenderer sr;

	private void Start() {
		CreateMesh();
		UpdateGizmo();
	}

	private void Update() {
		if (sr != null) {
			sr.enabled = MapLoader.Loader.controller.displayGizmos;
			if (sr.enabled) {
				sr.size = new Vector2(
					transform.lossyScale.x != 0 ? (1f / transform.lossyScale.x) : 1f,
					transform.lossyScale.y != 0 ? (1f / transform.lossyScale.y) : 1f);
			}
		}
		if (pickable != null) {
			if (transform.localPosition != new Vector3(pickable.POS2D.x, pickable.POS2D.y, -pickable.RELATIVEZ)) {
				pickable.POS2D = new Vector2(transform.localPosition.x, transform.localPosition.y);

				if (pickable.RELATIVEZ != -transform.localPosition.z) {
					pickable.RELATIVEZ = -transform.localPosition.z;
					MapLoader.Loader.controller.zListManager.Sort(printMessages: false);
				}
			}
		}
	}
	void UpdateGizmo() {
		Sprite spr = null;
		if (pickable != null) {
			if (pickable is Frise) {
				Frise f = pickable as Frise;
				if (f.config != null && f.config.obj != null && f.config.obj.TAGS != null) {
					if (f.config.obj.TAGS.Contains("front_lgt_frieze")) {
						spr = MapLoader.Loader.controller.GetIcon("light_front");
					} else if(f.config.obj.TAGS.Contains("back_lgt_frieze")) {
						spr = MapLoader.Loader.controller.GetIcon("light_back");
					}
				}
			} else if (pickable is Actor) {
				if (pickable is SubSceneActor) {
					SubSceneActor ssa = pickable as SubSceneActor;
					if (ssa.RELATIVEPATH != null && !ssa.RELATIVEPATH.IsNull) {
						if (ssa.RELATIVEPATH.filename.EndsWith("_graph.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_graph");
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_fx.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_fx");
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_ld.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_ld");
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_cine.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_cine");
						} else if (ssa.RELATIVEPATH.filename.EndsWith("_sound.isc")) {
							spr = MapLoader.Loader.controller.GetIcon("isc_sound");
						}
					}
					if (spr == null) {
						spr = MapLoader.Loader.controller.GetIcon("isc");
					}
				} else {
					spr = MapLoader.Loader.controller.GetIcon("actor");
				}
			}
		}
		if (spr != null) {
			sr.sprite = spr;
		}
	}

	void CreateTexture() {
	}

	void CreateMesh() {
		sr = gameObject.AddComponent<SpriteRenderer>();
		sr.drawMode = SpriteDrawMode.Sliced;
		//sr.sharedMaterial = new Material(Shader.Find("Custom/Gizmo"));
		/*mr.sharedMaterial = unityMat;
		Mesh meshUnity = new Mesh();
		Vector3[] vertices = new Vector3[4];
		vertices[0] = new Vector3(0, -1, -1);
		vertices[1] = new Vector3(0, -1, 1);
		vertices[2] = new Vector3(0, 1, -1);
		vertices[3] = new Vector3(0, 1, 1);
		Vector3[] normals = new Vector3[4];
		normals[0] = Vector3.forward;
		normals[1] = Vector3.forward;
		normals[2] = Vector3.forward;
		normals[3] = Vector3.forward;
		Vector2[] uvs = new Vector2[4];
		uvs[0] = new Vector2(0, 0);
		uvs[1] = new Vector2(1, 0);
		uvs[2] = new Vector2(0, 1);
		uvs[3] = new Vector2(1, 1);
		int[] triangles = new int[] { 0, 2, 1, 1, 2, 3 };

		meshUnity.vertices = vertices;
		meshUnity.normals = normals;
		meshUnity.triangles = triangles;
		meshUnity.uv = uvs;


		mf.mesh = meshUnity;*/
	}
}
