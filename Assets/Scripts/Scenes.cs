using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void OpenFloor1()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenFloor2()
    {
        SceneManager.LoadScene("Floor2");
    }

    public void OpenMap1()
    {
        SceneManager.LoadScene("Map1");
    }

    public void OpenMap2()
    {
        SceneManager.LoadScene("Map2");
    }

}