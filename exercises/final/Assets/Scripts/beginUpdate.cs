using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beginUpdate : MonoBehaviour {
    public GameObject E11;
   int E11b;

    public GameObject E21;
    public GameObject E22;
    int E21b;
    int E22b;

    public GameObject E31;
    public GameObject E32;
    int E31b;
    int E32b;

    public GameObject B11;
    public GameObject B12;
    public GameObject B13;
    public GameObject B14;
    int B11b;
    int B12b;
    int B13b;
    int B14b;

    public GameObject B21;
    public GameObject B22;
    public GameObject B23;
    public GameObject B24;
    int B21b;
    int B22b;
    int B23b;
    int B24b;

    public GameObject B31;
    public GameObject B32;
    public GameObject B33;
    public GameObject B34;
    int B31b;
    int B32b;
    int B33b;
    int B34b;

    public GameObject B41;
    public GameObject B42;
    public GameObject B43;
    public GameObject B44;
    int B41b;
    int B42b;
    int B43b;
    int B44b;


    public Light E11L;
    public Light E21L;
    public Light E22L;
    public Light E31L;
    public Light E32L;

    public Light B11L;
    public Light B12L;
    public Light B13L;
    public Light B14L;
    public Light B21L;
    public Light B22L;
    public Light B23L;
    public Light B24L;

    public Light B31L;
    public Light B32L;
    public Light B33L;
    public Light B34L;
    public Light B41L;
    public Light B42L;
    public Light B43L;
    public Light B44L;


    // Use this for initialization
    void Start () {
        UpdateLights();
        UpdateHits();


    }
	
	// Update is called once per frame
	void Update () {

		
	}

    void OnEnable()
    {
        E11b = PlayerPrefs.GetInt("E11b");
        E21b = PlayerPrefs.GetInt("E21b");
        E22b = PlayerPrefs.GetInt("E22b");
        E31b = PlayerPrefs.GetInt("E31b");
        E32b = PlayerPrefs.GetInt("E32b");
        B11b = PlayerPrefs.GetInt("B11b");
        B12b = PlayerPrefs.GetInt("B12b");
        B13b = PlayerPrefs.GetInt("B13b");
        B14b = PlayerPrefs.GetInt("B14b");
        B21b = PlayerPrefs.GetInt("B21b");
        B22b = PlayerPrefs.GetInt("B22b");
        B23b = PlayerPrefs.GetInt("B23b");
        B24b = PlayerPrefs.GetInt("B24b");
        B31b = PlayerPrefs.GetInt("B31b");
        B32b = PlayerPrefs.GetInt("B32b");
        B33b = PlayerPrefs.GetInt("B33b");
        B34b = PlayerPrefs.GetInt("B34b");
        B41b = PlayerPrefs.GetInt("B41b");
        B42b = PlayerPrefs.GetInt("B42b");
        B43b = PlayerPrefs.GetInt("B43b");
        B44b = PlayerPrefs.GetInt("B44b");


    }
    void UpdateHits()
    {
        if (E11b == 1) { E11.SetActive(true); } else { E11.SetActive(false); }
        if (E21b == 1) { E21.SetActive(true); } else { E21.SetActive(false); }
        if (E22b == 1) { E22.SetActive(true); } else { E22.SetActive(false); }
        if (E31b == 1) { E31.SetActive(true); } else { E31.SetActive(false); }
        if (E32b == 1) { E32.SetActive(true); } else { E32.SetActive(false); }
        if (B11b == 1) { B11.SetActive(true); } else { B11.SetActive(false); }
        if (B12b == 1) { B12.SetActive(true); } else { B12.SetActive(false); }
        if (B13b == 1) { B13.SetActive(true); } else { B13.SetActive(false); }
        if (B14b == 1) { B14.SetActive(true); } else { B14.SetActive(false); }
        if (B21b == 1) { B21.SetActive(true); } else { B21.SetActive(false); }
        if (B22b == 1) { B22.SetActive(true); } else { B22.SetActive(false); }
        if (B23b == 1) { B23.SetActive(true); } else { B23.SetActive(false); }
        if (B24b == 1) { B24.SetActive(true); } else { B24.SetActive(false); }
        if (B31b == 1) { B31.SetActive(true); } else { B31.SetActive(false); }
        if (B32b == 1) { B32.SetActive(true); } else { B32.SetActive(false); }
        if (B33b == 1) { B33.SetActive(true); } else { B33.SetActive(false); }
        if (B34b == 1) { B34.SetActive(true); } else { B34.SetActive(false); }
        if (B41b == 1) { B41.SetActive(true); } else { B41.SetActive(false); }
        if (B42b == 1) { B42.SetActive(true); } else { B42.SetActive(false); }
        if (B43b == 1) { B43.SetActive(true); } else { B43.SetActive(false); }
        if (B44b == 1) { B44.SetActive(true); } else { B44.SetActive(false); }
    }
    void UpdateLights()
    {
        E11L.range = PlayerPrefs.GetFloat("E11Angle");
        E21L.range = PlayerPrefs.GetFloat("E21Angle");
        E22L.range = PlayerPrefs.GetFloat("E22Angle");
        E31L.range = PlayerPrefs.GetFloat("E31Angle");
        E32L.range = PlayerPrefs.GetFloat("E32Angle");
        B11L.range = PlayerPrefs.GetFloat("B11Angle");
        B12L.range = PlayerPrefs.GetFloat("B12Angle");
        B13L.range = PlayerPrefs.GetFloat("B13Angle");
        B14L.range = PlayerPrefs.GetFloat("B14Angle");
        B21L.range = PlayerPrefs.GetFloat("B21Angle");
        B22L.range = PlayerPrefs.GetFloat("B22Angle");
        B23L.range = PlayerPrefs.GetFloat("B23Angle");
        B24L.range = PlayerPrefs.GetFloat("B24Angle");
        B31L.range = PlayerPrefs.GetFloat("B31Angle");
        B32L.range = PlayerPrefs.GetFloat("B32Angle");
        B33L.range = PlayerPrefs.GetFloat("B33Angle");
        B34L.range = PlayerPrefs.GetFloat("B34Angle");
        B41L.range = PlayerPrefs.GetFloat("B41Angle");
        B42L.range = PlayerPrefs.GetFloat("B42Angle");
        B43L.range = PlayerPrefs.GetFloat("B43Angle");
        B44L.range = PlayerPrefs.GetFloat("B44Angle");


        E11L.color = WhichSwatch(PlayerPrefs.GetInt("E11Color"));
        E21L.color = WhichSwatch(PlayerPrefs.GetInt("E21Color"));
        E22L.color = WhichSwatch(PlayerPrefs.GetInt("E22Color"));
        E31L.color = WhichSwatch(PlayerPrefs.GetInt("E31Color"));
        E32L.color = WhichSwatch(PlayerPrefs.GetInt("E32Color"));
        B11L.color = WhichSwatch(PlayerPrefs.GetInt("B11Color"));
        B12L.color = WhichSwatch(PlayerPrefs.GetInt("B12Color"));
        B13L.color = WhichSwatch(PlayerPrefs.GetInt("B13Color"));
        B14L.color = WhichSwatch(PlayerPrefs.GetInt("B14Color"));
        B21L.color = WhichSwatch(PlayerPrefs.GetInt("B21Color"));
        B22L.color = WhichSwatch(PlayerPrefs.GetInt("B22Color"));
        B23L.color = WhichSwatch(PlayerPrefs.GetInt("B23Color"));
        B24L.color = WhichSwatch(PlayerPrefs.GetInt("B24Color"));
        B31L.color = WhichSwatch(PlayerPrefs.GetInt("B31Color"));
        B32L.color = WhichSwatch(PlayerPrefs.GetInt("B32Color"));
        B33L.color = WhichSwatch(PlayerPrefs.GetInt("B33Color"));
        B34L.color = WhichSwatch(PlayerPrefs.GetInt("B34Color"));
        B41L.color = WhichSwatch(PlayerPrefs.GetInt("B41Color"));
        B42L.color = WhichSwatch(PlayerPrefs.GetInt("B42Color"));
        B43L.color = WhichSwatch(PlayerPrefs.GetInt("B43Color"));
        B44L.color = WhichSwatch(PlayerPrefs.GetInt("B44Color"));




    }

    Color WhichSwatch(int x)
    {
        switch (x)
        {
            case 0:
                return new Color32(245, 0, 20, 255);
            case 1:
                return new Color32(180, 130, 255, 255);
            case 2:
                return new Color32(251, 179, 154, 255);
            case 3:
                return new Color32(3, 171, 255, 255);
            case 4:
                return new Color32(0, 127, 6, 255);
            case 5:
                return new Color32(208, 136, 100, 255);
            case 6:
                return new Color32(255, 210, 27, 255);
            case 7:
                return new Color32(255, 102, 19, 255);
            case 8:
                return new Color32(80, 173, 253, 255);
            default:
                return new Color32(245, 0, 20, 255);
        }
    }
}
