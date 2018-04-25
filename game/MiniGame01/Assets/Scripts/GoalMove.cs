using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMove : MonoBehaviour {
	private Vector2 r;
	private int flag=0;

	// Use this for initialization
	void Start () {
		r.x = this.transform.position.x;
		r.y = this.transform.position.y;
		this.transform.position = r;
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 0) {
			r.x = this.transform.position.x + Random.Range (0.04f, 0f);
			r.y = this.transform.position.y;
			this.transform.position = r;
			if (r.x > 2f)
				flag = 1;
		}
		else if(flag==1){
			r.x = this.transform.position.x + Random.Range (-0.04f, 0f);
			r.y = this.transform.position.y;
			this.transform.position = r;
			if (r.x < -2f)
				flag = 0;
	}
}

}