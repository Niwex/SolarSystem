using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptuneConroller : MonoBehaviour
{
    public float radius = 100f;
    public float speed = 0.4f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = GetPosition(Time.time * speed);
    }

    private Vector3 GetPosition(float angle)
    {
        return new Vector3(radius * Mathf.Sin(angle), 0, radius * Mathf.Cos(angle));
    }

	void OnMouseDown() {
		bool zoom = ZoomTarget.zoom;
		if (zoom) {
			ZoomTarget.zoom = false;
			ZoomTarget.target_tag = 0;
			TimeScale.header = "Solar System";
			TimeScale.info = "Mercury\nVenus\nEarth\nMars\nJupiter\nSaturn\nUranus\nNeptune";
		} else {
			ZoomTarget.zoom = true;
			ZoomTarget.target_tag = 9;
			TimeScale.header = "Neptune";
			TimeScale.info = "Mass: 1,0243⋅10^26 kg\nDiameter: 49 528 km\nGravity: 11,15 m/s^2\nDistance from Sun: 4 452 940 833 km";
		}
	}
}
