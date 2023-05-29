/* NOTE: Modified Unity C# Script Template by Alec AlMartson...
...on Path:   /PathToUnityHub/Unity/Hub/Editor/UNITY_VERSION_FOR_EXAMPLE__2020.3.36f1/Editor/Data/Resources/ScriptTemplates/81-C# Script-NewBehaviourScript.cs
*/
using UnityEngine;


public class SoundManager : MonoBehaviour
{

    #region Attributes

    [Tooltip("First sound you want to execute, in a chain reaction..:")]
    [SerializeField]
    public AudioClip firstSFX;
    
    [Tooltip("Second sound you want to execute, in a chain reaction..:")]
    [SerializeField]
    public AudioClip secondSFX;

    private AudioSource audioSource;

    #endregion Attributes


    #region Unity Methods

    /// <summary>
    /// Awake is called before the Start calls round
    /// </summary>



    /// <summary>
    /// Start is called before the first frame update
    /// </summary>



    /// <summary>
    /// Update is called once per frame
    /// </summary>


    #endregion Unity Methods
    

    #region My Custom Methods
    
    private void PlaySounds()
    {
        audioSource.PlayOneShot(firstSFX);
        Invoke(nameof(PlaySecondSound), firstSFX.length);
    }

    private void PlaySecondSound()
    {
        audioSource.PlayOneShot(secondSFX);
    }

    #endregion My Custom Methods

}
