using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class addLight : MonoBehaviour
{
    public GameObject E11;
    public GameObject E12;
    public GameObject E13;

    public GameObject E21;
    public GameObject E22;
    public GameObject E23;

    public GameObject E31;
    public GameObject E32;
    public GameObject E33;

    public GameObject B11;
    public GameObject B12;
    public GameObject B13;
    public GameObject B14;

    public GameObject B21;
    public GameObject B22;
    public GameObject B23;
    public GameObject B24;

    public GameObject B31;
    public GameObject B32;
    public GameObject B33;
    public GameObject B34;

    public GameObject B41;
    public GameObject B42;
    public GameObject B43;
    public GameObject B44;

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
    }


    void CastRay()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current);

        pointerData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        if (results.Count > 0)
        {
            if (results[0].gameObject.layer == LayerMask.NameToLayer("hits"))
            {
                Debug.Log(results[results.Count - 1].gameObject.name);

                if (results[results.Count - 1].gameObject.name == "B1 1")
                {


                }
                else if (results[results.Count - 1].gameObject.name == "R24")
                {

                }
                // }
            }
        }
    }
}