using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit {

	void Start ()
    {
        Init();
	}

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            move.speed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))

        {
            move.speed /= 2;
        }

        float X = Input.GetAxis("Horizontal");
        float Y = Input.GetAxis("Vertical");

        if (X != 0 || Y != 0)
        {
            float speed = move.speed;

            transform.Translate(X * speed * Time.deltaTime,
                                Y * speed * Time.deltaTime,
                                0, Space.World);
        }
    }
}
