using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody2D rb;
        [SerializeField] private float acceleration;
        [SerializeField] private float maxSpeed;
        [SerializeField] private float speed;
        private float startingSpeed;
        [SerializeField] private float moveX;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            startingSpeed = speed;
        }

        private void Update()
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                if (speed > maxSpeed)
                    speed = maxSpeed;
                else
                    speed += acceleration * Time.deltaTime;
                
                moveX = Input.GetAxis("Horizontal") * speed;
            }
            else
            {
                if (speed < startingSpeed)
                    speed = startingSpeed;
                else
                    speed -= acceleration * Time.deltaTime;
            }
        }

        private void FixedUpdate()
        {
            Vector2 velocity = rb.velocity;
            velocity.x = moveX;
            rb.velocity = velocity;
        }
    }
}
