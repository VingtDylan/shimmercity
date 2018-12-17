﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisionAttack : MonoBehaviour {
    float attackTimer;
    float attackTime;
    private Animator ani;
    float mytime = 1.0f;

	public float harm=10.0f;

	void Start () {
        ani = GetComponent<Animator>();
	}
	
    void Update()
    {
        mytime -= Time.deltaTime;
        if (mytime < -3)
        {
            ani.Play("poision");
            ani.Play("poision_static");
            mytime = 1.0f;
        }

        //if (attackTimer > 0)
        //{
        //    attackTimer -= Time.deltaTime;
        //    if (attackTimer == 3) {
        //        ani.SetBool("IsBegin", false);
        //    }
        //}
        //if (attackTimer < 0)
        //    attackTimer = 0;
        //if (attackTimer == 0)
        //{
        //    ani.SetBool("IsBegin", true);
        //    attackTimer = attackTime;
        //}
        //if (Time.frameCount % 60 == 0)
        //{
        //    ani.SetBool("IsBegin", true);
        //}
        //if (Time.frameCount % 100 == 0) {
        //    ani.SetBool("IsBegin", false);
        //}
    }

	private void OnTriggerStay2D(Collider2D col){
		if (col.tag == "Player"){
			col.SendMessage ("PlayerDecreaseHP",harm);
		}
	}
}
