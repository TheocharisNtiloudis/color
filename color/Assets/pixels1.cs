using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pixels1 : MonoBehaviour
{
    public Color newcolor;
    public Image button;
    public Sprite none;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Click()
    {
        Debug.Log ("first"+newcolor);
        button.GetComponent<Image>();
        button.sprite = none;
        button.color = newcolor;
        Debug.Log ("second"+newcolor);
    }

    public void Red()
    {
        newcolor.a = 255;
        newcolor.r = 255;
        newcolor.g = 0;
        newcolor.b = 0;
        Debug.Log ("Color = red! =>"+newcolor);
    }

    public void Green()
    {
        newcolor.a = 255;
        newcolor.g = 255;
        newcolor.r = 0;
        newcolor.b = 0;
        Debug.Log ("Color = green! =>"+newcolor);
    }
}

