using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    int numberOfPlayers;
    PlayerInputManager playerInputManager;
    
    // Start is called before the first frame update
    void Start()
    {
        playerInputManager = gameObject.GetComponent<PlayerInputManager>();

        playerInputManager.JoinPlayer(0, 0, "KeyboardLeft");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
