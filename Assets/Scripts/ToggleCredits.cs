using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCredits : MonoBehaviour
{
    private GameObject credits;
    bool creditsisActive = false;
    // Start is called before the first frame update
    void Start()
    {
        credits = GameObject.Find("SlateBlank(Clone)");
        credits.SetActive(false);
    }

    public void Toggle()
    {
        creditsisActive = !creditsisActive;
        credits.SetActive(creditsisActive);
    }
}
