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

}