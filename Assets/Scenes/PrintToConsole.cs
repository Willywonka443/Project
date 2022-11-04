using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintToConsole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi, I'm printing to the console.");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,0.001f);
        transform.Translate(0,0.001f,0);
        transform.Translate(0.001f,0,0);
    }
}
