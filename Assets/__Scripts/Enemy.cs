using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [Header("Set in Inspector: Enemy")]
    public float speed = 10f;
    public float fireRate = 0.3f;
    public float health = 10;
    public int score = 100;

    protected BoundsCheck bndCheck;

    public Vector3 pos
    {
        get
        {
            return (this.transform.position);
        }
        set
        {
            this.transform.position = value;
        }
    }

    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Move();

        if (bndCheck != null && bndCheck.offDown)
        {
             Destroy(gameObject);          
        }
	}

    public virtual void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject otherGo = coll.gameObject;
        if(otherGo.tag == "ProjectileHero")
        {
            Destroy(otherGo);
            Destroy(gameObject);
        }
        else
        {
            print("enemy hit by on-projectilehero" + otherGo.name);
        }
    }
}
