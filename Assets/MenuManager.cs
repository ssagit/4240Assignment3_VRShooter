using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Oculus_CrossPlatform_Button2") > 0
            || Input.GetKeyDown(KeyCode.A))
        {
            if (!active) {
                transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
                active = true;
            } else {
                transform.localScale = new Vector3(0, 0, 0);
                active = false;
            }
        }
    }
}
