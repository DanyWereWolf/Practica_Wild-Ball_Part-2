using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void Level_1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level_2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level_3()
    {
        SceneManager.LoadScene(3);
    }
    public void Level_4()
    {
        SceneManager.LoadScene(4);
    }
    public void Level_5()
    {
        SceneManager.LoadScene(5);
    }
    public void Repit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
