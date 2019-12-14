using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class addLight : MonoBehaviour
{
    public GameObject E11;
    public bool E11b = true;

    public GameObject E21;
    public GameObject E22;
    static bool E21b = true;
    static bool E22b = true;

    public GameObject E31;
    public GameObject E32;
    static bool E31b = true;
    static bool E32b = true;

    public GameObject B11;
    public GameObject B12;
    public GameObject B13;
    public GameObject B14;
    static bool B11b = true;
    static bool B12b = true;
    static bool B13b = true;
    static bool B14b = true;

    public GameObject B21;
    public GameObject B22;
    public GameObject B23;
    public GameObject B24;
    static bool B21b = true;
    static bool B22b = true;
    static bool B23b = true;
    static bool B24b = true;

    public GameObject B31;
    public GameObject B32;
    public GameObject B33;
    public GameObject B34;
    static bool B31b = true;
    static bool B32b = true;
    static bool B33b = true;
    static bool B34b = true;

    public GameObject B41;
    public GameObject B42;
    public GameObject B43;
    public GameObject B44;
    static bool B41b = true;
    static bool B42b = true;
    static bool B43b = true;
    static bool B44b = true;

    public GameObject E11a;
    public GameObject E21a;
    public GameObject E22a;
    public GameObject E31a;
    public GameObject E32a;
    public GameObject B11a;
    public GameObject B12a;
    public GameObject B13a;
    public GameObject B14a;
    public GameObject B21a;
    public GameObject B22a;
    public GameObject B23a;
    public GameObject B24a;
    public GameObject B31a;
    public GameObject B32a;
    public GameObject B33a;
    public GameObject B34a;
    public GameObject B41a;
    public GameObject B42a;
    public GameObject B43a;
    public GameObject B44a;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mouse");
            CastRay();
        }

        UpdateHits();


    }


    void CastRay()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current);

        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        if (results.Count >= 0)
        {
            if (results[0].gameObject.layer == LayerMask.NameToLayer("hits"))
            {
                if (results.Count >= 4)
                {
                    switch (results[results.Count - 4].gameObject.name)
                    {
                        case "E1 1":
                            if (E11b == true)
                            {
                                E11b = false;
                            }
                            else
                            {
                                E11b = true;
                            }

                            break;
                        case "E2 1":
                            if (E21b == true)
                            {
                                E21b = false;
                            }
                            else
                            {
                                E21b = true;
                            }

                            break;
                        case "E2 2":
                            if (E22b == true)
                            {
                                E22b = false;
                            }
                            else
                            {
                                E22b = true;
                            }

                            break;
                        case "E3 1":
                            if (E31b == true)
                            {
                                E31b = false;
                            }
                            else
                            {
                                E31b = true;
                            }

                            break;
                        case "E3 2":
                            if (E32b == true)
                            {
                                E32b = false;
                            }
                            else
                            {
                                E32b = true;
                            }

                            break;
                    }
                }
            }
            switch (results[results.Count - 3].gameObject.name)
            {
                case "B1 1":
                    Debug.Log("here");
                    if (B11b == true)
                    {
                        B11b = false;
                    }
                    else
                    {
                        B11b = true;
                    }

                    break;
                case "B1 2":
                    if (B12b == true)
                    {
                        B12b = false;
                    }
                    else
                    {
                        B12b = true;
                    }

                    break;
                case "B1 3":
                    if (B13b == true)
                    {
                        B13b = false;
                    }
                    else
                    {
                        B13b = true;
                    }

                    break;
                case "B1 4":
                    if (B14b == true)
                    {
                        B14b = false;
                    }
                    else
                    {
                        B14b = true;
                    }

                    break;
                case "B2 1":
                    if (B21b == true)
                    {
                        B21b = false;
                    }
                    else
                    {
                        B21b = true;
                    }

                    break;
                case "B2 2":
                    if (B22b == true)
                    {
                        B22b = false;
                    }
                    else
                    {
                        B22b = true;
                    }

                    break;
                case "B2 3":
                    if (B23b == true)
                    {
                        B23b = false;
                    }
                    else
                    {
                        B23b = true;
                    }

                    break;
                case "B2 4":
                    if (B24b == true)
                    {
                        B24b = false;
                    }
                    else
                    {
                        B24b = true;
                    }

                    break;
                case "B3 1":
                    if (B31b == true)
                    {
                        B31b = false;
                    }
                    else
                    {
                        B31b = true;
                    }

                    break;
                case "B3 2":
                    if (B32b == true)
                    {
                        B32b = false;
                    }
                    else
                    {
                        B32b = true;
                    }

                    break;
                case "B3 3":
                    if (B33b == true)
                    {
                        B33b = false;
                    }
                    else
                    {
                        B33b = true;
                    }

                    break;
                case "B3 4":
                    if (B34b == true)
                    {
                        B34b = false;
                    }
                    else
                    {
                        B34b = true;
                    }

                    break;
                case "B4 1":
                    if (B41b == true)
                    {
                        B41b = false;
                    }
                    else
                    {
                        B41b = true;
                    }

                    break;
                case "B4 2":
                    if (B42b == true)
                    {
                        B42b = false;
                    }
                    else
                    {
                        B42b = true;
                    }

                    break;
                case "B4 3":
                    if (B43b == true)
                    {
                        B43b = false;
                    }
                    else
                    {
                        B43b = true;
                    }

                    break;
                case "B4 4":
                    if (B44b == true)
                    {
                        B44b = false;
                    }
                    else
                    {
                        B44b = true;
                    }

                    break;
            }
        }
    }



