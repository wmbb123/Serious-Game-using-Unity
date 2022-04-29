using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int[] numbers = new int[2];
    int genRand;
    int genRand2;
    void randomNums()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(0, 2);
            genRand = numbers[i];
        }
    }
    void randomNums2()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Random.Range(0, 3);
            genRand2 = numbers[i];
        }
    }

         
    public void StartGame()
    {
        SceneManager.LoadScene("Difficulty");
    }
    public void StartGameMuted()
    {
        SceneManager.LoadScene("DifficultyMuted");
    }



    public void AboutUs()
    {
        SceneManager.LoadScene("AboutUs");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }



    public void Audio()
    {
        SceneManager.LoadScene("Audio");
    }
    public void AudioMuted()
    {
        SceneManager.LoadScene("AudioMuted");
    }


    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("Settings");
    }


    public void EasyDifficulty()
    {
        randomNums2();
        if (genRand2 == 0)
        {
            SceneManager.LoadScene("EasyDifficulty");
        }
        else if (genRand2 == 1)
        {
            SceneManager.LoadScene("2EasyDifficulty");
        }
        else if (genRand2 == 2)
        {
            SceneManager.LoadScene("3EasyDifficulty");
        }
        else
        {
            Debug.Log("Error! " + genRand2);
            SceneManager.LoadScene("MainMenu");
            //Error Scene
        }

    }
    public void EasyDifficultyMute()
    {
        randomNums2();
        if (genRand2 == 0)
        {
            SceneManager.LoadScene("1EasyWithNoAudio");
        }
        else if (genRand2 == 1)
        {
            SceneManager.LoadScene("2EasyWithNoAudio");
        }
        else if (genRand2 == 2)
        {
            SceneManager.LoadScene("3EasyWithNoAudio");
        }
        else
        {
            Debug.Log("Error! " + genRand2);
            SceneManager.LoadScene("MainMenu");
            //Error Scene
        }

    }

    public void HardDifficulty()
    {
        randomNums();
        if (genRand == 0)
        {
            SceneManager.LoadScene("HardDifficulty");
        }
        else if (genRand == 1)
        {
            SceneManager.LoadScene("2HardDifficulty");
        }
        else
        {
            Debug.Log("Error! " + genRand);
            SceneManager.LoadScene("MainMenu");
            //Error Scene
        }

    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
