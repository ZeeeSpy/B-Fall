﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public string LevelName;
	private void OnMouseDown()
	{
		SceneManager.LoadScene(LevelName);
	}

	public void UIButtonChangeScene()
	{
		SceneManager.LoadScene(LevelName);
	}
}
