using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : Enemy {

    [Header("Set In Inspector: Enemy1")]
    public float waveFrequency = 2;
    public float waveWidth = 4;
    public float waveRotY = 45;
    private float x0;
    private float birthTime;

	// Use this for initialization
	void Start () {
        x0 = pos.x;
        birthTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Move()
    {
        Vector3 tempPos = pos;
        float age = Time.time - birthTime;

    }

