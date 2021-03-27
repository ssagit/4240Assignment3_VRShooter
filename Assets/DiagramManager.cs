using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiagramManager : MonoBehaviour
{
    public Image img1;
    public Image img2;
    public Image img3;
    int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        img2.enabled = false;
        img3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Oculus_CrossPlatform_Button2") > 0 || Input.GetKeyDown(KeyCode.A))
        {
            num = num + 1;
            SwapScreen(num);
        }
    }

    void SwapScreen(int num)
    {
        if (num % 3 == 0)
            {
                img1.enabled = false;
                img2.enabled = true;
            }
            else if (num % 3 == 1)
            {
                img2.enabled = false;
                img3.enabled = true;
            }
            else
            {
                img3.enabled = false;
                img1.enabled = true;
            }
    }
}
