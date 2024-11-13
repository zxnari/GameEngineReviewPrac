using UnityEngine;
using UnityDLL;

public class InvincibilityPlugin : MonoBehaviour
{
    [SerializeField] AudioClip phaseSFX;
    [SerializeField] AudioClip unphaseSFX;
    [SerializeField]
    InClass Player;
    public void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Player.SetInv(true);
            AudioManager.Instance.PlaySFX(phaseSFX);
        }

        if (Input.GetKey(KeyCode.E))
        {
            Player.SetInv(false);
            AudioManager.Instance.PlaySFX(unphaseSFX);
        }
    }
}
