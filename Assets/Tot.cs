using UnityEngine;
using System.Collections;

public class Tot : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "tot")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
