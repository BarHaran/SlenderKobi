using UnityEngine;
using System.Collections;

public class FlashLight : MonoBehaviour {

    public Light Flashlight;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.F))
        {
            Flashlight.enabled = !Flashlight.enabled;
            System.Threading.Thread.Sleep(50);
        }
	}
}
