using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetransform : MonoBehaviour
{
    public float speed;
    public Rigidbody r;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            r.MovePosition(this.transform.position + this.transform.forward * speed);
            //this.transform.position += this.transform.forward * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            r.MovePosition(this.transform.position - this.transform.forward * speed);
            //this.transform.position -= this.transform.forward * speed;
        }
    }
}
