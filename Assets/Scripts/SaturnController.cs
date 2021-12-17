using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnController : MonoBehaviour
{
   public float radius = 80f;
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
			ZoomTarget.target_tag = 7;
			TimeScale.header = "Saturn";
			TimeScale.info = "Mass: 5,6846⋅10^26 kg\nDiameter: 120 536 km\nGravity: 10,44 m/s^2\nDistance from Sun: 1 353 572 956 km";
		}
	}
}
