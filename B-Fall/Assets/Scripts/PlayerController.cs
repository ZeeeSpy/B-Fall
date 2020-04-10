using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody2D PlayerRB;
	private bool Moving = false;
	private bool MovingLeft = false;

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
			PlayerRB.AddForce(NewDirection * 0.25f, ForceMode2D.Impulse);
		}
    }

	public void MoveLeft()
	{
		Moving = true;
		MovingLeft = true;
	}

	public void MoveRight()
	{
		Moving = true;
		MovingLeft = false;
	}

	public void NotMoving()
	{
		Moving = false;
	}
}
