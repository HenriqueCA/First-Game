using UnityEngine;
using UnityEngine.UI;

public class ResetVolume : MonoBehaviour {

	public Scrollbar scrollbar;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		scrollbar.value = AudioManager.volumeMaster;
	}


}
