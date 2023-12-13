using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerBehaviour : MonoBehaviour
{
    public CharacterController characterController;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float speed = 10f;
    public float groundDistance = 0.4f;
    public float gravity = -9.81f;
    public TextMeshProUGUI textMeshPro;
    int count = 0;
    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        characterController.Move(speed * Time.deltaTime * move);
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            ++count;
            textMeshPro.text = count.ToString();
            Destroy(other.gameObject);
        }
    }
}
