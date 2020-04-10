using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
	private const float MaxLeft = -5.25f;
	private const float MaxRight = -1.5f;
	private float speed = 0.05f;


	private void Awake()
	{
		ShuffleHole();
		StartCoroutine(IncreaseSpeed());
	}

	void FixedUpdate()
    {
		transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z); ;

		if (transform.position.y > 5.25)
		{
			transform.position = new Vector3(transform.position.x, -5.4f, transform.position.z);

		}
	}

	private void ShuffleHole()
	{
		float XVal = Random.Range(MaxLeft, MaxRight);
		transform.position = new Vector3(XVal, transform.position.y, transform.position.z);
	}

	IEnumerator IncreaseSpeed()
	{
		while (true)
		{
			yield return new WaitForSeconds(2.5f);
			speed = speed + 0.0025f;
		}
	}
}
