using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;




public class CharacterMove : MonoBehaviour
{
    public float stepSize = 1.0f; // Distance to move in each grid step
    private bool isMoving = false; // Flag to track if character is currently moving

    [SerializeField] AudioSource moveSound;

    void Update()
    {
        if (!isMoving)
        {
            HandleInput();
        }
    }

    void HandleInput()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0f || vertical != 0f)
        {
            Vector3 direction = new Vector3(horizontal, vertical, 0f);
            MoveInGrid(direction);
        }
    }

    void MoveInGrid(Vector3 direction)
    {
        Vector3 newPosition = transform.position + direction * stepSize;

        // Set isMoving to true to prevent further movement until key is released
        isMoving = true;

        // Move the character smoothly to the new position
        StartCoroutine(MoveToPosition(newPosition));
    }

    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        moveSound.Play();
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 10f);
            yield return null;
        }

        transform.position = targetPosition;
        isMoving = false; // Set isMoving to false to allow movement again
    }
}

