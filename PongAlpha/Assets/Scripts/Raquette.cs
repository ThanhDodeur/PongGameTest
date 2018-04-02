using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquette : MonoBehaviour {

    public float movementSpeed;
    public string InputString;

    private void FixedUpdate()
    {
        float verti = Input.GetAxisRaw(InputString);

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verti) * movementSpeed;
    }
}
