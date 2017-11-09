using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildFire : MonoBehaviour {

    public float radius = 3f;

    public float exlpodeForce = 3;

	void Start ()
    {
        Explode();
	}
	
	void Update () {
		
	}

    void Explode()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);

        foreach (Collider2D item in colliders)
        {
            AddExpolsionForce(item.gameObject);
        }
    }

    void AddExpolsionForce(GameObject _target)
    {
        Rigidbody2D rb = _target.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.AddForce((Vector2)(_target.transform.position - transform.position) * exlpodeForce, ForceMode2D.Impulse);
        }
    }
}
