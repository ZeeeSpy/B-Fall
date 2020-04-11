using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreenStuff : MonoBehaviour
{
	void Update()
	{
		for (var i = 0; i < Input.touchCount; ++i)
		{
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{

				RaycastHit hit;
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
				// Create a particle if hit
				if (Physics.Raycast(ray, out hit))
				{
					if (hit.collider != null)
					{
						 Debug.Log(hit.collider.gameObject.name);
					}

				}
					
			}
		}
	}
}
