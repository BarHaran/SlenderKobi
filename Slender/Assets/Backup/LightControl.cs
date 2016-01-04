using UnityEngine;
using System.Collections;

public class LightControl : MonoBehaviour
{

    public Light flash;
    private int off = 0;
    private float time = 1000;
    // Use this for initialization
    void Start()
    {
        flash.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (time >= 950)
            {
                flash.enabled = !flash.enabled;
            }
            time -= 1;
        }
        else
        {
            time = 1000;
        }
        off++;
        if (off == 1000)
        {
            flash.enabled = false;
            off = 0;
        }
    }
}
