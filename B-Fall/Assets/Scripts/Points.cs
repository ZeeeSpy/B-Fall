using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
	private static Points _instance;

	public static Points Instance { get { return _instance; } }

	private int score = 0;
	public Text ScoreText;

	private void Awake()
	{
		if (_instance != null && _instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			_instance = this;
		}
	}

	public void IncreaseScore()
	{
		score = score + 1;
		ScoreText.text = score.ToString();
	}

	public int GetScore()
	{
		return score;
	}
}
