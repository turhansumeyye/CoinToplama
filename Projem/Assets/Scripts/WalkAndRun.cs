using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAndRun : MonoBehaviour
{
    private Animator animator;
    public int puan = 0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        puan = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() 
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);

        }
        else 
        {
            animator.SetBool("IsWalking", false);
        }
        if (Input.GetKey(KeyCode.R))
        {
            animator.SetBool("IsRunning", true);
            transform.Translate(new Vector3(0, 0, 4f) * Time.deltaTime);

        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-2f, 0, 0) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(2f, 0, 0) * Time.deltaTime);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Coin")
        {
            puan++;
            Destroy(collision.gameObject);
        }
    }
}
