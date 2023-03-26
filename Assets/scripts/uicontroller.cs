using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uicontroller : MonoBehaviour
{
    public Material carbodymaterial;
    public GameObject colors3dui;
    bool uistatus = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void redcolor()
    {
        carbodymaterial.color = new Color(0.4622642f, 0.000000f, 0.000000f, 1);
        Debug.Log("Red btn pressed");
    }

    public void bluecolor()
    {
        Debug.Log("Blue btn pressed");

        carbodymaterial.color = new Color(0.009504453f, 0.000000f, 0.4627451f, 1);
    }

    public void whitecolor()
    {
        Debug.Log("White btn pressed");

        carbodymaterial.color = new Color(0.6981132f, 0.6981132f, 0.6981132f, 1);
    }

    public void Toggleui()
    {
        if (uistatus == true)
        {
            colors3dui.SetActive(false);
            uistatus = false;
        }

        if (uistatus == false)
        {
            colors3dui.SetActive(true);
            uistatus = true;
        }
    }
}
