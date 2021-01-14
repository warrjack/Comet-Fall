using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundLogic : MonoBehaviour
{

    private Vector3 newMovement = new Vector3(0, 0.5f, 0);
    void Update()
    {
        transform.position -= newMovement * Time.deltaTime;
    }
}
