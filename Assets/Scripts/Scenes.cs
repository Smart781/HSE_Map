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
    public void OpenFloor3()
    {
        SceneManager.LoadScene("Floor3");
    }
    public void OpenFloor4()
    {
        SceneManager.LoadScene("Floor4");
    }
    public void OpenFloor5()
    {
        SceneManager.LoadScene("Floor5");
    }
}