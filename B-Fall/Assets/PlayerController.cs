using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody2D PlayerRB;

    void Update()
    {
		if (Input.GetAxis("Horizontal") != 0)
		{
			int dir = Input.GetAxis("Horizontal") > 0 ? 1 : -1;
			Vector2 NewDirection = new Vector2(dir, 0);
			PlayerRB.AddForce(NewDirection * 0.25f, ForceMode2D.Impulse);
		}    
    }
}
