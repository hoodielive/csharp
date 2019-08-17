public interface IEntity : MonoBehaviour
{
    Transform transform { get; }
    void MoveFromTo(Vector3 startPosition, Vector3 endPosition);    
}
