using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class BadGuy : ScriptableObject
{
    public new string name;
    
    public int health;
    public int damage;
    public int size;


}
