using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

[CreateAssetMenu(fileName = "CharacterData")]
public class CharacterData : ScriptableObject
{
    public string Name;
    public Texture2D Profile;

    public string Class;
    public string Race;
    public string Background;
    public string Alignment;

    [SerializeField]
    private int HP;
    [SerializeField]
    private int AC;
    [SerializeField]
    private int Speed;
    [SerializeField]
    private int XP;

    [SerializeField]
    private int Constitution;
    [SerializeField]
    private int Wisdom;
    [SerializeField]
    private int Strength;
    [SerializeField]
    private int Intelligence;
    [SerializeField]
    private int Dexterity;
    [SerializeField]
    private int Charisma;

}
