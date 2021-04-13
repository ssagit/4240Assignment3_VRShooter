using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private int keyDown = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Two) || Input.GetKey(KeyCode.B))
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
                OpenMenu();
    }
    
    // Update is called once per frame
    void OpenMenu()
    {
        transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
        Debug.Log("Opened Menu");
    }

    public void CloseMenu()
    {
        transform.localScale = new Vector3(0, 0, 0);
        Debug.Log("Closed Menu");
    }

    public void ResetComponents()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Resetting Scene");
    }
}
