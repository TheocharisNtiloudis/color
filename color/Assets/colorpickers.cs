using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorpickers : MonoBehaviour
{
    public Color newcolor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Red()
    {
        newcolor.a = 255;
        newcolor.r = 255;
        newcolor.g = 0;
        newcolor.b = 0;
    }

    public void Green()
    {
        newcolor.a = 255;
        newcolor.g = 255;
        newcolor.r = 0;
        newcolor.b = 0;
    }
}
