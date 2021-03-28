using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class DiagramManager : MonoBehaviour
{ 
    public Image img1;
    public Image img2;
    public Image img3;
    private int num = 0;
    private int keyDown = 0;

    // Start is called before the first frame update
    void Start()
    {
        img2.enabled = false;
        img3.enabled = false;
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One) || Input.GetKey(KeyCode.A))
        {
            if (keyDown < 0)
                keyDown = 0;
            keyDown++;
        }
        else
        {
            if (keyDown > 0)
                keyDown = 0;
            keyDown--;
        }
 
        if (keyDown == 1)
            num++;
            SwapScreen(num);
    }

    void SwapScreen(int num)
    {
        if (num % 3 == 0)
        {
            img1.enabled = false;
            img2.enabled = true;
            Debug.Log(num);
        }
        else if (num % 3 == 1)
        {
            img2.enabled = false;
            img3.enabled = true;
            Debug.Log(num);
        }
        else
        {
            img3.enabled = false;
            img1.enabled = true;
            Debug.Log(num);
        }
    }
}
