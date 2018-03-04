using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class AnalyticsScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Gender gender = Gender.Male;
		Analytics.SetUserGender(gender);

		int birthYear = 1982;
		Analytics.SetUserBirthYear(birthYear);
		LevelUp();
	}
	
	void LevelUp()
	{
		Analytics.Transaction("leveUp", 1, "USD", null, null);

		Analytics.CustomEvent("levelUp", new Dictionary<string, object>
		{
			{ "newLevel", 2 },
			{ "trigger", "purchase" },
		});
	}

	// Update is called once per frame
	void Update () {
	
	}
}
