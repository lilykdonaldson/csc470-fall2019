using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class select : MonoBehaviour
{
    public GameObject witch;
    public GameObject candycorn;
    public GameObject pumpkin;
    public GameObject ghost;
    public GameObject witchH;
    public GameObject candycornH;
    public GameObject pumpkinH;
    public GameObject ghostH;
    public GameObject holdText;
    string objectSelected;
    //public Button start;


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
        if (Input.GetKeyUp("return") && holdText.activeSelf)
        {
            if (objectSelected == "witch")
            {
                SceneManager.LoadScene("Witch");
            }
            else if (objectSelected == "candycorn")
            {
                SceneManager.LoadScene("CandyCorn");
            }
            else if (objectSelected == "ghost")
            {
                SceneManager.LoadScene("Ghost");
            }
            else if (objectSelected == "pumpkin")
            {
                SceneManager.LoadScene("Pumpkin");
            }

        }
    }

    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (hit)
        {
            if(hit.collider.gameObject.name  == "Witch")
            {
                objectSelected = "witch";
                allFalse();
                witch.SetActive(false);
                witchH.SetActive(true);
            }
            else if (hit.collider.gameObject.name == "CandyCorn")
            {
                objectSelected = "candycorn";
                allFalse();
                candycorn.SetActive(false);
                candycornH.SetActive(true);

            }
            else if (hit.collider.gameObject.name == "Ghost")
            {
                objectSelected = "ghost";
                allFalse();
                ghost.SetActive(false);
                ghostH.SetActive(true);
            }
            else if (hit.collider.gameObject.name == "Pumpkin")
            {
                objectSelected = "pumpkin";
                allFalse();
                pumpkin.SetActive(false);
                pumpkinH.SetActive(true);
            }
        }
    }
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
       // Debug.Log("Mouse is over GameObject.");
        CastRay();
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
       // Debug.Log("Mouse is no longer on GameObject.");
    }
    void allFalse()
    {
        holdText.SetActive(true);
        witch.SetActive(true);
        candycorn.SetActive(true);
        pumpkin.SetActive(true);
        ghost.SetActive(true);
        witchH.SetActive(false);
        candycornH.SetActive(false);
        pumpkinH.SetActive(false);
        ghostH.SetActive(false);
}
}