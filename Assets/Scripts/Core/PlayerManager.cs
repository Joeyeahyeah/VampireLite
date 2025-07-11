using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private static PlayerManager _instance;

    public static Vector2 Position
    {
        get { return (Vector2)_instance.playerTransform.position; }
    }

    private void Awake()
    {
        _instance = this;
    }
}