using UnityEngine;
using System.Collections;

public class ProceduralSun : MonoBehaviour {

	public float secondsInFullDay = 120f;
	[Range(0,1)]
	public float currentTimeOfDay = 0;
	[HideInInspector]
	public float timeMultiplier = 1f;

	public float sunInitialIntensity;

	private Light m_Light;
	private Transform m_Transform;

	void Start()
	{
		m_Transform = this.GetComponent<Transform> ();
		m_Light = this.GetComponent<Light> ();
	}

	void Update()
	{
		UpdateSun ();

		// Time of day is a float ranging between 0 and 1
		currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;

		if (currentTimeOfDay >= 1) {
			currentTimeOfDay = 0;
		}
	}

	void UpdateSun()
	{
		m_Transform.localRotation = Quaternion.Euler ((currentTimeOfDay * 360) - 90, 170, 0);

		float intensityMultiplier = 1;
		if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f) {
			intensityMultiplier = 0;
		}
		else if (currentTimeOfDay <= 0.25f) {
			intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
		}
		else if (currentTimeOfDay >= 0.73f) {
			intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
		}
		
		//sun.intensity = sunInitialIntensity * intensityMultiplier;
	}
}
