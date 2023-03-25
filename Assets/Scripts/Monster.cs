using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D monsterBody;

    // Start is called before the first frame update
    void Awake()
    {
        monsterBody = GetComponent<Rigidbody2D>();
        speed = 7;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        monsterBody.velocity = new Vector2(speed, monsterBody.velocity.y);
    }
}
