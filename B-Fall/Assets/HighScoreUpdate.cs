using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreUpdate : MonoBehaviour
{
	public GameObject Button;
	private TextMesh[] HighscoreTM;
	private string[] suffix = new string[] {"NOPE","st","nd","rd","th","th","th","th","th"};
	private void Awake()
	{
		HighscoreTM = new TextMesh[transform.childCount];
		int count = 1;
		foreach (Transform child in transform)
		{
			child.GetComponent<TextMesh>().text = count.ToString() +suffix[count] + " :" + PlayerPrefs.GetInt(count.ToString(),000);
			count++;
			child.gameObject.AddComponent<BoxCollider2D>();
		}

		StartCoroutine(ActivateButton());
	}

	IEnumerator ActivateButton() {
		yield return new WaitForSeconds(1f);
		Button.SetActive(true);
	}
}
