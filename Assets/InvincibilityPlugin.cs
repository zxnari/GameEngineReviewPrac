using UnityEngine;
using UnityDLL;

public class InvincibilityPlugin : MonoBehaviour
{

    [SerializeField]
    InClass Player;
    public void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Player.SetInv(true);
        }

        if (Input.GetKey(KeyCode.E))
        {
            Player.SetInv(false);
        }
    }
}
