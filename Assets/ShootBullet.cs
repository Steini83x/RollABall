
using UnityEngine;

public class ShootBullet : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float bulletForwardForce = 100f;
    public Transform playerTransform;
    public Vector3 offsetBullet;

    // Update is called once per frame
    void FixedUpdate()
    {
        // if (Input.GetKeyDown("space"))
        if (Input.GetKey(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, playerTransform.position + offsetBullet, playerTransform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(0, 0, bulletForwardForce * Time.deltaTime);
        }
    }


}
