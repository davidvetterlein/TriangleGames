using UnityEngine;
using System.Collections;

public class Bewegend : MonoBehaviour {
    public float speed;
    public Transform P1;
    public Transform P2;
    bool z1 = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (z1 == true)
        {
            gameObject.transform.position = Vector2.MoveTowards(transform.position, P1.position, speed);
        }
        else if (z1 == false)
        {
            gameObject.transform.position = Vector2.MoveTowards(transform.position, P2.position, speed);
        }
        if(transform.position.x == P1.position.x && transform.position.y == P1.position.y)
        {
            z1 = false;
        }
        if(transform.position.x == P2.position.x && transform.position.y == P2.position.y)
        {
            z1 = true;
        }
	}
}
