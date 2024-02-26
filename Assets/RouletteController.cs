using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotateSpeed = 0;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotateSpeed = 10;
        }

        transform.Rotate(0, 0, this.rotateSpeed);
    }
}
