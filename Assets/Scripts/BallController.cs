using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 6f;

    private Rigidbody2D rb;

    private void Start()
    {
     
        rb = GetComponent<Rigidbody2D>();

        LaunchBall();
    }

    void LaunchBall()
    {

        float direction = Random.value < 0.5 ? -1f : 1f;

        float yDirection = Random.Range(-0.7f, 0.7f);

        Vector2 directionVector = 
            new Vector2(direction, yDirection).normalized;

        rb.linearVelocity = directionVector * speed;
    }

    public void ResetBall()
    {
        transform.position = Vector3.zero;

        rb.linearVelocity = Vector2.zero;

        LaunchBall();
    }

}
