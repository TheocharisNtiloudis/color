using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public Image button;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {

        color.a = 255;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        button.GetComponent<Image>();
        button.color = color;
    }
}
