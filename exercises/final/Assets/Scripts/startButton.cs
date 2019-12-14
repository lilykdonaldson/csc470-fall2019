using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("E11b"));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartGo()
    {
        SceneManager.LoadScene("CAD");
    }
}
