using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    public float speed = 10;
    [SerializeField] Rigidbody rb;

    float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;
    [SerializeField] float jumpForce = 600f;
    [SerializeField] LayerMask groundMask;

    public GameObject gameOverPanel;  // Deklarasi panel Game Over di luar fungsi
    public GameManager gameManager;

    void Start()
    {
        gameOverPanel.SetActive(false);  // Cek apakah panel dapat muncul secara manual
    }

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    private void Update()
    {
        if (!alive) return;
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (transform.position.y < -5)
        {
            Die();
        }
    }
    public void Die()
    {
        alive = false;
        // Menampilkan panel Game Over
        // Debug.Log("Player died!");
        // ShowGameOver();
        // Hentikan waktu agar game berhenti
        //ShowGameOver();
        //Time.timeScale = 0f;  
        gameManager.ShowGameOver();
        Invoke("Restart",2);
        //Restart();
    }

    void ShowGameOver()
    {
        gameOverPanel.SetActive(true);  // Aktifkan panel Game Over
        gameManager.ShowGameOver(); 
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Jump()
    {
        Debug.Log("Jump called");
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);
    
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
