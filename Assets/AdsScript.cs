﻿using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdsScript : MonoBehaviour {

	void Start () {

	}
	
	void Update () {
			ShowAd();
	}

	public void ShowAd()
	{
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
		}
	}
}
