using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Start is called before the first frame update

    public Material skybox;
    public Material original;
    public GameObject clouds;
    private bool dayTime;
    void Start()
    {
        dayTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        bool change = Input.GetKeyUp(KeyCode.M);
        if (change)
        {
            if (dayTime)
            {
                dayTime = false;
                RenderSettings.skybox = skybox;
                clouds.SetActive(false);
            }
            else
            {
                dayTime = true;
                RenderSettings.skybox = original;
                clouds.SetActive(true);
            }
        }
    }
}
