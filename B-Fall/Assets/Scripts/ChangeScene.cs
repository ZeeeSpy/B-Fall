﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
	public string LevelName;

	public void UIButtonChangeScene()
	{
		SceneManager.LoadScene(LevelName);
	}
}
