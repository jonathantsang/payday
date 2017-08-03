using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapher1 : MonoBehaviour {

	[Range(10, 100)]
	public int resolution = 10;

	private int currentResolution;
	private ParticleSystem.Particle[] points;
	private ParticleSystem PS;

	void Start () {
		PS = GetComponent<ParticleSystem> ();
		CreatePoints ();
	}

	private void CreatePoints () {
		if (resolution < 10 || resolution > 100) {
			Debug.LogWarning("Grapher resolution out of bounds, resetting to minimum.", this);
			resolution = 10;
		}
		currentResolution = resolution;
		points = new ParticleSystem.Particle[resolution];
		float increment = 1f / (resolution - 1);
		for(int i = 0; i < resolution; i++){
			float x = i * increment;
			points[i].position = new Vector3(x, 0f, 0f);
			points[i].startColor = new Color(x, 0f, 0f);
			points[i].startSize = 0.1f;
		}
	}
	
	void Update () {
		if (currentResolution != resolution) {
			CreatePoints();
		}
		for (int i = 0; i < resolution; i++) {
			Vector3 p = points[i].position;
			p.y = p.x;
			points[i].position = p;
			Color c = points[i].startColor;
			c.g = p.y;
			points[i].startColor = c;
		}
		PS.SetParticles(points, points.Length);
	}
}
