using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    public InputActionReference action;
    
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        };
    }
}
