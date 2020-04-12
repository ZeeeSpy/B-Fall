using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
	private static MusicScript _instance;

	public static MusicScript Instance { get { return _instance; } }
	private AudioClip[] OST;
	private AudioSource AS;

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
		DontDestroyOnLoad(this.gameObject);
		AS = GetComponent<AudioSource>();
		AS.Stop();
		OST = Resources.LoadAll<AudioClip>("OST");
		StartCoroutine(PlayMusic(Random.Range(0,OST.Length)));
	}

	IEnumerator PlayMusic(int number)
	{
		AS.clip = OST[number];
		AS.Play();
		yield return new WaitForSeconds(OST[number].length);
		AS.Stop();
		StartCoroutine(PlayMusic(Random.Range(0, OST.Length)));
	}
}
