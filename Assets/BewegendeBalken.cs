using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class BewegendeBalken : MonoBehaviour {
    public Vector3 Punkt1;
    public Vector3 Punkt2;
    Transform sprite;
    Transform sprite2;
	void Update () {

        if (sprite == null)
        {
            sprite = Instantiate(GameObject.Find("Punkte"), Punkt1, Quaternion.identity) as Transform;
        }
        if (sprite2 == null)
        {
            sprite2 = Instantiate(GameObject.Find("Punkte"), Punkt2, Quaternion.identity) as Transform;
        }
        if(sprite != null)
        {
            sprite.transform.position = Punkt1;
            sprite2.transform.position = Punkt2;
        }

    }
}
