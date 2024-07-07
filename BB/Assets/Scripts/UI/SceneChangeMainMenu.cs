// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;

// public class SceneChangeMainMenu : MonoBehaviour
// {
//     // Start is called before the first frame update

//     // Rigidbody2D rb;
//     void Start()
//     {
// // z   rb=GetComponent<Rigidbody2D>();
//     }

//     // Update is called once per frame
//     void Update()
//     {

//     }
//     private void OnCollisionEnter2D(Collision2D collision) {
//         if(collision.gameObject.CompareTag("Play"))
//         {
//             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//         }
//         if(collision.gameObject.CompareTag("LeaderBoard"))
//         {
//             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//         }
//         if(collision.gameObject.CompareTag("Settings"))
//         {
//             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
//         }
//         if(collision.gameObject.CommpareTag("Quit"))
//         {
//             Application.Quit();
//             Debug.Log("Quit");
//         }

        
//     }
// }



using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Initialization code if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Update code if needed
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Play"))
        {
            Debug.Log("Play");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
        }
        else if (collision.gameObject.CompareTag("LeaderBoard"))
        {
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("LeaderBoard");
           
        }
        else if (collision.gameObject.CompareTag("Settings"))
        {
            Debug.Log("Settings");
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           
        }
        else if (collision.gameObject.CompareTag("Quit"))
        {
            Application.Quit();
            Debug.Log("Quit");
        }
    }
}