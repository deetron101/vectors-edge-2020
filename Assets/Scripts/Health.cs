using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int totalHealth = 100;
    public int bulletDamage = 20;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "projectile(Clone)")
        {
            totalHealth = totalHealth - bulletDamage;
            checkHealth();
            Destroy(collision.gameObject);
        }

    }

    private void checkHealth()
    {
        if (totalHealth <= 0)
        {
            //Debug.Log(this.name + " is dead!");
        }
    }
}
