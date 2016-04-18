using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Menu : MonoBehaviour {
    public GameObject Lvauswahl;
    public GameObject Playbutton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LvAuswahl()
    {
        Lvauswahl.SetActive(true);
        Playbutton.SetActive(false);
    }
    public void Starten()
    {

        Application.LoadLevel(int.Parse(EventSystem.current.currentSelectedGameObject.name) *2);
    }
    public void Start1()
    {
        Application.LoadLevel(1);
    }
    public void Start2()
    {
        Application.LoadLevel(4);
    }
    public void Start3()
    {
        Application.LoadLevel(7);
    }
    public void Start4()
    {
        Application.LoadLevel(10);
    }
    public void Start5()
    {
        Application.LoadLevel(13);
    }
}
