using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int player_move_speed;
    public float player_jump_force = 200f;
    public float player_rotate_speed = 300f;
    public bool isJump = false;
    private float h = 0f;
    private float v = 0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isJump = true;
        }
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * Time.deltaTime * player_rotate_speed * Input.GetAxis("Mouse X"));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * player_move_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * player_move_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * player_move_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * player_move_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (isJump)
            {
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                GetComponent<Rigidbody>().AddForce(new Vector3(0, player_jump_force, 0));
                isJump = false;
            }

        }
    }
}
