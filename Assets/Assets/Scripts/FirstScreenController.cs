using UnityEngine;

public class FirstScreenController : MonoBehaviour
{   
    public GameObject welcomeScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        welcomeScreen.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            welcomeScreen.SetActive(false);
        }
    }
}
