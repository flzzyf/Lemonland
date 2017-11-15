using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit {

    public GameObject flashLight;

    public float rotSpeed = 3f;

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

        //鼠标世界点
        Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 dir = new Vector3(mousePoint.x, mousePoint.y, 0) - transform.position;

        //旋转
        if (dir != Vector3.zero)
        {
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);

            transform.rotation = Quaternion.Lerp(transform.rotation, rot, rotSpeed * Time.deltaTime);

        }
    }
}
