using System.Collections;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    [SerializeField] 
    private Animation animation;

    [SerializeField] 
    private float delay;

    private void Start()
    {
        StartCoroutine(PlayAfterSeconds(delay));
    }

    private IEnumerator PlayAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        var value = animation.Play();
        Debug.Log($"Animation played: {(value ? "Successfully" : "Unsuccessfully")} {gameObject.name}");
    }

    [ContextMenu("PlayAnimation")]
    private void Play()
    {
        var value = animation.Play();
        Debug.Log(value);
    }
}