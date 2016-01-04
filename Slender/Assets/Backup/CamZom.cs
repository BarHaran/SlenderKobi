using UnityEngine;
using System.Collections;

public class CamZom : MonoBehaviour {

    public Camera cam;

	// Use this for initialization
	void Start () {
        cam.fieldOfView = 60;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Z))
        {
            if (cam.fieldOfView > 10)
            {
                cam.fieldOfView -= 1f;
            }
        }
        else
        {
            if (cam.fieldOfView < 60)
            {
                cam.fieldOfView += 2f;
            }
        }
    }
}
