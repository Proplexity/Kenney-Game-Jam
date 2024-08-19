using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColor : MonoBehaviour
{

    
    public string[] objectColor = new string [10];
    public int index = 0;
    public bool touchingColor = false;

    [SerializeField] float bufferAmount;

    [Header("Ray Info")]
    RaycastHit2D hitRight;
    RaycastHit2D hitLeft;
    RaycastHit2D hitUp;
    RaycastHit2D hitDown;

    public bool callCastUp = true;
    public bool callCastDown = true;
    public bool callCastLeft = true;
    public bool callCastRight = true;

    





    private void Update()
    {
        
            hitRight = Physics2D.Raycast(transform.position, Vector2.right, bufferAmount);
        
        if (callCastLeft == true)
        {
            hitLeft = Physics2D.Raycast(transform.position, Vector2.left, bufferAmount);
        }
        if (callCastUp == true)
        {
            hitUp = Physics2D.Raycast(transform.position, Vector2.up, bufferAmount);
        }
        if (callCastDown == true)
        {
            hitDown = Physics2D.Raycast(transform.position, Vector2.down, bufferAmount);
        }


        



        if (hitUp.collider != null && hitUp.collider != this.gameObject.GetComponent<Collider2D>() && callCastUp == true && hitUp.collider.tag != "Wall")
            if (hitUp.collider.name != "Player")
            {
                hitUp.collider.gameObject.transform.parent = transform;
                index += 1;
                objectColor[index] = hitUp.collider.name;
                callCastUp = false;

                touchingColor = true;
            }
        if (hitRight.collider != null && hitRight.collider != this.gameObject.GetComponent<Collider2D>() && callCastRight == true && hitRight.collider.tag != "Wall")
            if (hitRight.collider.name != "Player")
            {
                hitRight.collider.gameObject.transform.parent = transform;
                index += 1;
                objectColor[index] = hitRight.collider.name;
                callCastRight = false;
                
                touchingColor = true;
            }
        if (hitLeft.collider != null && hitLeft.collider != this.gameObject.GetComponent<Collider2D>() && callCastLeft == true && hitLeft.collider.tag != "Wall")
            if (hitLeft.collider.name != "Player")
            {
                hitLeft.collider.gameObject.transform.parent = transform;
                index += 1;
                objectColor[index] = hitLeft.collider.name;
                callCastLeft = false;
            
                touchingColor = true;
            }
        if (hitDown.collider != null && hitDown.collider != this.gameObject.GetComponent<Collider2D>() && callCastDown == true && hitDown.collider.tag != "Wall")
            if (hitDown.collider.name != "Player")
            {
                hitDown.collider.gameObject.transform.parent = transform;
                index += 1;
                objectColor[index] = hitDown.collider.name;
                callCastDown = false;
             
                touchingColor = true;
            }


    }
}
