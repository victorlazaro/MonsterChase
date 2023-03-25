using UnityEngine;

public class Collector : MonoBehaviour
{
    private const string MONSTER_TAG = "Monster";
    private const string PLAYER_TAG = "Player";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(MONSTER_TAG) || collision.CompareTag(PLAYER_TAG))
        {
            Destroy(collision.gameObject); 
        }
    }
}
