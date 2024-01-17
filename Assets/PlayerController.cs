using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private void Start()
    {
    }

    private void FixedUpdate()
    {

    }

    private void Update()
    {
        
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector2 = movementValue.Get<Vector2>();

        Vector3 movementVector3;

        movementVector3.x = movementVector2.x;
        movementVector3.y = 0;
        movementVector3.z = movementVector2.y;


        gameObject.transform.Translate(movementVector3);

        Debug.Log("Movement Value:" + movementVector2);
    }

}
