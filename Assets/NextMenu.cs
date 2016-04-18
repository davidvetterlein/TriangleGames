using UnityEngine;
using UnityEngine.Advertisements;

public class NextMenu : MonoBehaviour
{
    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}