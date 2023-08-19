using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int selectedZombiePosition = 0;
    public Text scoreText; // Fixed variable name
    private int score = 0;
    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;

    // Use this for initialization
    void Start()
    {
        SelectZombie(zombies[selectedZombiePosition]); // Select the initial zombie
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) // Changed to use KeyCode enum
        {
            GetZombieLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetZombieRight();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PushUp();
        }
    }

    void GetZombieLeft()
    {
        selectedZombiePosition = (selectedZombiePosition - 1 + zombies.Count) % zombies.Count; // Fixed looping
        SelectZombie(zombies[selectedZombiePosition]);
    }

    void GetZombieRight()
    {
        selectedZombiePosition = (selectedZombiePosition + 1) % zombies.Count; // Fixed looping
        SelectZombie(zombies[selectedZombiePosition]);
    }

    void SelectZombie(GameObject newZombie)
    {
        selectedZombie.transform.localScale = defaultSize;
        selectedZombie = newZombie;
        newZombie.transform.localScale = selectedSize;
    }

    void PushUp()
    {
        Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 10, ForceMode.Impulse);
    }

    public void AddPoint()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
    }
}
