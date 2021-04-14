using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 250.0f;
    public Vector3 jump;
    public float jumpForce = 3.0f;
    public bool isGrounded;

    public AudioSource audioSource;
    public AudioClip jumpSound;

    private int numLives = 3;
    private int numTokens = 0;
    private Vector3 pos;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        jump = new Vector3(0.0f, 2.0f, 0.0f);
        rb = gameObject.GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 20.0f;
        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // get input axis
        float ySpeed = Input.GetAxis("Vertical");
        float xSpeed = Input.GetAxis("Horizontal");

        // add spin to ball
        rb.AddTorque(new Vector3(xSpeed, 0, ySpeed) * speed * Time.deltaTime);

        // if the player is on the ground they can jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            audioSource.PlayOneShot(jumpSound, .5f);
            isGrounded = false;
        }

        // Reset to last checkpoint
        if (Input.GetKeyDown(KeyCode.R))
        {
            death();
        }

        // increase num lives cheatcode
        if (Input.GetKeyDown(KeyCode.T))
        {
            numLives++;
        }
    }

    // once the player is grounded reset isGrounded to true
    private void OnCollisionStay()
    {
        isGrounded = true;
    }

    // returns number of game tokens collected
    public int getNumTokens()
    {
        return numTokens;
    }

    // add 1 to number of tokens when token is collected
    public void addToken()
    {
        numTokens++;
    }

    // control num lives
    public void death()
    {
        if (numLives > 0)
        {
            numLives--;
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.angularVelocity = new Vector3(0f, 0f, 0f);
            transform.position = pos;
        }
        else
        {
            resetGame();
        }
    }

    public int getLives()
    {
        return numLives;
    }

    // reset game
    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // set checkpoint
    public void setCheckpoint()
    {
        pos = gameObject.transform.position;
    }
}
