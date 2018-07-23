using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemcont : MonoBehaviour {

    public float dropspeed = -0.3f;
    int randPos;
    bool onechan = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, this.dropspeed, 0);
        if (transform.position.y <= 1.5f)
        {
            if(onechan == true){
                randPos = Random.Range(1, 9);
                switch (randPos) {
                    case 1:
                        transform.position = new Vector3(-1.0f, transform.position.y, 1.0f);
                        break;
                    case 2:
                        transform.position = new Vector3(0, transform.position.y, 1.0f);
                        break;
                    case 3:
                        transform.position = new Vector3(1.0f, transform.position.y, 1.0f);
                        break;
                    case 4:
                        transform.position = new Vector3(-1.0f, transform.position.y, 0);
                        break;
                    case 5:
                        transform.position = new Vector3(0, transform.position.y, 0);
                        break;
                    case 6:
                        transform.position = new Vector3(1.0f, transform.position.y, 0);
                        break;
                    case 7:
                        transform.position = new Vector3(-1.0f, transform.position.y, -1.0f);
                        break;
                    case 8:
                        transform.position = new Vector3(0, transform.position.y, -1.0f);
                        break;
                    case 9:
                        transform.position = new Vector3(1.0f, transform.position.y, -1.0f);
                        break;
                }
                onechan = false;
                GetComponent<ParticleSystem>().Play();
            }
        }
        if(transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
	}
}
