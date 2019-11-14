using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chosenMe : MonoBehaviour {
    private bool queriesHitTriggers;

    // Use this for initialization
    void Start () {
        queriesHitTriggers = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartMe()
    {
        SceneManager.LoadScene("CandyCorn");
    }
}
