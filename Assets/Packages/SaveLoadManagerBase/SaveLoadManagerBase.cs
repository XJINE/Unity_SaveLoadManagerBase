using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class SaveLoadManagerBase : SingletonMonoBehaviour<SaveLoadManagerBase>
{
    #region Field

    [SerializeField]
    private string saveDir;

    #endregion Field

    #region Property

    public virtual string SaveDir => string.IsNullOrWhiteSpace(saveDir) ? SceneManager.GetActiveScene().name : saveDir;

    #endregion Property

    #region Method

    public abstract void Save();
    public abstract void Load();

    #endregion Method
}