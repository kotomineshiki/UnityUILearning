using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterface : MonoBehaviour {
    public float bloodValue = 0.0f;
    private float ResultValue;
    private Rect rctBloodBar;
    private Rect rctUpButton;
    private Rect rctDownButton;
    private bool onoff;

    // Use this for initialization
    void Start () {
        rctBloodBar = new Rect(20, 20, 200, 20);
        //加血-按钮  
        rctUpButton = new Rect(20, 50, 80, 20);
        //减血-按钮  
        rctDownButton = new Rect(150, 50, 80, 20);
        ResultValue = bloodValue;

    }

    // Update is called once per frame
    void OnGUI()
    {
        if (GUI.Button(rctUpButton, "我方加血"))
        {
            ResultValue += 0.1f;
        }
        if (GUI.Button(rctDownButton, "我方减血"))
        {
            ResultValue -= 0.1f;
        }
        if (ResultValue > 1.0f)
        {
            ResultValue = 1.0f;
        }
        if (ResultValue < 0.0f)
        {
            ResultValue = 0.0f;
        }
        //插值计算HP值

        bloodValue = Mathf.Lerp(bloodValue, ResultValue, 0.05f);

        GUI.HorizontalScrollbar(rctBloodBar, 0.0f, bloodValue, 0.0f, 1.0f);
    }

}
