using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScreenWipe : MonoBehaviour
{
    [SerializeField] Transform posA, posB;
    [SerializeField] float transSpeed; 

    private void Update()
    {
        
        while (Vector3.Distance(posA.position, posB.position) > 0.01f)
        {
            transform.position = Vector3.Lerp(posA.position, posB.position, Time.deltaTime * transSpeed);
        }
    }
}
