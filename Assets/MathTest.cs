using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float a = 2.0f;
        float b = Mathf.Sqrt(a);

        Debug.Log($"Squareroot of {a} is {b}");

        float c = Mathf.Sin(Mathf.Deg2Rad * 45.0f);
        c = 2.0f * c;

        Debug.Log($"Squareroot of 2 is {c}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
