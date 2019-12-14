using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class openSesame : MonoBehaviour {
    public GameObject swatches;
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



    public Slider E11Angle;
    public Slider E21Angle;
    public Slider E22Angle;
    public Slider E31Angle;
    public Slider E32Angle;
    public Slider B11Angle;
    public Slider B12Angle;
    public Slider B13Angle;
    public Slider B14Angle;
    public Slider B21Angle;
    public Slider B22Angle;
    public Slider B23Angle;
    public Slider B24Angle;
    public Slider B31Angle;
    public Slider B32Angle;
    public Slider B33Angle;
    public Slider B34Angle;
    public Slider B41Angle;
    public Slider B42Angle;
    public Slider B43Angle;
    public Slider B44Angle;

    public Dropdown E11Color;
    public Dropdown E21Color;
    public Dropdown E22Color;
    public Dropdown E31Color;
    public Dropdown E32Color;
    public Dropdown B11Color;
    public Dropdown B12Color;
    public Dropdown B13Color;
    public Dropdown B14Color;
    public Dropdown B21Color;
    public Dropdown B22Color;
    public Dropdown B23Color;
    public Dropdown B24Color;
    public Dropdown B31Color;
    public Dropdown B32Color;
    public Dropdown B33Color;
    public Dropdown B34Color;
    public Dropdown B41Color;
    public Dropdown B42Color;
    public Dropdown B43Color;
    public Dropdown B44Color;


    // Use this for initialization
    void Start () {
        UpdateHits();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
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
    void OnDisable()
    {
        PlayerPrefs.SetFloat("E11Angle", E11Angle.value);
        PlayerPrefs.SetFloat("E21Angle", E21Angle.value);
        PlayerPrefs.SetFloat("E22Angle", E22Angle.value);
        PlayerPrefs.SetFloat("E31Angle", E31Angle.value);
        PlayerPrefs.SetFloat("E32Angle", E32Angle.value);
        PlayerPrefs.SetFloat("B11Angle", B11Angle.value);
        PlayerPrefs.SetFloat("B12Angle", B12Angle.value);
        PlayerPrefs.SetFloat("B13Angle", B13Angle.value);
        PlayerPrefs.SetFloat("B14Angle", B14Angle.value);
        PlayerPrefs.SetFloat("B21Angle", B21Angle.value);
        PlayerPrefs.SetFloat("B22Angle", B22Angle.value);
        PlayerPrefs.SetFloat("B23Angle", B23Angle.value);
        PlayerPrefs.SetFloat("B24Angle", B24Angle.value);
        PlayerPrefs.SetFloat("B31Angle", B31Angle.value);
        PlayerPrefs.SetFloat("B32Angle", B32Angle.value);
        PlayerPrefs.SetFloat("B33Angle", B33Angle.value);
        PlayerPrefs.SetFloat("B34Angle", B34Angle.value);
        PlayerPrefs.SetFloat("B41Angle", B41Angle.value);
        PlayerPrefs.SetFloat("B42Angle", B42Angle.value);
        PlayerPrefs.SetFloat("B43Angle", B43Angle.value);
        PlayerPrefs.SetFloat("B44Angle", B44Angle.value);


        PlayerPrefs.SetInt("E11Color", E11Color.value);
        PlayerPrefs.SetInt("E21Color", E21Color.value);
        PlayerPrefs.SetInt("E22Color", E22Color.value);
        PlayerPrefs.SetInt("E31Color", E31Color.value);
        PlayerPrefs.SetInt("E32Color", E32Color.value);
        PlayerPrefs.SetInt("B11Color", B11Color.value);
        PlayerPrefs.SetInt("B12Color", B12Color.value);
        PlayerPrefs.SetInt("B13Color", B13Color.value);
        PlayerPrefs.SetInt("B14Color", B14Color.value);
        PlayerPrefs.SetInt("B21Color", B21Color.value);
        PlayerPrefs.SetInt("B22Color", B22Color.value);
        PlayerPrefs.SetInt("B23Color", B23Color.value);
        PlayerPrefs.SetInt("B24Color", B24Color.value);
        PlayerPrefs.SetInt("B31Color", B31Color.value);
        PlayerPrefs.SetInt("B32Color", B32Color.value);
        PlayerPrefs.SetInt("B33Color", B33Color.value);
        PlayerPrefs.SetInt("B34Color", B34Color.value);
        PlayerPrefs.SetInt("B41Color", B41Color.value);
        PlayerPrefs.SetInt("B42Color", B42Color.value);
        PlayerPrefs.SetInt("B43Color", B43Color.value);
        PlayerPrefs.SetInt("B44Color", B44Color.value);
    }
    void CastRay()
    {

        PointerEventData pointerData = new PointerEventData(EventSystem.current);

        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        if (results.Count > 0)
        {
            if (results[results.Count - 2].gameObject.name == "Swatchbook")
            {
                swatches.SetActive(true);
            }
        }
    }
}
