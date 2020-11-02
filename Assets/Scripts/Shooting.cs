using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject theBullet;
    public Transform barrelEnd;

    public int bulletSpeed = 100;
    public float despawnTime = 3.0f;

    public bool shootAble = true;
    public float waitBeforeNextShot = 0.25f;

    private Controls controls;
    private float shootingInput = 0;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Update()
    { 
        if (name == "Player 1")
        {
            shootingInput = controls.Player.Player1Fire.ReadValue<float>();
        }
        else
        {
            shootingInput = controls.Player.Player2Fire.ReadValue<float>();
        }
            
        if (shootingInput==1 && shootAble)
        {
                shootAble = false;
                shootingInput = 0;
                Shoot();
                StartCoroutine(ShootingYield());
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(theBullet, barrelEnd.position, barrelEnd.rotation);
        bullet.SetActive(true);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;
        Destroy(bullet, despawnTime);
    }

    private IEnumerator ShootingYield()
    {
        yield return new WaitForSeconds(waitBeforeNextShot);
        shootAble = true;
    }
}