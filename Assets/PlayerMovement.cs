using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Vector3 upDirection;
    public Vector3 downDirection;
    public Vector3 leftDirection;
    public Vector3 rightDirection;


    public GameObject gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += upDirection;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().position += downDirection;
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position += leftDirection;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position += rightDirection;
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Gem"))
        {
            Destroy(collision.gameObject);
            Debug.Log(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
