using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
       SceneManager.LoadScene("GameSceneRand");
   }

   public void GetMenu()
   {
       SceneManager.LoadScene("MenuScene");
   }

   public void Level2()
   {
       SceneManager.LoadScene("GameScene");
   }
   
}
