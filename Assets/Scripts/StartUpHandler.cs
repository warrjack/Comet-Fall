using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUpHandler : MonoBehaviour
{

    public FadeHandler fadeHandler;
    public Image fadeImg;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoImageLoad());
    }


    IEnumerator DoImageLoad()
    {
        
        yield return new WaitForSeconds(2);
        fadeHandler.fadeToNewScene(fadeImg, true, "");
    }
}
