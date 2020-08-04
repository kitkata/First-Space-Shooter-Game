using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    int damageAmt;   

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * 10 * Time.deltaTime;

        if (transform.position.y > 7) {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            other.gameObject.GetComponent<Enemy>().ReceiveDamage(damageAmt);
            Destroy(gameObject);
        }
    }

    public int DamageAmt{
        get{return damageAmt;}
        set{damageAmt = value;}
    }
}
