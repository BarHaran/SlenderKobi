using UnityEngine;
using System.Collections;

public class Staticimg : MonoBehaviour {

    public Transform player;
    public float healthbegin;
    private float health;
    public int decspeed;
    public Transform slender;
    public float Distance;
    private float distance;
    public AudioClip staticsound;
    public AudioSource source;
    public GameObject staticimg;
    public Light flash;
    // Use this for initialization

    void Start () {
        health = healthbegin;
        staticimg.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        float distancex = (float)Mathf.Pow(player.position.x - slender.position.x,2);
        float distancez = (float)Mathf.Pow(player.position.z - slender.position.z, 2);
        distance = (float)Mathf.Sqrt(distancex + distancez);
        distance = (float)Mathf.Abs(distance);
        if (distance <= Distance)
        {
            health -= decspeed * distance * 1f;
            source.PlayOneShot(staticsound);
            staticimg.SetActive(true);
            flash.enabled = false;
        }
        else
        {
            if (health<=100)
            {
                health += 5f;
            }
            staticimg.SetActive(false);
        }
	}
}
