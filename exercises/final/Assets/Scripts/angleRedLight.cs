using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class angleRedLight : MonoBehaviour
{
    public Slider angleSlider;
    public Slider colorSlider;
    public Light lt;

    //Invoked when a submit button is clicked.
   
    // Use this for initialization
    void Start()
    {
        //colorSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Update is called once per frame
    void Update()
    {
        lt.spotAngle = angleSlider.value;
        Color x = Color.HSVToRGB(colorSlider.value, 1, 1);
        lt.color = x;
    }

}

