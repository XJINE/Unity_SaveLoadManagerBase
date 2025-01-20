using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public abstract class SaveLoadManagerBase : SingletonMonoBehaviour<SaveLoadManagerBase>
{
    #region Field

    [SerializeField] protected string saveDir;

    [SerializeField] protected UnityEvent onPreSave;
    [SerializeField] protected UnityEvent onSave;
    [SerializeField] protected UnityEvent onPostSave;

    [SerializeField] protected UnityEvent onPreLoad;
    [SerializeField] protected UnityEvent onLoad;
    [SerializeField] protected UnityEvent onPostLoad;

    #endregion Field

    #region Property

    public virtual string SaveDir => string.IsNullOrWhiteSpace(saveDir) ? SceneManager.GetActiveScene().name : saveDir;
    
    public UnityEvent OnPreSave  => onPreSave;
    public UnityEvent OnSave     => onSave;
    public UnityEvent OnPostSave => onPostSave;

    public UnityEvent OnPreLoad  => onPreLoad;
    public UnityEvent OnLoad     => onLoad;
    public UnityEvent OnPostLoad => onPostLoad;

    #endregion Property

    #region Method

    public virtual void Save()
    {
        onPreSave .Invoke();
        onSave    .Invoke();
        onPostSave.Invoke();
    }

    public virtual void Load()
    {
        onPreLoad .Invoke();
        onLoad    .Invoke();
        onPostLoad.Invoke();
    }

    #endregion Method
}