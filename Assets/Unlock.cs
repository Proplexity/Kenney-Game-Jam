using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    [SerializeField] string lockType;
    [SerializeField] CheckColor CC;

    public void UnlockLock()
    {
        if (lockType == CC.objectColor[0])
        {
            gameObject.SetActive(false);
        }
    }
}
