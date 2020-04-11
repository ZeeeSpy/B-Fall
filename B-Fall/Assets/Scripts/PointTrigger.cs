using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{

	private bool Activated = false;
	private bool Called = false;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			Activated = true;
		}
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			if (Activated && !Called)
			{
				Called = true;
				Points.Instance.IncreaseScore();
			}
		}
	}

	public void ResetPoint()
	{
		Activated = false;
		Called = false;
	}
}
