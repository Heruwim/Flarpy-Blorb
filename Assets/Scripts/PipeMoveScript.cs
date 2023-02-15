using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _deadZone = -45;

    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * _moveSpeed) * Time.deltaTime;

        if (transform.position.x < _deadZone)
            Destroy(gameObject); 
    }
}
