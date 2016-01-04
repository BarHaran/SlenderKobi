using UnityEngine;
using System.Collections;

public class Staticimg : MonoBehaviour {

    public Transform player;
    public float healthbegin;
    public int decspeed;
    public Transform slender;
    private float distance;
    public AudioClip staticsound;
    private AudioSource source;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float distancex = Mathf.Pow(player.position.x - slender.position.x,2);
        float distancez = Mathf.Pow(player.position.z - slender.position.z, 2);
        distance = Mathf.Sqrt(distancex + distancez);
        if (distance<=10)
        {
            healthbegin -= decspeed * distance * 1f;
            source.PlayOneShot(staticsound, distance);
        }
	}
}
