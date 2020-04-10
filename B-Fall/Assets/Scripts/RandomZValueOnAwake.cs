using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomZValueOnAwake : MonoBehaviour
{
	private void Awake()
	{
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, Random.Range(0,90f));
	}
}
