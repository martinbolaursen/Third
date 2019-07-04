using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseModules : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var output = Second.Runtime.Echo.Now("This is text.");
        Debug.Log(output);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}