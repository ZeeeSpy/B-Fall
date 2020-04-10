using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class DeathBox : MonoBehaviour
{
	public GameObject player;
	public GameObject ButtonParent;
	public GameObject DeathButtons;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Player")){
			SaveHighScore();
			player.SetActive(false);
			ButtonParent.SetActive(false);
			DeathButtons.SetActive(true);
		}
	}

	private void SaveHighScore()
	{
		int NewScore = Points.Instance.GetScore();
		int[] highscores = new int[9];
		highscores[0] = NewScore;

		for (int i = 1; i <= 8; i++)
		{
			highscores[i] = PlayerPrefs.GetInt(i.ToString());
		}

		Array.Sort(highscores);
		Array.Reverse(highscores);

		for (int q = 0; q <= 8; q++)
		{
			int temp = q + 1;
			PlayerPrefs.SetInt(temp.ToString(),highscores[q]);
		}
	}
}