void UpdateHits()
    {
        if (E11b == true) { E11a.SetActive(true); } else { E11a.SetActive(false); }
        if (E21b == true) { E21a.SetActive(true); } else { E21a.SetActive(false); }
        if (E22b == true) { E22a.SetActive(true); } else { E22a.SetActive(false); }
        if (E31b == true) { E31a.SetActive(true); } else { E31a.SetActive(false); }
        if (E32b == true) { E32a.SetActive(true); } else { E32a.SetActive(false); }
        if (B11b == true) { B11a.SetActive(true); } else { B11a.SetActive(false); }
        if (B12b == true) { B12a.SetActive(true); } else { B12a.SetActive(false); }
        if (B13b == true) { B13a.SetActive(true); } else { B13a.SetActive(false); }
        if (B14b == true) { B14a.SetActive(true); } else { B14a.SetActive(false); }
        if (B21b == true) { B21a.SetActive(true); } else { B21a.SetActive(false); }
        if (B22b == true) { B22a.SetActive(true); } else { B22a.SetActive(false); }
        if (B23b == true) { B23a.SetActive(true); } else { B23a.SetActive(false); }
        if (B24b == true) { B24a.SetActive(true); } else { B24a.SetActive(false); }
        if (B31b == true) { B31a.SetActive(true); } else { B31a.SetActive(false); }
        if (B32b == true) { B32a.SetActive(true); } else { B32a.SetActive(false); }
        if (B33b == true) { B33a.SetActive(true); } else { B33a.SetActive(false); }
        if (B34b == true) { B34a.SetActive(true); } else { B34a.SetActive(false); }
        if (B41b == true) { B41a.SetActive(true); } else { B41a.SetActive(false); }
        if (B42b == true) { B42a.SetActive(true); } else { B42a.SetActive(false); }
        if (B43b == true) { B43a.SetActive(true); } else { B43a.SetActive(false); }
        if (B44b == true) { B44a.SetActive(true); } else { B44a.SetActive(false); }
    }
    void OnDisable()
    {
        PlayerPrefs.SetInt("E11b", E11b ? 1 : 0);
        PlayerPrefs.SetInt("E21b", E21b ? 1 : 0);
        PlayerPrefs.SetInt("E22b", E22b ? 1 : 0);
        PlayerPrefs.SetInt("E31b", E31b ? 1 : 0);
        PlayerPrefs.SetInt("E32b", E32b ? 1 : 0);
        PlayerPrefs.SetInt("B11b", B11b ? 1 : 0);
        PlayerPrefs.SetInt("B12b", B12b ? 1 : 0);
        PlayerPrefs.SetInt("B13b", B13b ? 1 : 0);
        PlayerPrefs.SetInt("B14b", B14b ? 1 : 0);
        PlayerPrefs.SetInt("B21b", B21b ? 1 : 0);
        PlayerPrefs.SetInt("B22b", B22b ? 1 : 0);
        PlayerPrefs.SetInt("B23b", B23b ? 1 : 0);
        PlayerPrefs.SetInt("B24b", B24b ? 1 : 0);
        PlayerPrefs.SetInt("B31b", B31b ? 1 : 0);
        PlayerPrefs.SetInt("B32b", B32b ? 1 : 0);
        PlayerPrefs.SetInt("B33b", B33b ? 1 : 0);
        PlayerPrefs.SetInt("B34b", B34b ? 1 : 0);
        PlayerPrefs.SetInt("B41b", B41b ? 1 : 0);
        PlayerPrefs.SetInt("B42b", B42b ? 1 : 0);
        PlayerPrefs.SetInt("B43b", B43b ? 1 : 0);
        PlayerPrefs.SetInt("B44b", B44b ? 1 : 0);
    }
}
