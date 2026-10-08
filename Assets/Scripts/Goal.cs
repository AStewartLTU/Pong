using UnityEngine;

public class Goal : MonoBehaviour {

    public bool player1Scores;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            
       if (collision.CompareTag("Ball"))
        {
            if (player1Scores)
            {

                GameManager.instance.Player1Scores();

            }
            else
            {
                GameManager.instance.Player2Scores();
            }



        }




    }






}

    

