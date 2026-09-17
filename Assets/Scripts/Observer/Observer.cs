using UnityEngine;

namespace Chapter.ObjectPoolObserver {
    public abstract class Observer : MonoBehaviour {
        public abstract void Notify(Subject subject);
    }
}