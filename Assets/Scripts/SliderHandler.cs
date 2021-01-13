using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHandler : MonoBehaviour
{
    public Slider rSlider;
    public Slider gSlider;
    public Slider bSlider;

    public Text rText;
    public Text gText;
    public Text bText; 

    // Start is called before the first frame update
    void Start()
    {
        rText.text = "" + PlayerPrefs.GetFloat("red");
        gText.text = "" + PlayerPrefs.GetFloat("green");
        bText.text = "" + PlayerPrefs.GetFloat("blue");

        rSlider.value = PlayerPrefs.GetFloat("red");
        gSlider.value = PlayerPrefs.GetFloat("green");
        bSlider.value = PlayerPrefs.GetFloat("blue");
    }

    public void SetSliderValue(float slider)
    {
        
    }
}
