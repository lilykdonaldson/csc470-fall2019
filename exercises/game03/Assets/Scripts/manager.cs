using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manager : MonoBehaviour
{

    public Text candyText;
    public GameObject Acute;
    public GameObject Obtuse;
    public GameObject Right;
    public GameObject Iso;
    public GameObject Equal;
    public GameObject Scalene;
    public GameObject Bubble;
    public GameObject talking;
    public GameObject doneTalking;
    bool Waiting = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(candyTalks());
        SceneManager.LoadScene("candyPick");
    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator candyTalks()
    {
        while (Waiting)
        {
            yield return new WaitForSeconds(2);
            candyText.text = "Today, we're learning about triangles.";

            yield return new WaitForSeconds(3);
            candyText.text = "We sort triangles based on ANGLE and SIDE.";

            yield return new WaitForSeconds(3);
            candyText.text = "There are three types of triangles when sorting by ANGLE.";

            yield return new WaitForSeconds(4);
            candyText.text = "ACUTE.";
            allFalse();
            Acute.SetActive(true);

            yield return new WaitForSeconds(4);
            candyText.text = "OBTUSE.";
            allFalse();
            Obtuse.SetActive(true);

            yield return new WaitForSeconds(4);
            candyText.text = "And RIGHT.";
            allFalse();
            Right.SetActive(true);

            yield return new WaitForSeconds(3);
            allFalse();
            candyText.text = "There are three types of triangles when sorting by SIDE, too.";
            allFalse();

            yield return new WaitForSeconds(4);
            candyText.text = "EQUILATERAL.";
            allFalse();
            Equal.SetActive(true);

            yield return new WaitForSeconds(4);
            candyText.text = "ISOSCELES.";
            allFalse();
            Iso.SetActive(true);

            yield return new WaitForSeconds(4);
            candyText.text = "And SCALENE.";
            allFalse();
            Scalene.SetActive(true);

            yield return new WaitForSeconds(3);
            allFalse();
            candyText.text = "Can you help me sort these candy corn triangles";
            yield return new WaitForSeconds(2);
            candyText.text = "by ANGLE and SIDE?";

            yield return new WaitForSeconds(4);

            candyText.text = "";
            Bubble.SetActive(false);
            talking.SetActive(false);
            doneTalking.SetActive(true);





            Waiting = false;

        }
    }
    void allFalse()
    {
        Acute.SetActive(false);
        Obtuse.SetActive(false);
        Right.SetActive(false);
        Iso.SetActive(false);
        Scalene.SetActive(false);
        Equal.SetActive(false);
    }
}