using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody2D PlayerRB;
	private bool Moving = false;
	private bool MovingLeft = false;
	private int currentpress = 0;

    void Update()
    {
		if (Moving)
		{
			int dir = 0;
			if (MovingLeft)
			{
				dir = -1;
			} else
			{
				dir = 1;
			}


			Vector2 NewDirection = new Vector2(dir, 0);
			PlayerRB.AddForce(NewDirection * 1f, ForceMode2D.Impulse);
		}
    }

	public void MoveLeft()
	{
		Moving = true;
		MovingLeft = true;
		currentpress++;
	}

	public void MoveRight()
	{
		Moving = true;
		MovingLeft = false;
		currentpress++;
	}

	public void NotPress()
	{
		currentpress--;
		if (currentpress == 0)
		{
			Moving = false;
		}
	}
}
