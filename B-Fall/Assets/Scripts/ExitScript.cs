using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
	private void OnMouseDown()
	{
		Application.Quit();
	}

	public void ExitMethod()
	{
		Application.Quit();
	}
}
