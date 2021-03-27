using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Oculus_CrossPlatform_Button4") > 0 || Input.GetKeyDown(KeyCode.B))
        {
            transform.localScale = new Vector3(0.005f, 0.005f, 0.005f);
        }
    }

    public void CloseMenu()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    public void ResetComponents()
    {
        SceneManager.LoadScene(1);
    }
}
