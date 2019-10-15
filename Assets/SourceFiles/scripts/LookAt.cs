using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	[Header("Номер текущей планеты, на которую смотрит камера")]
	public int currentPlanet = 0;
	[Header("Список всех планет (ссылки на их положение)")]
	public Transform[] planets = new Transform[10];


	void Update () 
	{
		transform.LookAt(planets[currentPlanet].position);

		if(Input.GetKeyDown(KeyCode.LeftArrow) && currentPlanet > 0)
		{
			if(planets[currentPlanet-1]!=null)
				currentPlanet--;
		}
		if(Input.GetKeyDown(KeyCode.RightArrow) && currentPlanet < 9)
		{
			if(planets[currentPlanet+1]!=null)
				currentPlanet++;
		}

	}
}
