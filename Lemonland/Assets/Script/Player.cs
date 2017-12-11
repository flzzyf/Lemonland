using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit {

    public Transform flashLight;

    public float rotSpeed = 3f;

    public GameObject wildFire;

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
                                0,
                                Y * speed * Time.deltaTime, Space.World);
        }

        //鼠标世界点
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(hit.collider.gameObject.name);

        }

        Vector3 mousePoint = hit.point;

        Vector3 dir = new Vector3(mousePoint.x, mousePoint.y, mousePoint.z) - transform.position;

        dir.Normalize();
        //dir.y = 1;


        //旋转
        if (dir != Vector3.zero)
        {
            //float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            //Quaternion rot = Quaternion.AngleAxis(angle, Vector3.forward);

            Quaternion rot = Quaternion.LookRotation(dir);

            flashLight.rotation = Quaternion.Lerp(flashLight.rotation, rot, rotSpeed * Time.deltaTime);

        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(wildFire, transform.position + new Vector3(0, 1, 0), transform.rotation);

            Rigidbody rb = go.GetComponent<Rigidbody>();

            rb.AddForce(dir * 300f);
        }
    }
}
