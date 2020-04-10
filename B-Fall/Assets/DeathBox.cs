using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
	public GameObject player;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player")){
			player.SetActive(false);

			//Save highscore
			//Show Retry/Quit/Highscores
		}
	}
}
