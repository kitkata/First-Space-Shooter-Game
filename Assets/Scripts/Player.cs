using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab; 
    int damageAmt;

    // Start is called before the first frame update
    void Start()
    {
       damageAmt = 1;   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            if (transform.position.y < 4) {
                transform.position += Vector3.up * 5 * Time.deltaTime;
            }
        }

        if(Input.GetKey(KeyCode.D)) {
            if (transform.position.x < 8) {
                transform.position += Vector3.right * 5 * Time.deltaTime;
            }
        }

        if(Input.GetKey(KeyCode.S)) {
            if (transform.position.y > -4) {
                transform.position += Vector3.down * 5 * Time.deltaTime;
            }
        }

        if(Input.GetKey(KeyCode.A)) {
            if (transform.position.x > -8) {
                transform.position += Vector3.left * 5 * Time.deltaTime;
            }
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;
            bullet.GetComponent<Bullet>().DamageAmt = damageAmt;
        }
    }
}
