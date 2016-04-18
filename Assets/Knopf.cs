using UnityEngine;
using System.Collections;

public class Knopf : MonoBehaviour {
    public Camera cam;
    public GameObject Lummel;
    public GameObject andererLummel;
    public int NeuZeit;
    int Zeit;
    bool start;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Zeit > 0 && start == true)
        {
            Zeit -= 1;
        }
        else if(Zeit <= 0 && start == true)
        {
            start = false;
            Lummel.SetActive(!Lummel.activeSelf);
            andererLummel.SetActive(!andererLummel.activeSelf);
        }

        if (Input.touchCount > 0 & start == false)
        {
            Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit.transform.gameObject != null)
            {
                if (hit.transform.position == gameObject.transform.position)
                {
                    start = true;
                    Zeit = NeuZeit;
                    Lummel.SetActive(!Lummel.activeSelf);
                    andererLummel.SetActive(!andererLummel.activeSelf);
                }
            }
        }




        if (Input.GetMouseButton(0) && start == false)
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            if (hit.transform.gameObject != null)
            {
                if (hit.transform.position == gameObject.transform.position)
                {
                    start = true;
                    Zeit = NeuZeit;
                    Lummel.SetActive(!Lummel.activeSelf);
                    andererLummel.SetActive(!andererLummel.activeSelf);
                }
            }
        }
    }
}
