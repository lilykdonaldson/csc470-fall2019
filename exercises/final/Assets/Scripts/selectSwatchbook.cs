using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class selectSwatchbook : MonoBehaviour
{

    public GameObject cover;
    public GameObject swatchbook;
    public Light lt;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    }

    void CastRay()
    {
        //Debug.Log("cast ray");
       //if (Input.GetMouseButtonDown(0))
       //{
            PointerEventData pointerData = new PointerEventData(EventSystem.current);

            pointerData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            if (results.Count > 0)
            {
            if (results[0].gameObject.layer == LayerMask.NameToLayer("UI"))
            {
                if (results[results.Count - 1].gameObject.name == "swatchbook")
                {
                    //Debug.Log("in");
                    cover.SetActive(true);
                    swatchbook.SetActive(false);
                   
                }
                else if (results[results.Count - 1].gameObject.name == "R24")
                {
                    lt.color = new Color32(245, 0, 20, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }
                else if(results[results.Count - 1].gameObject.name == "R57")
                {
                    lt.color = new Color32(180,130,255, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }
                else if (results[results.Count - 1].gameObject.name == "R01")
                {
                    lt.color = new Color32(251, 179, 154, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }
                else if (results[results.Count - 1].gameObject.name == "R80")
                {
                    lt.color = new Color32(3, 171, 255, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }
                else if (results[results.Count - 1].gameObject.name == "R90")
                {
                    lt.color = new Color32(0, 127, 6, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }

                else if (results[results.Count - 1].gameObject.name == "R99")
                {
                    lt.color = new Color32(208, 136, 100, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }

                else if (results[results.Count - 1].gameObject.name == "R11")
                {
                    lt.color = new Color32(255, 210, 27, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }

                else if (results[results.Count - 1].gameObject.name == "R21")
                {
                    lt.color = new Color32(255, 102, 19, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }
                else if (results[results.Count - 1].gameObject.name == "R64")
                {
                    lt.color = new Color32(80, 173, 253, 255);
                    cover.SetActive(false);
                    swatchbook.SetActive(true);
                }
            }
        }
    }
}