using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
	public Rigidbody2D PlayerRB;
	private const float gravityV = 9.81f;

	private void FixedUpdate()
	{
		PlayerRB.AddForce(Vector2.down * gravityV, ForceMode2D.Force);
	}
}
