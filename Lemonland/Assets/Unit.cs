using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public int hpMax = 10;
    int hpInit;
    int hp;

    protected Unit_Move move;

	void Start ()
    {
        Init();
	}

    public void Init()
    {
        hpInit = hpMax;
        hp = hpMax;
        move = GetComponent<Unit_Move>();
    }

}
