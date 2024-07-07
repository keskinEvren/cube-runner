using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    float jumpPower = 10f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject restartButton;
    [SerializeField] AudioSource bgAudioSource;
    [SerializeField] AudioSource gameOverAudioSource;
    GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        panel = GameObject.Find("Panel");
        restartButton = GameObject.Find("RestartButton");
        background = GameObject.Find("Background");
        bgAudioSource = background.GetComponent<AudioSource>();

        panel.SetActive(false);
        restartButton.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
        if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }
    bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameOverAudioSource.Play();
            bgAudioSource.Stop();
            panel.SetActive(true);
            restartButton.SetActive(true);
            Time.timeScale = 0f;
            Debug.Log("Game Over");  
        }
    }
}
