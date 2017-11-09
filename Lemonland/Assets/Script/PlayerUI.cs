using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

    public Player player;

    public Slider slider;

    void Start () {
		
	}
	
	void Update ()
    {
        slider.value = player.hp / player.hpMax;

    }
}
