using UnityEngine;
using UnityEngine.UI;

public class DinoController : MonoBehaviour
{
    public Image[] Lifes;
    public Button UpButton;

    int _life = 3;
    bool _isJumping = false;

    void Start()
    {
        UpButton.onClick.AddListener(OnUpButtonClick);
    }

    void Move()
    {
        if (Input.GetButton("Horizontal"))
        {
            float h = Input.GetAxisRaw("Horizontal");
            transform.Translate(Vector3.right * h * 3 * Time.deltaTime);
            Vector3 currentPos = transform.position;
            currentPos.x = Mathf.Clamp(transform.position.x, -2.5f, 2.5f);
            transform.position = currentPos;

            if (h >= 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bomb"))
        {
            collision.gameObject.SetActive(false);
            Lifes[--_life].gameObject.SetActive(false);
            if (_life <= 0)
            {
                Die();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isJumping = false;
        }
    }

    void OnUpButtonClick()
    {
        if (!_isJumping)
        {
            _isJumping = true;
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 400);
        }
    }

    void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Result");
    }
}