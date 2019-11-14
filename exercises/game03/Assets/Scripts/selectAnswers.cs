using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectAnswers : MonoBehaviour
{
    public GameObject right;
    public GameObject acute;
    public GameObject obtuse;
    public GameObject iso;
    public GameObject equal;
    public GameObject scalene;
    public GameObject correct;
    public GameObject wrong;
    public GameObject rightshape;
    public GameObject acuteshape;
    public GameObject obtuseshape;
    public GameObject isoshape;
    public GameObject equalshape;
    public GameObject scaleneshape;
    string objectSelected;
    string[] order = { "obtuse", "right", "acute", "iso", "scalene", "equal"};
    int whereAmI = 0;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }

    }

    void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (hit)
        {
            if (hit.collider.gameObject.name == "obtuse")
            {
                if(whereAmI == 0)
                {
                    //correct
                    StartCoroutine(Correct());
                    obtuseshape.SetActive(false);
                    rightshape.SetActive(true);
                    whereAmI++;
                }
                else
                {
                    //wrong
                    StartCoroutine(Wrong());
                }
            }
            else if (hit.collider.gameObject.name == "right")
            {
                if (whereAmI == 1)
                {
                    //correct
                    StartCoroutine(Correct());
                    rightshape.SetActive(false);
                    acuteshape.SetActive(true);
                    whereAmI++;
                }
                else
                {
                    //wrong
                    StartCoroutine(Wrong());
                }
            }
            else if (hit.collider.gameObject.name == "acute")
            {
                if (whereAmI == 2)
                {
                    //correct
                    StartCoroutine(Correct());
                    acuteshape.SetActive(false);
                    isoshape.SetActive(true);
                    whereAmI++; 
                    right.SetActive(false);
                    acute.SetActive(false);
                    obtuse.SetActive(false);
                    iso.SetActive(true);
                    scalene.SetActive(true);
                    equal.SetActive(true);

                }
                else
                {
                    //wrong
                    StartCoroutine(Wrong());
                }
            }
            else if (hit.collider.gameObject.name == "iso")
            {
                if (whereAmI == 3)
                {
                    //correct
                    StartCoroutine(Correct());
                    isoshape.SetActive(false);
                    scaleneshape.SetActive(true);
                    whereAmI++;
                }
                else
                {
                    //wrong
                    StartCoroutine(Wrong());
                }
            }
            else if (hit.collider.gameObject.name == "scalene")
            {
                if (whereAmI == 4)
                {
                    //correct
                    StartCoroutine(Correct());
                    scaleneshape.SetActive(false);
                    equalshape.SetActive(true);
                    whereAmI++;
                }
                else
                {
                    //wrong
                    StartCoroutine(Wrong());
                }
            }
            else if (hit.collider.gameObject.name == "equal")
            {
                if (whereAmI == 5)
                {
                    //correct
                    StartCoroutine(Correct());
                    SceneManager.LoadScene("goodJob");

                }
                else
                {
                    //wrong
                    StartCoroutine(Wrong());
                }
            }
        }
    }
    IEnumerator Correct()
    {
        bool waiting = true;
        while (waiting)
        {
            correct.SetActive(true);
            yield return new WaitForSeconds(1.2f);
            correct.SetActive(false);
            waiting = false;

        }
    }
    IEnumerator Wrong()
    {
        bool waiting = true;
        while (waiting)
        {
            wrong.SetActive(true);
            yield return new WaitForSeconds(1.2f);
            wrong.SetActive(false);
            waiting = false;
        }
    }
}

