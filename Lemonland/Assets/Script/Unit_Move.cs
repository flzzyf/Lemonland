using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Move : MonoBehaviour {

    public float speedInit = 1;
    [HideInInspector]
    public float speed;

    private void Start()
    {
        speed = speedInit;
    }

}
