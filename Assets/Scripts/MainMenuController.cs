using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void PlayGame()
    {
        string selectedObject = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name; 

        GameManager.Instance.CharIndex = selectedObject == "Player 1 Select" ? 0 : 1;
        SceneManager.LoadScene("Gameplay");
    }
}
