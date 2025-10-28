using UnityEngine;
using UnityEngine.AI;
public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _destination;

    public void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        agent.SetDestination(_destination.position);
    }
}
// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...