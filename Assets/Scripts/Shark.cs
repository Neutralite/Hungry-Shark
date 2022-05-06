using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody rb;
    private Vector3 direction;

    public float movementSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1.7)
        {
            transform.position = new Vector3(
                transform.position.x,
                -1.7f,
                transform.position.z
                );
        }

        if (transform.position.y > 5.2)
        {
            transform.position = new Vector3(
                transform.position.x,
                5.2f,
                transform.position.z
                );
        }

        if (transform.position.x < -6.2)
        {
            transform.position = new Vector3(
                -6.2f,
                transform.position.y,
                transform.position.z
                );
        }

        if (transform.position.x > 6.2)
        {
            transform.position = new Vector3(
                6.2f,
                transform.position.y,
                transform.position.z
                );
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * movementSpeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;

            //if (touch.phase == TouchPhase.Moved)
            //{
            //    transform.position = new Vector3(
            //        transform.position.x + touch.deltaPosition.x*speed,
            //        transform.position.y + touch.deltaPosition.y*speed,
            //        transform.position.z
            //        );
            //}



        }
    }

}
