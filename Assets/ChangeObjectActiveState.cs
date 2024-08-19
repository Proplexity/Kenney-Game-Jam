using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObjectActiveState : MonoBehaviour
{
    public void ChangeObjectActiveStateTrue(GameObject o)
    {
        o.SetActive(true);
    }
    public void ChangeObjectActiveStateFalse(GameObject o)
    {
        o.SetActive(false);
    }
}
