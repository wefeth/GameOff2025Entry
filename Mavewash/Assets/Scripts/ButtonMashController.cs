using UnityEngine;

public class ButtonMashController : MonoBehaviour
{
    [Header("Player 1 Settings")]
    public Animator player1Animator;
    public KeyCode player1Key = KeyCode.A;
    public string player1MashAnim = "Hand_Palm_WaveAN";
    public string player1IdleAnim = "Hand_Palm_IdleAN";

    [Header("Player 2 Settings")]
    public Animator player2Animator;
    public KeyCode player2Key = KeyCode.L;
    public string player2MashAnim = "Hand_Back_WaveAN";
    public string player2IdleAnim = "Hand_Back_IdleAN";

    private void Update()
    {
        if (player1Animator != null)
        {
            if (Input.GetKeyDown(player1Key))
            {
                player1Animator.Play(player1MashAnim);
            }
            else if (Input.GetKeyUp(player1Key))
            {
                player1Animator.Play(player1IdleAnim);
            }
        }

        if (player2Animator != null)
        {
            if (Input.GetKeyDown(player2Key))
            {
                player2Animator.Play(player2MashAnim);
            }
            else if (Input.GetKeyUp(player2Key))
            {
                player2Animator.Play(player2IdleAnim);
            }
        }
    }
}
