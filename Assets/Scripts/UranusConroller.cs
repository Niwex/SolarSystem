using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusConroller : MonoBehaviour
{
  public float radius = 90f;
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
			ZoomTarget.target_tag = 8;
			TimeScale.header = "Uranus";
			TimeScale.info = "Mass: 8,6813⋅10^25 kg\nDiameter: 51 118 km\nGravity: 8,87 m/s^2\nDistance from Sun: 2 748 938 461 km";
		}
	}
}
