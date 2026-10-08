using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7f;
    public bool playerOne;

    private void Update()
    {
        float movement = 0f;

        if (playerOne)
        {
            // Player 1: W/S
            if (Input.GetKey(KeyCode.W))
            {
                movement = 1f;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                movement = -1f;
            }
        }
        else
        {
            // Player 2: Up/Down Arrow
            if (Input.GetKey(KeyCode.UpArrow))
            {
                movement = 1f;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                movement = -1f;
            }
        }

        // Move the paddle
        transform.Translate(Vector3.up * movement * speed * Time.deltaTime);

        // Keep the paddle inside the play area
        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, -3.8f, 3.8f);
        transform.position = position;
    }
}