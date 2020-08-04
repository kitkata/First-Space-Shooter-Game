using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    bool moveRight;
    int life;

    // Start is called before the first frame update
    void Start()
    {
        moveRight = true;
        life = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight) {
            transform.position += Vector3.right * 5 * Time.deltaTime;
            if (transform.position.x > 8) {
                moveRight = false;
            }
        }
        else {
            transform.position += Vector3.left * 5 * Time.deltaTime;
            if (transform.position.x < -8) {
                moveRight = true;
            }
        }

    }

    public void ReceiveDamage(int damageAmt) {
        life -= damageAmt;

        if (life==0) {
            Destroy(gameObject);
        }
    }
}
