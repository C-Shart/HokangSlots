using UnityEngine;
using System.Collections;

public class WhenLeverPulled : MonoBehaviour {

    public bool wheelsAnimationBool;
    public GameObject wheel_1;
    public GameObject wheel_2;
    public GameObject wheel_3;

	// Use this for initialization
	void Start() 
    {
        wheel_1 = GameObject.Find("Wheel 1 (Rect Xform)");
        wheel_2 = GameObject.Find("Wheel 2 (Rect Xform)");
        wheel_3 = GameObject.Find("Wheel 3 (Rect Xform)");


    }
	
	// Update is called once per frame
	void Update()
    {
        if (wheelsAnimationBool == true)
        {
            animation.Play("Wheel1_testanim");
            animation.Play("Wheel2_testanim");
            animation.Play("Wheel3_testanim");
        }
    }
}
