using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.transform.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevel + 1);
            print("ok");
        }
    }
}
