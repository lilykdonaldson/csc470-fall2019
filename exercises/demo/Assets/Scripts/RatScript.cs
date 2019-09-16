using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatScript : MonoBehaviour
{
    float speed = 2f;
    int haveRotate = 0;

    //Set these references in the Unity inspector
    //NOTE: You need to import the Unity UI package in order to reference the UI objects
    //        See above where we say "using Unity.UI;"
    public GameObject cheeseObj;
    public Text gameLabelText;

    private void Start()
    {
        gameLabelText.enabled=false;
    }
    void Update()
    {
        if (Time.fixedTime < 3.67)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else if (Time.fixedTime > 3.67 && haveRotate == 0)
        {
            transform.Rotate(0, 90, 0);
            haveRotate += 1;
        }
        else if (Time.fixedTime > 3.67 && 5.6 > Time.fixedTime && haveRotate == 1)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else if (5.6 < Time.fixedTime && haveRotate == 1)
        {
            transform.Rotate(0, 90, 0);
            haveRotate += 1;
        }
        else if (5.6 < Time.fixedTime && Time.fixedTime < 7.5 && haveRotate == 2)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else if (Time.fixedTime > 7.5 && haveRotate == 2)
        {
            transform.Rotate(0, -90, 0);
            haveRotate += 1;
        }
        else if (Time.fixedTime > 7.5 && 9.6 > Time.fixedTime && haveRotate == 3)
        {
            transform.position = transform.position + (transform.forward * speed * Time.deltaTime);
        }
        else if (Time.fixedTime > 9.6 && haveRotate == 3)
        {
            transform.Rotate(0, 90, 0);
            haveRotate += 1;
        }
        else if (Time.fixedTime > 9.4 && 10.5 > Time.fixedTime && haveRotate == 4)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else if (Time.fixedTime >10.5 && haveRotate == 4)
        {
            transform.Rotate(0, 90, 0);
            haveRotate += 1;
        }
        else if (Time.fixedTime > 10.5 && 12.5 > Time.fixedTime && haveRotate == 5)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else if (Time.fixedTime > 12.5 && haveRotate == 5)
        {
            transform.Rotate(0, -90, 0);
            haveRotate += 1;
        }
        else if (Time.fixedTime > 12.5 && 13.4 > Time.fixedTime && haveRotate == 6)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else if (13.4 < Time.fixedTime && haveRotate == 6)
        {
            transform.Rotate(0, -90, 0);
            haveRotate += 1;
        }
        else if (Time.fixedTime > 13.4 && 15.2 > Time.fixedTime && haveRotate == 7)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else if (15.2 < Time.fixedTime && haveRotate == 7)
        {
            transform.Rotate(0, -90, 0);
            haveRotate += 1;
        }
        else if (Time.fixedTime > 15.2 && 15.8 > Time.fixedTime && haveRotate == 8)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        else if (15.8 < Time.fixedTime && haveRotate == 8)
        {
            transform.Rotate(0, 90, 0);
            haveRotate += 1;
        }
        else if (15.8 < Time.fixedTime && haveRotate == 9)
        {
            Destroy(cheeseObj);
            gameLabelText.enabled = true;
        }

    }
}