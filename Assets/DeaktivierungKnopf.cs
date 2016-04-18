using UnityEngine;
using System.Collections;

public class DeaktivierungKnopf : MonoBehaviour {

    public GameObject SpielObjekt;
    public GameObject VerdrehtesObjekt;
    public int Zeit;
    public Sprite rot;
    public Sprite grun;
    public bool root;
    bool start;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (root)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = rot;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = grun;
        }
	    if(start == true)
        {
            if(Zeit >= 0)
            {
                Zeit -= 1;
            }
            else
            {
                start = false;
                SpielObjekt.SetActive(!SpielObjekt.activeSelf);
                VerdrehtesObjekt.SetActive(!VerdrehtesObjekt.activeSelf);
            }
        }
	}

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            start = true;
            root = !root;
        }
    }
}
