using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsHandler : MonoBehaviour
{
    public Slider rSlider;
    public Slider gSlider;
    public Slider bSlider;

    public Text rText;
    public Text gText;
    public Text bText;

    public Button resetButton;
    public Button backButton;

	public Image image;

    public Image fadeImg;
    public FadeHandler fadeHandler;

    private bool resetStatsButton = false;

    void Update()
    {
        SetSliderValue();
        image.color = new Color(rSlider.value, gSlider.value, bSlider.value);
    }

    void Awake()
    {
        rSlider.value = PlayerPrefs.GetFloat("red");
        gSlider.value = PlayerPrefs.GetFloat("green");
        bSlider.value = PlayerPrefs.GetFloat("blue");


        resetButton.onClick.AddListener(ResetStats);
        backButton.onClick.AddListener(BackButtonHandler);
    }

    void Start()
    {
        fadeHandler.fadeToNewScene(fadeImg, true, "");
    }

    public void SetSliderValue()
    {
        rText.text = "" + (int)(rSlider.value*100);
        gText.text = "" + (int)(gSlider.value * 100);
        bText.text = "" + (int)(bSlider.value * 100);
    }

    public void BackButtonHandler()
    {
        PlayerPrefs.SetFloat("red", rSlider.value);
        PlayerPrefs.SetFloat("green", gSlider.value);
        PlayerPrefs.SetFloat("blue", bSlider.value);

        fadeHandler.fadeToNewScene(fadeImg, false, "Main Menu");
    }

    public void ResetStats()
    {
        if (!resetStatsButton)
        {
            resetButton.GetComponentInChildren<Text>().text = "Are you sure?";
            resetStatsButton = true;
        }
        else
        {
            PlayerPrefs.SetInt("highscore", 0);
            resetStatsButton = false;
            resetButton.GetComponentInChildren<Text>().text = "Reset Score";
        }
    }
}
