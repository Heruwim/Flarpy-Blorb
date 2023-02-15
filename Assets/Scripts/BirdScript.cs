using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _myRigidbody2D;
    [SerializeField] private float _flapStrength;
    public LogicScript logic;
    [SerializeField] private bool _birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _birdIsAlive)
        {
            _myRigidbody2D.velocity = Vector2.up * _flapStrength;           
        }

        if (transform.position.y < -20)
        {
            Destroy(gameObject);
            logic.GameOver();
        }
        else if (transform.position.y > 20)
        {
            Destroy(gameObject);
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        _birdIsAlive = false;
    }
}
