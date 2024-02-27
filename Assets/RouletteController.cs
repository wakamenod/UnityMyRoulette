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
            this.rotateSpeed = 30;
        }

        transform.Rotate(0, 0, this.rotateSpeed);

        this.rotateSpeed *= 0.96f;
    }
}
