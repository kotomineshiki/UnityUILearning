using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UGUI : MonoBehaviour {
    public RectTransform bloodcanvas;
    public Slider Enemyblood;
    public Camera theCamera;
    public float resultBlood = 0f;
    void Start () {
        resultBlood = Enemyblood.value;
	}
	
	// Update is called once per frame
	void Update () {
        bloodcanvas.rotation = theCamera.transform.rotation;
	}
    private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 30, 80, 20), "敌人加血"))
        {
            
            resultBlood += 0.1f;
        }
        if (GUI.Button(new Rect(150, 30, 80, 20), "敌人减血"))
        {
            resultBlood -= 0.1f;
        }
        Enemyblood.value = Mathf.Lerp(Enemyblood.value, resultBlood, 0.05f);
    }
}
