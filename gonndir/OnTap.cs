using UnityEngine;
using System.Collections;

public class OnTap : MonoBehaviour {

    public AreaEffector2D ar;
    public int neuzeit;
    int zeit;
    public Camera cam;
	// Use this for initialization
	void Start () {
        ar = gameObject.GetComponent<AreaEffector2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if(ar.isActiveAndEnabled == true)
        {
            zeit -= 1;
            if(zeit <= 0)
            {
                zeit = neuzeit;
                ar.enabled = false;
            }
        }
        if (Input.GetMouseButton(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit != null)
            {
                if(hit.transform.gameObject.tag == gameObject.tag)
                {
                    ar.enabled = true;
                }
            }
        }
	}
}
