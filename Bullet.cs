using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        Debug.Log(hitInfo.gameObject.name);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.tag == "Enemy")
        {
            FindObjectOfType<AudioManager>().AudioTrigger(AudioManager.SoundFXCat.Carrot, transform.position, 1f);
        }
        Destroy(gameObject);
    }
}
