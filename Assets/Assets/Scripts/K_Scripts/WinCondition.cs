using UnityEngine;
using UnityEngine.SceneManagement;


public class WinCondition : MonoBehaviour
{
    public Transform player;
    public Transform goal;
    public float winDistance = 1.5f;

    //hi its me aurora adding in that scene loader >:D
    //um ok i'm back to do the win screen :)

    public string NextLevel;

    public bool hasWon = false;

    //win screen
    public GameObject WinScreen;

    public GameObject ReturnButton;

    void Update()
    {
        if (hasWon) return;

        float distance = Vector3.Distance(player.position, goal.position);

        if (distance <= winDistance)
        {
            hasWon = true;
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("You Win!");

        //Load win screen
        WinScreen.SetActive(true);
        ReturnButton.SetActive(true);


    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(NextLevel);
    }
}
