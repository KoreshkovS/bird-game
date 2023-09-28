using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _myRigidbody;
    [SerializeField] private float _jumpForce;


    private bool birdIsAlive = true;
    private LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive && transform.position.y > -15)
        {
            _myRigidbody.velocity = Vector2.up * _jumpForce;
        }

        if (transform.position.y < -15 || transform.position.y > 15)
        {
            birdIsAlive = false;
            logic.GameOver();
        }
    }

   
}
