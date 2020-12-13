using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
  
    [SerializeField] Text livesText;
    public static int lives;


    // Start is called before the first frame update
    void Start()
    {
      lives = 3;
      livesText.text = lives.ToString("0");
    }

    void CheckLoss() {
      
      if (lives == 0) {
        SceneManager.LoadScene("LostScene");
      }
    }

    public void LoseLife() {
      lives--;
      livesText.text = lives.ToString("0");
      CheckLoss();
    }
}
