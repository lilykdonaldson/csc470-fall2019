using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour {
    public GameObject swatches;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(PlayerPrefs.GetInt("E11b"));
    }
    public void ToStage()
    {
        SceneManager.LoadScene("Stage");
    }

    public void ToColors()
    {
        SceneManager.LoadScene("InstrumentEditor");
    }
    public void ToCAD()
    {
        SceneManager.LoadScene("CAD");
    }

    public void XOut()
    {
        swatches.SetActive(false);
    }
    public void Done()
    {
        ResetBegin();
        Debug.Log(PlayerPrefs.GetInt("E11b"));

       SceneManager.LoadScene("Start");
    }



    private void ResetBegin()
    {
        Debug.Log("reset");
        PlayerPrefs.SetFloat("E11Angle", 4);
        PlayerPrefs.SetFloat("E21Angle", 4);
        PlayerPrefs.SetFloat("E22Angle", 4);
        PlayerPrefs.SetFloat("E31Angle", 4);
        PlayerPrefs.SetFloat("E32Angle", 4);
        PlayerPrefs.SetFloat("B11Angle", 4);
        PlayerPrefs.SetFloat("B12Angle", 4);
        PlayerPrefs.SetFloat("B13Angle", 4);
        PlayerPrefs.SetFloat("B14Angle", 4);
        PlayerPrefs.SetFloat("B21Angle", 4);
        PlayerPrefs.SetFloat("B22Angle", 4);
        PlayerPrefs.SetFloat("B23Angle", 4);
        PlayerPrefs.SetFloat("B24Angle", 4);
        PlayerPrefs.SetFloat("B31Angle", 4);
        PlayerPrefs.SetFloat("B32Angle", 4);
        PlayerPrefs.SetFloat("B33Angle", 4);
        PlayerPrefs.SetFloat("B34Angle", 4);
        PlayerPrefs.SetFloat("B41Angle", 4);
        PlayerPrefs.SetFloat("B42Angle", 4);
        PlayerPrefs.SetFloat("B43Angle", 4);
        PlayerPrefs.SetFloat("B44Angle", 4);


        PlayerPrefs.SetInt("E11Color", 0);
        PlayerPrefs.SetInt("E21Color", 0);
        PlayerPrefs.SetInt("E22Color", 0);
        PlayerPrefs.SetInt("E31Color", 0);
        PlayerPrefs.SetInt("E32Color", 0);
        PlayerPrefs.SetInt("B11Color", 0);
        PlayerPrefs.SetInt("B12Color", 0);
        PlayerPrefs.SetInt("B13Color", 0);
        PlayerPrefs.SetInt("B14Color", 0);
        PlayerPrefs.SetInt("B21Color", 0);
        PlayerPrefs.SetInt("B22Color", 0);
        PlayerPrefs.SetInt("B23Color", 0);
        PlayerPrefs.SetInt("B24Color", 0);
        PlayerPrefs.SetInt("B31Color", 0);
        PlayerPrefs.SetInt("B32Color", 0);
        PlayerPrefs.SetInt("B33Color", 0);
        PlayerPrefs.SetInt("B34Color", 0);
        PlayerPrefs.SetInt("B41Color", 0);
        PlayerPrefs.SetInt("B42Color", 0);
        PlayerPrefs.SetInt("B43Color", 0);
        PlayerPrefs.SetInt("B44Color", 0);

        PlayerPrefs.SetInt("E11b", 1);
        PlayerPrefs.SetInt("E21b", 1);
        PlayerPrefs.SetInt("E22b", 1);
        PlayerPrefs.SetInt("E31b", 1);
        PlayerPrefs.SetInt("E32b", 1);
        PlayerPrefs.SetInt("B11b", 1);
        PlayerPrefs.SetInt("B12b", 1);
        PlayerPrefs.SetInt("B13b", 1);
        PlayerPrefs.SetInt("B14b", 1);
        PlayerPrefs.SetInt("B21b", 1);
        PlayerPrefs.SetInt("B22b", 1);
        PlayerPrefs.SetInt("B23b", 1);
        PlayerPrefs.SetInt("B24b", 1);
        PlayerPrefs.SetInt("B31b", 1);
        PlayerPrefs.SetInt("B32b", 1);
        PlayerPrefs.SetInt("B33b", 1);
        PlayerPrefs.SetInt("B34b", 1);
        PlayerPrefs.SetInt("B41b", 1);
        PlayerPrefs.SetInt("B42b", 1);
        PlayerPrefs.SetInt("B43b", 1);
        PlayerPrefs.SetInt("B44b", 1);



    }
}
