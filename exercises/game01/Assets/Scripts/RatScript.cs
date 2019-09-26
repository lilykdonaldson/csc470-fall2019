using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

public class RatScript : MonoBehaviour
{

    //Set these references in the Unity inspector
    //NOTE: You need to import the Unity UI package in order to reference the UI objects
    //        See above where we say "using Unity.UI;"
    public GameObject cheeseObj;
    public Text gameLabelText;
    float speed = 2f;
    public Rigidbody rb;
    public Stopwatch timer = new Stopwatch();
    public Text timeText;
    public Text randomText;
    public Text normdist;
    public Button yourButton;
    public GameObject bagel;
    private void Start()
    {
        bagel = GameObject.Find("Cheese");
        randomText.text = "";
        gameLabelText.enabled=false;
        timer.Start();
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void Update()
    {
        timeText.text = (timer.ElapsedMilliseconds/1000).ToString();
    if (transform.position.y > 0.7f)
        {
            Vector3 temp = new Vector3(0, -0.3f, 0);
            transform.position += temp;
        }
   //Left
    else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotateMe(-360);
        }
    else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        //Right
    else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotateMe(360);
        }
    else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
    //up
   else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rotateMe(0);
        }
   else if (Input.GetKey(KeyCode.UpArrow))
        {
            //rb.AddForce(transform.forward * 10f);
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
    //Down
   else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
                rotateMe(720);


        }
   else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime;
        }
        
        Vector3 dir = (transform.position - bagel.transform.position).normalized;
        normdist.text = "distance to bagel: " + dir.ToString();


    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bagel")
        {
            Destroy(cheeseObj);
            gameLabelText.enabled = true;
        }
    }
    void rotateMe(int inp)
    {
        Vector3 direction = transform.forward;
        direction.y = 0;
        direction.Normalize();
        transform.eulerAngles = Vector3.Lerp(direction, new Vector3(0, inp, 0), Time.deltaTime * 15);
        direction = transform.forward;
        direction.y = 0;
        direction.Normalize();
        transform.eulerAngles = Vector3.Lerp(direction, new Vector3(0, inp, 0), Time.deltaTime * 15);
    }
    void TaskOnClick()
    {
        randomText.text = Random.Range(0, 100).ToString();
        Color randomColor = RandomColor();
        randomText.color = randomColor;
    }
    Color RandomColor()
    {
        return new Color(Random.value, Random.value, Random.value);
    }
}

