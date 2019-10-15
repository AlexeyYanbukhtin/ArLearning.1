using UnityEngine;
using System.Collections;

public class PlanetRotation : MonoBehaviour {

	[Header("Вокруг чего происходит вращение")]
	public Transform planetToRotate;
	[Header("Скорость вращения (градусы в секунду)")]
	public float speed = 0;

	void Update () 
	{
		gameObject.transform.RotateAround(planetToRotate.position, Vector3.up, speed*Time.deltaTime);
	}
}
