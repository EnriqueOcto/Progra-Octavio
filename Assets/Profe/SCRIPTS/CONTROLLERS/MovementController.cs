using System.Net.Http.Headers;
using UnityEngine;
using System.Drawing;
using System;

/// <summary>
/// Un movimiento que requiere fisica se debe de hacer con rigidbody
/// 
/// Un movimiento que unicamente es lateral, salto, y ya, Usas CharacterController
/// 
/// Un movimiento con Transform puedes hacer de todo, pero requiere más trabajo
/// 
/// Inputs
/// Ridigbody
/// 3 Velocidades
/// 
/// </summary>
/// 
namespace Profe
{
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private float crouchSpeed = 3;
        [SerializeField] private float walkSpeed = 5;
        [SerializeField] private float runSpeed = 7;

        private Rigidbody rb;

        private Corrutinas corrutinas;

        public float playerHeight;
        public LayerMask whatIsGround;
        bool grounded;

        public float jumpForce;
        public float jumpCooldown;
        public float airMultiplier;
        bool readyToJump;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            corrutinas = GetComponent<Corrutinas>();
        }

        private void Start()
        {
        }

        private void Update()
        {
            //grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
            //Debug.DrawRay(transform.position, Vector3.down, UnityEngine.Color.red, playerHeight + 0.2f);

            //if (Input.GetKeyDown("Space") && readyToJump && grounded)
            //{
            //    readyToJump = false;

            //    Jump();

            //    Invoke(nameof(ResetJump), jumpCooldown);
            //}
        }

        private void FixedUpdate()
        {
            Move();
        }

        CharacterController cc;

        private void Move()
        {
            rb.velocity = transform.rotation * new Vector3(HorizontalMove(), 0, VerticalMove()) * ActualSpeed();
        }

        private float ActualSpeed()
        {
            return IsRunning() ? runSpeed : IsCrouching() ? crouchSpeed : walkSpeed; // Operador ternario
        }

        public float HorizontalMove()
        {
            return Input.GetAxis("Horizontal");
        }

        public float VerticalMove()
        {
            return Input.GetAxis("Vertical");
        }

        public bool IsMoving()
        {
            if (HorizontalMove() != 0 || VerticalMove() != 0)
            {
                
                return true;
            }
            else
            {
                
                return false;
            }
        }

        public bool IsRunning()
        {
            return Input.GetKey(KeyCode.LeftShift);
        }

        private bool IsCrouching()
        {
            return Input.GetKey(KeyCode.LeftControl);
        }

        //private void Jump()
        //{
        //    rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //    rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        //}

        //private void ResetJump()
        //{
        //    readyToJump = true;
        //}

    }
}